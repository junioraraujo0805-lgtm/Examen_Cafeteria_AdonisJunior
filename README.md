# Cafetería "El Buen Sabor" - Examen Práctico

## 1. Nombre y matrícula
Adonis Alburquerque — Matrícula: 2025-3296

## 2. Descripción del programa
Sistema en C# Windows Forms para tomar pedidos en la cafetería "El Buen Sabor". Permite agregar productos con su cantidad, aplicar recargos por tamaño grande o porción extra, descontar a clientes frecuentes, cobrar el empaque si es para llevar y sacar el ITBIS y el total final.

## 3. Datos de entrada
- Nombre del cliente (`txtCliente`)
- Casilla de cliente frecuente (`chkFrecuente`)
- Fecha del pedido (`dtpFecha`)
- Nombre del producto (`txtProducto`)
- Precio base (`txtPrecio`)
- Cantidad del 1 al 20 (`nudCantidad`)
- Tamaño: Normal o Grande (`rbtNormal`, `rbtGrande`)
- Porción extra (`chkPorcionExtra`)
- Tipo de servicio: Consumir en local o Para llevar (`rbtLocal`, `rbtLlevar`)

## 4. Proceso
1. Toma el precio del producto y le suma RD$25 si se eligió Grande y RD$30 si lleva porción extra.
2. Multiplica ese precio unitario por la cantidad para sacar el total de la línea y lo va sumando al subtotal.
3. Si está marcado como cliente frecuente, calcula el 10 % de descuento sobre el subtotal.
4. Si el pedido es para llevar, agrega RD$20 una sola vez por el empaque.
5. Calcula la base imponible (`subtotal - descuento + empaque`), aplica el 18 % de ITBIS y obtiene el total a pagar.

## 5. Salida
- Lista de productos (`lstPedido`) con su encabezado (`Cant`, `Producto`, `Precio`, `Total`) ordenado en columnas.
- Montos mostrados como `RD$ 0.00` en Subtotal, Descuento, Empaque, ITBIS y Total a pagar.

## 6. Capturas de pantalla
![Captura del programa](<img width="911" height="533" alt="b72a8a64-ee7e-49e1-b5bf-965b05fa200c" src="https://github.com/user-attachments/assets/de112796-52b5-4514-a902-9190d605d7a9" />
)
![Captura 2](<img width="922" height="498" alt="f0b9dcd2-4669-414b-8cf2-d4e2c6731e55" src="https://github.com/user-attachments/assets/0eb11afb-2217-43cc-b95f-37b532fd7654" />
)
![Captura 3](<img width="920" height="498" alt="33c6bd9f-605b-4ace-8d67-e06e4ac8f513" src="https://github.com/user-attachments/assets/7a43a256-1e90-4377-b00a-2eeeb19a9c7e" />
)
![Captura 4](<img width="936" height="517" alt="98c2c911-2ad9-4a80-a189-f9e1a2c2f98a" src="https://github.com/user-attachments/assets/b3238f52-51e3-4ed8-9795-f7c9313d63bb" />
)


