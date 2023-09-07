namespace TestCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Instanciamos el servicio...
            ServicioAuto.WS_AutoSoap objWSAuto = new ServicioAuto.WS_AutoSoapClient(ServicioAuto.WS_AutoSoapClient.EndpointConfiguration.WS_AutoSoap);

            try
            {
                if (txtNumPlaca.Text.Trim() != String.Empty)
                {
                    lblPropietario.Text = objWSAuto.AutoPropietario(txtNumPlaca.Text.Trim());
                    lblMulta.Text = objWSAuto.CalcularMulta(txtNumPlaca.Text.Trim()).ToString("###,#0.00");
                }
                else 
                {
                    throw new Exception("Ingrese un numero de placa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);      
            }
        }
    }
}