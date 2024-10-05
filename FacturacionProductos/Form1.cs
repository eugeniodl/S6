namespace FacturacionProductos
{
    public partial class Form1 : Form
    {
        private IProducto[] productos;
        private int indiceActual;

        public Form1()
        {
            InitializeComponent();
            cmboTipoProducto.SelectedIndex = 0; // Selecciona Producto General por defecto
            productos = new IProducto[10]; // Arreglo de productos con capacidad para 10
            indiceActual = 0;
        }

        private void cmboTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si el tipo de producto es Perecedero, mostrar el DateTimePicker para la fecha de caducidad
            if (cmboTipoProducto.SelectedItem.ToString() == "Perecedero")
            {
                dtpFechaCaducidad.Visible = true;
                lblCaducidad.Visible = true;
            }
            else
            {
                dtpFechaCaducidad.Visible = false;
                lblCaducidad.Visible = false;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreProducto = txtNombreProducto.Text;
                decimal precioBase = decimal.Parse(txtPrecioBase.Text);
                IProducto producto;

                // Dependiendo del tipo de producto, creamos una instancia de la clase adecuada
                if (cmboTipoProducto.SelectedItem.ToString() == "General")
                {
                    producto = new ProductoGeneral(nombreProducto, precioBase);
                }
                else if (cmboTipoProducto.SelectedItem.ToString() == "Electrónico")
                {
                    producto = new ProductoElectronico(nombreProducto, precioBase);
                }
                else if (cmboTipoProducto.SelectedItem.ToString() == "Descuento")
                {
                    producto = new ProductoConDescuento(nombreProducto, precioBase);
                }
                else // Producto Perecedero
                {
                    DateTime fechaCaducidad = dtpFechaCaducidad.Value;
                    producto = new ProductoPerecedero(nombreProducto, precioBase,
                        fechaCaducidad);
                }

                // Agregamos el producto al arreglo
                if (indiceActual < productos.Length)
                {
                    productos[indiceActual] = producto;
                    indiceActual++;
                    MessageBox.Show($"Producto {producto.Nombre} agregado.");
                }
                else
                {
                    MessageBox.Show("No se pueden agregar más productos.");
                }

                // Calculamos el precio final y lo mostramos en el label
                decimal precioFinal = producto.CalcularPrecioFinal();
                lblResultado.Text = $"Precio Final: {precioFinal:C}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            // Mostramos todos los productos del arreglo
            for (int i = 0; i < indiceActual; i++)
            {
                MessageBox.Show($"Producto: {productos[i].Nombre}, Precio Final: {productos[i].CalcularPrecioFinal():C}");
            }
        }
    }
}
