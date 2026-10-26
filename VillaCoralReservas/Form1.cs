namespace VillaCoralReservas
{
    public partial class Form1 : Form
    {


        // ---- Datos del formulario (campos) ----
        private const int MiNumero = 49;   // ← los dos últimos dígitos de TU matrícula

        // Diccionario: tipo de habitación → tarifa por noche
        private readonly Dictionary<string, decimal> tarifas = new Dictionary<string, decimal>();

        // Lista: aquí se guardan todas las reservas que el usuario agregue
        private readonly List<Reserva> reservas = new List<Reserva>();

        // Generador de números al azar para los códigos de reserva
        private readonly Random azar = new Random();


        public Form1()
        {
            InitializeComponent();

            // 1) Llenar el diccionario de tarifas
            decimal tarifaEstandar = 70 + MiNumero;
            tarifas.Add("Estándar", tarifaEstandar);
            tarifas.Add("Superior", tarifaEstandar + 40);
            tarifas.Add("Suite", tarifaEstandar * 2);

            // 2) Llenar el ComboBox recorriendo un arreglo con foreach
            string[] tipos = { "Estándar", "Superior", "Suite" };
            foreach (string tipo in tipos)
            {
                cmbTipoDeHabitacion.Items.Add(tipo);
            }
            cmbTipoDeHabitacion.SelectedIndex = 0;   // que empiece seleccionado "Estándar"

            // 3) Mostrar las tarifas recorriendo el diccionario
            lblTarifas.Text = "Tarifas por noche:\n";
            foreach (KeyValuePair<string, decimal> par in tarifas)
            {
                lblTarifas.Text += $"{par.Key}: US$ {par.Value:N2}\n";
            }




        }


         
    }
    
    
    
        
   
    
}
