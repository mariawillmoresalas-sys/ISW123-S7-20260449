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



        // Devuelve cuántos huéspedes caben en cada tipo de habitación
        private int CapacidadMaxima(string tipo)
        {
            switch (tipo)
            {
                case "Estándar":
                    return 2;
                case "Superior":
                    return 3;
                case "Suite":
                    return 4;
                default:
                    return 0;   // tipo desconocido: no cabe nadie
            }
        }



        // Revisa los datos. Si algo está mal devuelve el mensaje; si todo está bien devuelve ""
        private string ValidarDatos(string cliente, string tipo, int noches, int huespedes)
        {
            int capacidad = CapacidadMaxima(tipo);

            bool clienteValido = !string.IsNullOrWhiteSpace(cliente);
            bool nochesValidas = noches >= 1 && noches <= 30;
            bool caben = huespedes >= 1 && huespedes <= capacidad;

            if (!clienteValido)
            {
                return "Escribe el nombre del cliente.";
            }
            else if (!nochesValidas)
            {
                return "Las noches deben estar entre 1 y 30.";
            }
            else if (!caben)
            {
                return $"Una habitación {tipo} admite de 1 a {capacidad} huéspedes.";
            }
            else
            {
                return "";
            }
        }



        // Recargo según el mes de entrada
        private decimal RecargoTemporada(DateTime entrada)
        {
            return entrada.Month switch
            {
                12 or 1 or 2 or 3 or 4 => 0.20m,   // temporada alta
                7 or 8 => 0.10m,                    // temporada media
                _ => 0m                             // temporada baja
            };
        }



        // Porcentaje de descuento según la cantidad de noches
        private decimal PorcentajeDescuento(int noches)
        {
            if (noches >= 14)
            {
                return 0.15m;
            }
            else if (noches >= 7)
            {
                return 0.10m;
            }
            else
            {
                return 0m;
            }
        }



        // Junta todas las reglas del negocio y devuelve el total a pagar
        private decimal CalcularTotal(string tipo, DateTime entrada, int noches)
        {
            decimal tarifa = tarifas[tipo];                 // busca en el diccionario
            decimal subtotal = tarifa * noches;

            subtotal = subtotal + subtotal * RecargoTemporada(entrada);
            subtotal = subtotal - subtotal * PorcentajeDescuento(noches);

            decimal itbis = subtotal * 0.18m;
            decimal servicio = subtotal * 0.10m;

            return Math.Round(subtotal + itbis + servicio, 2);
        }
    }
    
    
    
        
   
    
}
