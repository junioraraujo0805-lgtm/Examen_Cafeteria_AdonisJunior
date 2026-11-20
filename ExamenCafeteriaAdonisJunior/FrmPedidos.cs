using System;
using System.Globalization;
using System.Windows.Forms;

namespace ExamenCafeteriaAdonisJunior
{
    public partial class FrmPedidos : Form
    {
        // Reglas del negocio
        private const decimal RECARGO_GRANDE = 25m;
        private const decimal RECARGO_EXTRA = 30m;
        private const decimal DESCUENTO_FRECUENTE = 0.10m;
        private const decimal EMPAQUE_LLEVAR = 20m;
        private const decimal TASA_ITBIS = 0.18m;

        private decimal subtotalAcumulado = 0m;
        private readonly CultureInfo rd = CultureInfo.GetCultureInfo("es-DO");

        public FrmPedidos()
        {
            InitializeComponent();
        }

        // Formato de moneda RD$ 0.00
        private string FormatoRD(decimal monto)
        {
            return "RD$ " + monto.ToString("N2", rd);
        }

        // Formato numérico para columnas del ListBox
        private string FormatoNumero(decimal monto)
        {
            return monto.ToString("N2", rd);
        }

        // Encabezado alineado en columnas (6, 24, 10, 12)
        private string ObtenerEncabezado()
        {
            return "Cant".PadRight(6) +
                   "Producto".PadRight(24) +
                   "Precio".PadLeft(10) +
                   "Total".PadLeft(12);
        }

        // Agrega el tamaño o extra entre paréntesis
        private string ArmarProducto(string nombre, bool esGrande, bool llevaExtra)
        {
            if (esGrande && llevaExtra)
                return $"{nombre} (Grande, Extra)";
            if (esGrande)
                return $"{nombre} (Grande)";
            if (llevaExtra)
                return $"{nombre} (Extra)";

            return $"{nombre} (Normal)";
        }

        // Formatea cada línea del pedido
        private string ArmarLinea(int cantidad, string productoDetalle, decimal precioUnitario, decimal totalLinea)
        {
            string cCant = cantidad.ToString().PadRight(6);
            string cProd = productoDetalle.Length > 24
                ? productoDetalle.Substring(0, 24)
                : productoDetalle.PadRight(24);
            string cPrecio = FormatoNumero(precioUnitario).PadLeft(10);
            string cTotal = FormatoNumero(totalLinea).PadLeft(12);

            return cCant + cProd + cPrecio + cTotal;
        }

        // Reinicia los controles del producto
        private void LimpiarControlesProducto()
        {
            txtProducto.Clear();
            txtPrecio.Clear();
            nudCantidad.Value = 1;
            rbtNormal.Checked = true;
            chkPorcionExtra.Checked = false;
            txtProducto.Focus();
        }

        // Reinicia las etiquetas de totales
        private void LimpiarResultados()
        {
            lblSubtotal.Text = FormatoRD(0m);
            lblDescuento.Text = FormatoRD(0m);
            lblEmpaque.Text = FormatoRD(0m);
            lblItbis.Text = FormatoRD(0m);
            lblTotal.Text = FormatoRD(0m);
        }

        // Reinicia todo el formulario
        private void ReiniciarPedido()
        {
            txtCliente.Clear();
            chkFrecuente.Checked = false;
            dtpFecha.Value = DateTime.Today;
            rbtLocal.Checked = true;

            lstPedido.Items.Clear();
            lblEncabezado.Text = ObtenerEncabezado();

            subtotalAcumulado = 0m;
            LimpiarResultados();
            LimpiarControlesProducto();
            txtCliente.Focus();
        }

        // Carga inicial
        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            ReiniciarPedido();
        }

        // Agrega el producto al pedido y acumula el subtotal
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtProducto.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Debe digitar el nombre del producto.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProducto.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out decimal precioBase) &&
                !decimal.TryParse(txtPrecio.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out precioBase))
            {
                MessageBox.Show("Debe digitar un precio válido.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return;
            }

            if (precioBase <= 0m)
            {
                MessageBox.Show("El precio debe ser mayor que cero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return;
            }

            decimal precioUnitario = precioBase;
            if (rbtGrande.Checked)
                precioUnitario += RECARGO_GRANDE;

            if (chkPorcionExtra.Checked)
                precioUnitario += RECARGO_EXTRA;

            int cantidad = (int)nudCantidad.Value;
            decimal totalLinea = precioUnitario * cantidad;

            string detalle = ArmarProducto(nombre, rbtGrande.Checked, chkPorcionExtra.Checked);
            lstPedido.Items.Add(ArmarLinea(cantidad, detalle, precioUnitario, totalLinea));

            subtotalAcumulado += totalLinea;
            lblSubtotal.Text = FormatoRD(subtotalAcumulado);

            LimpiarControlesProducto();
        }

        // Calcula descuento, empaque, base imponible, ITBIS y total
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (lstPedido.Items.Count == 0)
            {
                MessageBox.Show("No hay productos en el pedido para calcular.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProducto.Focus();
                return;
            }

            decimal subtotal = subtotalAcumulado;
            decimal descuento = chkFrecuente.Checked ? subtotal * DESCUENTO_FRECUENTE : 0m;
            decimal empaque = rbtLlevar.Checked ? EMPAQUE_LLEVAR : 0m;
            decimal baseImponible = subtotal - descuento + empaque;
            decimal itbis = baseImponible * TASA_ITBIS;
            decimal total = baseImponible + itbis;

            lblSubtotal.Text = FormatoRD(subtotal);
            lblDescuento.Text = FormatoRD(descuento);
            lblEmpaque.Text = FormatoRD(empaque);
            lblItbis.Text = FormatoRD(itbis);
            lblTotal.Text = FormatoRD(total);
        }

        // Limpia todo para un nuevo pedido
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ReiniciarPedido();
        }

        // Confirma antes de cerrar
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show(
                "¿Desea salir de la aplicación?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}