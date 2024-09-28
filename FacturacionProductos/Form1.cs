namespace FacturacionProductos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmboTipoProducto.SelectedIndex = 0;
        }

        private void cmboTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboTipoProducto.SelectedItem.ToString() == "Perecedero")
            {
                dtpFechaCaducidad.Visible = true;
                lblCaducidad.Visible = true;
            }
            else
            {
                dtpFechaCaducidad.Visible=false;
                lblCaducidad.Visible = false;
            }
        }
    }
}
