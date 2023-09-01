using Microsoft.Data.SqlClient;
using ProyectoPrototipo_1._0;
using System;


namespace ProyectoPrototipo_1._1.FORMS
{
    public partial class Form_AgregarCliente : Form
    {
        public Connect connect;
        public string CedulaClienteRegistrada { get; private set; }



        public string con = "Server=DESKTOP-OUHSBBV;Database=db_farmacia;Integrated Security=True;";
        public Form_AgregarCliente(Connect connect)
        {
            InitializeComponent();
            this.connect = connect;
            // Configurar el DateTimePicker para mostrar solo el año
            dateTimePickerFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dateTimePickerFechaNacimiento.CustomFormat = "yyyy";
        }

        private void Form_AgregarCliente_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cedula = txtBCedula.Text;
            string tipo = comboBoxTipoPersona.Text;
            string nombres = txtBNombres.Text;
            string apellidos = txtBApellidos.Text;
            string direccion = txtBDireccion.Text;
            string correo = txtBEmail.Text;
            string celular = txtBCelular.Text;
            DateTime fechaNacimiento = dateTimePickerFechaNacimiento.Value;

            // Validate each field before attempting to save
            


            // Check if any validation failed
            if (!ValidateCedula(cedula)|| ValidateTipo(tipo)||ValidateNombres(nombres)||ValidateApellidos(apellidos)||ValidateDireccion(direccion)|| ValidateCorreo(correo)|| ValidateCelular(celular))
            {
                MessageBox.Show("Corrija los campos invalidos antes de guardar.");
  
                return;
            }

            GuardarCliente(cedula, tipo, nombres, apellidos, direccion, correo, celular, fechaNacimiento);
        }

        private void GuardarCliente(string cedula, string tipo, string nombres, string apellidos, string direccion, string correo, string celular, DateTime fechaNacimiento)
        {


            try
            {
                // Verifica que todos los campos requeridos estén completos antes de guardar
                if (!string.IsNullOrEmpty(cedula) && !string.IsNullOrEmpty(nombres) && !string.IsNullOrEmpty(apellidos))
                {

                    // Define la consulta SQL para insertar un nuevo cliente
                    string insertQuery = "INSERT INTO Cliente (cedula, tipo_persona, nombres_c, apellidos_c, direccion_c, email_c, telefono_c, fecha_nac) " +
                        "VALUES (@Cedula, @Tipo, @Nombres, @Apellidos, @Direccion, @Correo, @Celular, @FechaNacimiento)";

                    using (SqlConnection connection = new SqlConnection(con))
                    {
                        connection.Open();

                        using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                        {
                            // Asigna los valores de los parámetros a las variables en la consulta SQL
                            cmd.Parameters.AddWithValue("@Cedula", cedula);
                            cmd.Parameters.AddWithValue("@Tipo", tipo);
                            cmd.Parameters.AddWithValue("@Nombres", nombres);
                            cmd.Parameters.AddWithValue("@Apellidos", apellidos);
                            cmd.Parameters.AddWithValue("@Direccion", direccion);
                            cmd.Parameters.AddWithValue("@Correo", correo);
                            cmd.Parameters.AddWithValue("@Celular", celular);
                            cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);

                            // Ejecuta la consulta para insertar el nuevo cliente
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cliente guardado correctamente. Continuar con la venta.");

                                this.CedulaClienteRegistrada = cedula;


                                // Cierra el formulario actual (Form_AgregarCliente)
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo guardar el cliente.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, complete todos los campos requeridos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el cliente: " + ex.Message);
            }
        }


        private Form_Ventas formVentas;

        public Form_AgregarCliente(Connect connect, Form_Ventas formVentas)
        {
            InitializeComponent();
            this.connect = connect;
            this.formVentas = formVentas; // Asigna la referencia de Form_Ventas al campo privado formVentas
        }

        static bool ValidateCedula(string cedula)
        {
            // Check if the cedula has 10 digits
            if (cedula.Length != 10)
            {
                Console.WriteLine("Esta cedula tiene menos de 10 Digitos");
                return false;
            }

            // Get the region digit, which is the first two digits
            string digitoRegion = cedula.Substring(0, 2);

            // Check if the region exists; Ecuador is divided into 24 regions
            if (!(int.TryParse(digitoRegion, out int region) && region >= 1 && region <= 24))
            {
                Console.WriteLine("Esta cedula no pertenece a ninguna region");
                return false;
            }

            // Extract the last digit
            int ultimoDigito = int.Parse(cedula.Substring(9, 1));

            // Sum all the even digits
            int pares = int.Parse(cedula[1].ToString()) +
                        int.Parse(cedula[3].ToString()) +
                        int.Parse(cedula[5].ToString()) +
                        int.Parse(cedula[7].ToString());

            // Calculate the sum of odd digits after doubling them and subtracting 9 if greater than 9
            int numero1 = int.Parse(cedula[0].ToString()) * 2;
            if (numero1 > 9) numero1 -= 9;

            int numero3 = int.Parse(cedula[2].ToString()) * 2;
            if (numero3 > 9) numero3 -= 9;

            int numero5 = int.Parse(cedula[4].ToString()) * 2;
            if (numero5 > 9) numero5 -= 9;

            int numero7 = int.Parse(cedula[6].ToString()) * 2;
            if (numero7 > 9) numero7 -= 9;

            int numero9 = int.Parse(cedula[8].ToString()) * 2;
            if (numero9 > 9) numero9 -= 9;

            int impares = numero1 + numero3 + numero5 + numero7 + numero9;

            // Calculate the total sum
            int sumaTotal = pares + impares;

            // Extract the first digit
            int primerDigitoSuma = int.Parse(sumaTotal.ToString().Substring(0, 1));

            // Get the immediate ten
            int decena = (primerDigitoSuma + 1) * 10;

            // Calculate the validation digit
            int digitoValidador = decena - sumaTotal;

            // If the validation digit is 10, set it to 0
            if (digitoValidador == 10)
                digitoValidador = 0;

            // Validate that the validation digit matches the last digit of the cedula
            return digitoValidador == ultimoDigito;
        }

        private void txtBNombres_Leave(object sender, EventArgs e)
        {
            string nombres = txtBNombres.Text;

            // Use a regular expression to check if the input contains only letters and spaces,
            // and allows for multiple first names separated by spaces
            if (!System.Text.RegularExpressions.Regex.IsMatch(nombres, "^[A-Za-z ]+$"))
            {
                lblerrorNombres.Text = "Nombres inválidos";
                lblerrorNombres.ForeColor = Color.Red;
            }
            else
            {
                lblerrorNombres.Text = ""; // Clear the error message
            }
        }


        private void txtBCedula_Leave(object sender, EventArgs e)
        {
            string cedula = txtBCedula.Text;
            if (!ValidateCedula(cedula))
            {
                lblerrorCedula.Text = "Cedula inválida";

                lblerrorCedula.ForeColor = Color.Red;
            }
            else
            {
                lblerrorCedula.Text = ""; // Clear the error message
            }
        }

        private void comboBoxTipoPersona_Leave(object sender, EventArgs e)
        {
            // Validate Tipo Persona (ComboBox)

            if (string.IsNullOrEmpty(comboBoxTipoPersona.Text))
            {
                lblerrorTipo.Text = "Seleccione un tipo de persona";
                lblerrorTipo.ForeColor = Color.Red;
            }
            else
            {
                lblerrorTipo.Text = ""; // Clear the error message
            }

        }

        private void txtBApellidos_Leave(object sender, EventArgs e)
        {
            string apellidos = txtBApellidos.Text;

            // Use a regular expression to check if the input contains only letters and spaces,
            // and allows for multiple last names separated by spaces
            if (!System.Text.RegularExpressions.Regex.IsMatch(apellidos, "^[A-Za-z ]+$"))
            {
                lblerrorApellidos.Text = "Apellidos inválidos";
                lblerrorApellidos.ForeColor = Color.Red;
            }
            else
            {
                lblerrorApellidos.Text = ""; // Clear the error message
            }
        }


        private void txtBDireccion_Leave(object sender, EventArgs e)
        {
            string direccion = txtBDireccion.Text.Trim(); // Trim to remove leading/trailing spaces

            if (string.IsNullOrEmpty(direccion))
            {
                lblerrorDireccion.Text = "La dirección no puede estar vacía";
                lblerrorDireccion.ForeColor = Color.Red;
            }
            else
            {
                lblerrorDireccion.Text = ""; // Clear the error message
            }
        }

        private void txtBCelular_Leave(object sender, EventArgs e)
        {
            string celular = txtBCelular.Text;

            // Use a regular expression to check if the input contains only digits and starts with '0'
            if (!System.Text.RegularExpressions.Regex.IsMatch(celular, "^0[0-9]*$"))
            {
                lblerrorCelular.Text = "El número de celular debe comenzar con '0' y contener solo números";
                lblerrorCelular.ForeColor = Color.Red;
            }
            else
            {
                lblerrorCelular.Text = ""; // Clear the error message
            }
            
        }

        private void txtBEmail_Leave(object sender, EventArgs e)
        {
            string email = txtBEmail.Text;
            if (!new System.ComponentModel.DataAnnotations.EmailAddressAttribute().IsValid(email))
            {
                lblerrorEmail.Text = "Correo electrónico inválido";
                lblerrorEmail.ForeColor = Color.Red;
            }
            else
            {
                lblerrorEmail.Text = ""; // Clear the error message
            }
        }

        private Boolean ValidateTipo(string tipo)
        {
            if (string.IsNullOrEmpty(tipo))
            {
                lblerrorTipo.Text = "Seleccione un tipo de persona";
                lblerrorTipo.ForeColor = Color.Red;
                return true;
            }
            else
            {
                lblerrorTipo.Text = ""; // Clear the error message
                return false;
            }
        }

        private Boolean ValidateNombres(string nombres)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(nombres, "^[A-Za-z ]+$"))
            {
                lblerrorNombres.Text = "Nombres inválidos";
                lblerrorNombres.ForeColor = Color.Red;
                return true;
            }
            else
            {
                lblerrorNombres.Text = ""; // Clear the error message
                return false;
            }
        }

        private Boolean ValidateApellidos(string apellidos)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(apellidos, "^[A-Za-z ]+$"))
            {
                lblerrorApellidos.Text = "Apellidos inválidos";
                lblerrorApellidos.ForeColor = Color.Red;
                return true;
            }
            else
            {
                lblerrorApellidos.Text = ""; // Clear the error message
                return false;
            }
        }

        private Boolean ValidateDireccion(string direccion)
        {
            direccion = direccion.Trim();
            if (string.IsNullOrEmpty(direccion))
            {
                lblerrorDireccion.Text = "La dirección no puede estar vacía";
                lblerrorDireccion.ForeColor = Color.Red;
                return true;
            }
            else
            {
                lblerrorDireccion.Text = ""; // Clear the error message
                return false;
            }
        }

        private Boolean ValidateCorreo(string correo)
        {
            if (!new System.ComponentModel.DataAnnotations.EmailAddressAttribute().IsValid(correo))
            {
                lblerrorEmail.Text = "Correo electrónico inválido";
                lblerrorEmail.ForeColor = Color.Red;
                return true;
            }
            else
            {
                lblerrorEmail.Text = ""; // Clear the error message
                return false;
            }
        }

        private Boolean ValidateCelular(string celular)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(celular, "^0[0-9]*$"))
            {
                lblerrorCelular.Text = "El número de celular debe comenzar con '0' y contener solo números";
                lblerrorCelular.ForeColor = Color.Red;
                return true;
            }
            else
            {
                lblerrorCelular.Text = ""; // Clear the error message
                return false;

            }
        }

    }

}




