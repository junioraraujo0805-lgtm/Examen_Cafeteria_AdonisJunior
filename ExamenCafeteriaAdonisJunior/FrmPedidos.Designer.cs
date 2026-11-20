namespace ExamenCafeteriaAdonisJunior
{
    partial class FrmPedidos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.chkFrecuente = new System.Windows.Forms.CheckBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.grpTamano = new System.Windows.Forms.GroupBox();
            this.rbtGrande = new System.Windows.Forms.RadioButton();
            this.rbtNormal = new System.Windows.Forms.RadioButton();
            this.grpServicio = new System.Windows.Forms.GroupBox();
            this.rbtLlevar = new System.Windows.Forms.RadioButton();
            this.rbtLocal = new System.Windows.Forms.RadioButton();
            this.chkPorcionExtra = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.lstPedido = new System.Windows.Forms.ListBox();
            this.lblTitSubtotal = new System.Windows.Forms.Label();
            this.lblTitDescuento = new System.Windows.Forms.Label();
            this.lblTitEmpaque = new System.Windows.Forms.Label();
            this.lblTitItbis = new System.Windows.Forms.Label();
            this.lblTitTotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblEmpaque = new System.Windows.Forms.Label();
            this.lblItbis = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.grpTamano.SuspendLayout();
            this.grpServicio.SuspendLayout();
            this.SuspendLayout();

            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(20, 22);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(44, 15);
            this.lblCliente.Text = "Cliente:";

            this.txtCliente.Location = new System.Drawing.Point(95, 19);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(195, 23);
            this.txtCliente.TabIndex = 0;

            this.chkFrecuente.AutoSize = true;
            this.chkFrecuente.Location = new System.Drawing.Point(305, 21);
            this.chkFrecuente.Name = "chkFrecuente";
            this.chkFrecuente.Size = new System.Drawing.Size(121, 19);
            this.chkFrecuente.TabIndex = 1;
            this.chkFrecuente.Text = "Cliente frecuente";
            this.chkFrecuente.UseVisualStyleBackColor = true;

            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(20, 56);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 15);
            this.lblFecha.Text = "Fecha:";

            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(95, 52);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(195, 23);
            this.dtpFecha.TabIndex = 2;

            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(20, 90);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(56, 15);
            this.lblProducto.Text = "Producto:";

            this.txtProducto.Location = new System.Drawing.Point(95, 87);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(195, 23);
            this.txtProducto.TabIndex = 3;

            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(20, 124);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblPrecio.Text = "Precio:";

            this.txtPrecio.Location = new System.Drawing.Point(95, 121);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(115, 23);
            this.txtPrecio.TabIndex = 4;

            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(20, 158);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(55, 15);
            this.lblCantidad.Text = "Cantidad:";

            this.nudCantidad.Location = new System.Drawing.Point(95, 155);
            this.nudCantidad.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            this.nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(75, 23);
            this.nudCantidad.TabIndex = 5;
            this.nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });

            this.grpTamano.Controls.Add(this.rbtGrande);
            this.grpTamano.Controls.Add(this.rbtNormal);
            this.grpTamano.Location = new System.Drawing.Point(20, 195);
            this.grpTamano.Name = "grpTamano";
            this.grpTamano.Size = new System.Drawing.Size(195, 85);
            this.grpTamano.TabIndex = 6;
            this.grpTamano.TabStop = false;
            this.grpTamano.Text = "Tamaño";

            this.rbtNormal.AutoSize = true;
            this.rbtNormal.Checked = true;
            this.rbtNormal.Location = new System.Drawing.Point(12, 24);
            this.rbtNormal.Name = "rbtNormal";
            this.rbtNormal.Size = new System.Drawing.Size(65, 19);
            this.rbtNormal.TabIndex = 0;
            this.rbtNormal.TabStop = true;
            this.rbtNormal.Text = "Normal";
            this.rbtNormal.UseVisualStyleBackColor = true;

            this.rbtGrande.AutoSize = true;
            this.rbtGrande.Location = new System.Drawing.Point(12, 50);
            this.rbtGrande.Name = "rbtGrande";
            this.rbtGrande.Size = new System.Drawing.Size(123, 19);
            this.rbtGrande.TabIndex = 1;
            this.rbtGrande.Text = "Grande (+RD$25)";
            this.rbtGrande.UseVisualStyleBackColor = true;

            this.grpServicio.Controls.Add(this.rbtLlevar);
            this.grpServicio.Controls.Add(this.rbtLocal);
            this.grpServicio.Location = new System.Drawing.Point(228, 195);
            this.grpServicio.Name = "grpServicio";
            this.grpServicio.Size = new System.Drawing.Size(210, 85);
            this.grpServicio.TabIndex = 7;
            this.grpServicio.TabStop = false;
            this.grpServicio.Text = "Servicio";

            this.rbtLocal.AutoSize = true;
            this.rbtLocal.Checked = true;
            this.rbtLocal.Location = new System.Drawing.Point(12, 24);
            this.rbtLocal.Name = "rbtLocal";
            this.rbtLocal.Size = new System.Drawing.Size(124, 19);
            this.rbtLocal.TabIndex = 0;
            this.rbtLocal.TabStop = true;
            this.rbtLocal.Text = "Consumir en local";
            this.rbtLocal.UseVisualStyleBackColor = true;

            this.rbtLlevar.AutoSize = true;
            this.rbtLlevar.Location = new System.Drawing.Point(12, 50);
            this.rbtLlevar.Name = "rbtLlevar";
            this.rbtLlevar.Size = new System.Drawing.Size(134, 19);
            this.rbtLlevar.TabIndex = 1;
            this.rbtLlevar.Text = "Para llevar (+RD$20)";
            this.rbtLlevar.UseVisualStyleBackColor = true;

            this.chkPorcionExtra.AutoSize = true;
            this.chkPorcionExtra.Location = new System.Drawing.Point(20, 294);
            this.chkPorcionExtra.Name = "chkPorcionExtra";
            this.chkPorcionExtra.Size = new System.Drawing.Size(156, 19);
            this.chkPorcionExtra.TabIndex = 8;
            this.chkPorcionExtra.Text = "Porción extra (+RD$30)";
            this.chkPorcionExtra.UseVisualStyleBackColor = true;

            this.btnCalcular.Location = new System.Drawing.Point(20, 336);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(115, 34);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular total";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            this.btnLimpiar.Location = new System.Drawing.Point(145, 336);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(115, 34);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Nuevo pedido";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.btnSalir.Location = new System.Drawing.Point(270, 336);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 34);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            this.btnAgregar.Location = new System.Drawing.Point(710, 18);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(165, 34);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar al pedido";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            this.lblEncabezado.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblEncabezado.Location = new System.Drawing.Point(465, 62);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(410, 20);

            this.lstPedido.Font = new System.Drawing.Font("Consolas", 9F);
            this.lstPedido.FormattingEnabled = true;
            this.lstPedido.ItemHeight = 14;
            this.lstPedido.Location = new System.Drawing.Point(465, 84);
            this.lstPedido.Name = "lstPedido";
            this.lstPedido.Size = new System.Drawing.Size(410, 144);
            this.lstPedido.TabIndex = 13;

            this.lblTitSubtotal.AutoSize = true;
            this.lblTitSubtotal.Location = new System.Drawing.Point(575, 245);
            this.lblTitSubtotal.Name = "lblTitSubtotal";
            this.lblTitSubtotal.Size = new System.Drawing.Size(55, 15);
            this.lblTitSubtotal.Text = "Subtotal";

            this.lblTitDescuento.AutoSize = true;
            this.lblTitDescuento.Location = new System.Drawing.Point(575, 273);
            this.lblTitDescuento.Name = "lblTitDescuento";
            this.lblTitDescuento.Size = new System.Drawing.Size(65, 15);
            this.lblTitDescuento.Text = "Descuento";

            this.lblTitEmpaque.AutoSize = true;
            this.lblTitEmpaque.Location = new System.Drawing.Point(575, 301);
            this.lblTitEmpaque.Name = "lblTitEmpaque";
            this.lblTitEmpaque.Size = new System.Drawing.Size(59, 15);
            this.lblTitEmpaque.Text = "Empaque";

            this.lblTitItbis.AutoSize = true;
            this.lblTitItbis.Location = new System.Drawing.Point(575, 329);
            this.lblTitItbis.Name = "lblTitItbis";
            this.lblTitItbis.Size = new System.Drawing.Size(72, 15);
            this.lblTitItbis.Text = "ITBIS (18 %)";

            this.lblTitTotal.AutoSize = true;
            this.lblTitTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitTotal.Location = new System.Drawing.Point(575, 360);
            this.lblTitTotal.Name = "lblTitTotal";
            this.lblTitTotal.Size = new System.Drawing.Size(102, 15);
            this.lblTitTotal.Text = "TOTAL A PAGAR";

            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubtotal.Location = new System.Drawing.Point(745, 242);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(130, 22);
            this.lblSubtotal.Text = "RD$ 0.00";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescuento.Location = new System.Drawing.Point(745, 270);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(130, 22);
            this.lblDescuento.Text = "RD$ 0.00";
            this.lblDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblEmpaque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmpaque.Location = new System.Drawing.Point(745, 298);
            this.lblEmpaque.Name = "lblEmpaque";
            this.lblEmpaque.Size = new System.Drawing.Size(130, 22);
            this.lblEmpaque.Text = "RD$ 0.00";
            this.lblEmpaque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblItbis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItbis.Location = new System.Drawing.Point(745, 326);
            this.lblItbis.Name = "lblItbis";
            this.lblItbis.Size = new System.Drawing.Size(130, 22);
            this.lblItbis.Text = "RD$ 0.00";
            this.lblItbis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(745, 357);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(130, 22);
            this.lblTotal.Text = "RD$ 0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 405);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblItbis);
            this.Controls.Add(this.lblEmpaque);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblTitTotal);
            this.Controls.Add(this.lblTitItbis);
            this.Controls.Add(this.lblTitEmpaque);
            this.Controls.Add(this.lblTitDescuento);
            this.Controls.Add(this.lblTitSubtotal);
            this.Controls.Add(this.lstPedido);
            this.Controls.Add(this.lblEncabezado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.chkPorcionExtra);
            this.Controls.Add(this.grpServicio);
            this.Controls.Add(this.grpTamano);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.chkFrecuente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafetería El Buen Sabor - Pedidos";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);

            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.grpTamano.ResumeLayout(false);
            this.grpTamano.PerformLayout();
            this.grpServicio.ResumeLayout(false);
            this.grpServicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.CheckBox chkFrecuente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.GroupBox grpTamano;
        private System.Windows.Forms.RadioButton rbtNormal;
        private System.Windows.Forms.RadioButton rbtGrande;
        private System.Windows.Forms.GroupBox grpServicio;
        private System.Windows.Forms.RadioButton rbtLocal;
        private System.Windows.Forms.RadioButton rbtLlevar;
        private System.Windows.Forms.CheckBox chkPorcionExtra;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.ListBox lstPedido;
        private System.Windows.Forms.Label lblTitSubtotal;
        private System.Windows.Forms.Label lblTitDescuento;
        private System.Windows.Forms.Label lblTitEmpaque;
        private System.Windows.Forms.Label lblTitItbis;
        private System.Windows.Forms.Label lblTitTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblEmpaque;
        private System.Windows.Forms.Label lblItbis;
        private System.Windows.Forms.Label lblTotal;
    }
}