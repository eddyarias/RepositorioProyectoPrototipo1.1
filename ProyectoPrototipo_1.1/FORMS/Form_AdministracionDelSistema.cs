using Microsoft.EntityFrameworkCore;
using ProyectoPrototipo_1._0.CLASES;
using ProyectoPrototipo_1._1.CLASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoPrototipo_1._1.FORMS
{
    public partial class Form_AdministracionDelSistema : Form
    {
        private FarmaciaDbContext dbContext;
        public Form_AdministracionDelSistema()
        {
            dbContext = new FarmaciaDbContext();
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form_Administracion_Load(object sender, EventArgs e)
        {
            dbContext.Usuario.Load();
            DGVUsuarios.DataSource = dbContext.Usuario.Local.ToBindingList();
            dbContext.SaveChanges();

            dbContext.Parametro.Load();
            DGVParametros.DataSource = dbContext.Parametro.Local.ToBindingList();
            dbContext.SaveChanges();
        }

        private void BResetearUsuario_Click(object sender, EventArgs e)
        {
            // Obtener el número de cédula desde el TextBox
            string cedula = TBResetearUsuario.Text;

            // Validar que el campo "cedula" no esté vacío
            if (string.IsNullOrEmpty(cedula))
            {
                MessageBox.Show("El campo 'Cédula' es obligatorio. Por favor, ingrese la información completa.");
                return;
            }

            // Realizar la consulta en la base de datos para obtener el usuario por su cédula
            var usuario = dbContext.Usuario.FirstOrDefault(u => u.cedula_identidad == cedula);

            if (usuario != null)
            {
                // Eliminar el usuario de la base de datos
                dbContext.Usuario.Remove(usuario);

                // Guardar los cambios en la base de datos
                dbContext.SaveChanges();

                // Refrescar los datos en el DataGridView de usuarios
                DGVUsuarios.DataSource = dbContext.Usuario.ToList();

                // Mostrar un mensaje de éxito
                MessageBox.Show("El usuario se ha eliminado correctamente.");
            }
            else
            {
                // Si no se encuentra el usuario, mostrar un mensaje de error
                MessageBox.Show("No se encontró ningún usuario con la cédula proporcionada.");
            }
        }

        private void BRegistrarUsuario_Click(object sender, EventArgs e)
        {
            string cedula = TBCedulaUsuario.Text;
            string username = TBNombreUsuario.Text;
            string password = TBPasswordUsuario.Text;
            string tipoUsuario = CBTipoUsuario.SelectedItem?.ToString();
            // Validar que los campos no estén vacíos (puedes agregar más validaciones según tus requisitos)
            if (string.IsNullOrEmpty(cedula) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(tipoUsuario))
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, ingrese la información completa.");
                return;
            }
            SHA512 hasher = new SHA512();
            string hashPass = hasher.HashPassword(password);
            // Crear una instancia de la entidad Usuario y asignar los valores
            var usuario = new Class_Usuario
            {
                cedula_identidad = cedula,
                username = username,
                pass = hashPass,
                tipo_usuario = tipoUsuario
            };

            // Agregar el nuevo usuario a la base de datos
            dbContext.Usuario.Add(usuario);

            // Guardar los cambios en la base de datos
            dbContext.SaveChanges();
            DGVUsuarios.DataSource = dbContext.Usuario.Local.ToBindingList();
            // Notificar al usuario que el registro se ha completado con éxito
            MessageBox.Show("El usuario se ha registrado correctamente.");
            ClearControlsUsuario();
        }
        private void ClearControlsUsuario()
        {
            TBCedulaUsuario.Clear();
            TBNombreUsuario.Clear();
            TBPasswordUsuario.Clear();
            CBTipoUsuario.Text = string.Empty;
            TBCedulaUConsultar.Clear();
            TBCedulaUActualizarPass.Clear();
            TBCedulaUActualizarTipo.Clear();
            TBPasswordActualizar.Clear();
            CBActualizarTipo.Text = string.Empty;
            TBResetearUsuario.Clear();
        }
        private void ClearControlsParametro()
        {
            TBRegistrarParametro.Clear();
            TBRegistrarValor.Clear();
            TBConsultarParametro.Clear();
            TBActualizarParametro.Clear();
            TBActualizarValor.Clear();
            TBEliminarParametro.Clear();
        }

        private void BRegistrarParametro_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los controles
            string parametro = TBRegistrarParametro.Text;
            decimal valor;

            // Validar que el campo "parametro" no esté vacío
            if (string.IsNullOrEmpty(parametro))
            {
                MessageBox.Show("El campo 'parametro' es obligatorio. Por favor, ingrese la información completa.");
                return;
            }

            // Validar y convertir el valor a decimal
            if (decimal.TryParse(TBRegistrarValor.Text, out valor))
            {

                // Crear una instancia de la entidad Parametro y asignar los valores
                var nuevoParametro = new Class_Parametro
                {
                    parametro = parametro,
                    valor = valor
                };
                // Agregar el nuevo parámetro a la base de datos
                dbContext.Parametro.Add(nuevoParametro);

                // Guardar los cambios en la base de datos
                dbContext.SaveChanges();

                // Notificar al usuario que el registro se ha completado con éxito
                MessageBox.Show("El parámetro se ha registrado correctamente.");

                // Recargar la lista de parámetros en tu DataGridView
                DGVParametros.DataSource = dbContext.Parametro.ToList();
                ClearControlsParametro();
            }
            else
            {
                MessageBox.Show("El campo 'valor' debe ser un número decimal válido.");
            }

        }

        private void BConsultarUsuario_Click(object sender, EventArgs e)
        {
            // Obtener el número de cédula desde el TextBox
            string cedula = TBCedulaUConsultar.Text;

            // Realizar la consulta en la base de datos
            var usuario = dbContext.Usuario.FirstOrDefault(u => u.cedula_identidad == cedula);

            if (usuario != null)
            {
                // Crear una lista con el usuario encontrado para asignarlo al DataGridView
                var usuariosEncontrados = new List<Class_Usuario> { usuario };

                // Asignar la lista al DataGridView
                DGVUsuarios.DataSource = usuariosEncontrados;
            }
            else
            {
                // Si no se encuentra el usuario, mostrar un mensaje
                MessageBox.Show("No se encontró ningún usuario con la cédula proporcionada.");
            }
        }

        private void BConsultarParametro_Click(object sender, EventArgs e)
        {
            string nombreParametro = TBConsultarParametro.Text;

            // Realizar la consulta en la base de datos
            var parametro = dbContext.Parametro.FirstOrDefault(p => p.parametro == nombreParametro);

            if (parametro != null)
            {
                // Crear una lista con el parámetro encontrado para asignarlo al DataGridView
                var parametrosEncontrados = new List<Class_Parametro> { parametro };

                // Asignar la lista al DataGridView
                DGVParametros.DataSource = parametrosEncontrados;
            }
            else
            {
                // Si no se encuentra el parámetro, mostrar un mensaje
                MessageBox.Show("No se encontró ningún parámetro con el nombre proporcionado.");
            }
        }

        private void BActualizarPass_Click(object sender, EventArgs e)
        {
            string cedula = TBCedulaUActualizarPass.Text;
            string nuevaContraseña = TBPasswordActualizar.Text;

            // Realizar la consulta en la base de datos para obtener el usuario por su número de cédula
            var usuario = dbContext.Usuario.FirstOrDefault(u => u.cedula_identidad == cedula);

            if (usuario != null)
            {
                // Actualizar la contraseña del usuario
                SHA512 hasher = new SHA512();
                string hashNuevaContraseña = hasher.HashPassword(nuevaContraseña);
                usuario.pass = hashNuevaContraseña;

                // Guardar los cambios en la base de datos
                dbContext.SaveChanges();

                // Refrescar los datos en el DataGridView
                DGVUsuarios.DataSource = dbContext.Usuario.ToList();

                // Mostrar un mensaje de éxito
                MessageBox.Show("La contraseña del usuario se ha actualizado correctamente.");
            }
            else
            {
                // Si no se encuentra el usuario, mostrar un mensaje de error
                MessageBox.Show("No se encontró ningún usuario con la cédula proporcionada.");
            }
        }

        private void BActualizarTipo_Click(object sender, EventArgs e)
        {
            string cedula = TBCedulaUActualizarTipo.Text;
            string nuevoTipoUsuario = CBActualizarTipo.SelectedItem?.ToString();

            // Realizar la consulta en la base de datos para obtener el usuario por su número de cédula
            var usuario = dbContext.Usuario.FirstOrDefault(u => u.cedula_identidad == cedula);

            if (usuario != null)
            {
                // Actualizar el tipo de usuario del usuario
                usuario.tipo_usuario = nuevoTipoUsuario;

                // Guardar los cambios en la base de datos
                dbContext.SaveChanges();

                // Refrescar los datos en el DataGridView
                DGVUsuarios.DataSource = dbContext.Usuario.ToList();

                // Mostrar un mensaje de éxito
                MessageBox.Show("El tipo de usuario del usuario se ha actualizado correctamente.");
            }
            else
            {
                // Si no se encuentra el usuario, mostrar un mensaje de error
                MessageBox.Show("No se encontró ningún usuario con la cédula proporcionada.");
            }
        }

        private void BActualizarParametro_Click(object sender, EventArgs e)
        {
            string nombreParametro = TBActualizarParametro.Text;
            decimal nuevoValor;

            // Validar que el campo "nombreParametro" no esté vacío
            if (string.IsNullOrEmpty(nombreParametro))
            {
                MessageBox.Show("El campo 'Nombre de Parámetro' es obligatorio. Por favor, ingrese la información completa.");
                return;
            }

            // Validar y convertir el nuevo valor a decimal
            if (decimal.TryParse(TBActualizarValor.Text, out nuevoValor))
            {
                // Realizar la consulta en la base de datos para obtener el parámetro por su nombre
                var parametro = dbContext.Parametro.FirstOrDefault(p => p.parametro == nombreParametro);

                if (parametro != null)
                {
                    // Actualizar el valor del parámetro
                    parametro.valor = nuevoValor;

                    // Guardar los cambios en la base de datos
                    dbContext.SaveChanges();

                    // Refrescar los datos en el DataGridView
                    DGVParametros.DataSource = dbContext.Parametro.ToList();

                    // Mostrar un mensaje de éxito
                    MessageBox.Show("El valor del parámetro se ha actualizado correctamente.");
                }
                else
                {
                    // Si no se encuentra el parámetro, mostrar un mensaje de error
                    MessageBox.Show("No se encontró ningún parámetro con el nombre proporcionado.");
                }
            }
            else
            {
                MessageBox.Show("El campo 'Nuevo Valor' debe ser un número decimal válido.");
            }
        }

        private void BEliminarParametro_Click(object sender, EventArgs e)
        {
            string nombreParametro = TBEliminarParametro.Text;

            // Validar que el campo "nombreParametro" no esté vacío
            if (string.IsNullOrEmpty(nombreParametro))
            {
                MessageBox.Show("El campo 'Nombre de Parámetro' es obligatorio. Por favor, ingrese la información completa.");
                return;
            }

            // Realizar la consulta en la base de datos para obtener el parámetro por su nombre
            var parametro = dbContext.Parametro.FirstOrDefault(p => p.parametro == nombreParametro);

            if (parametro != null)
            {
                // Eliminar el parámetro de la base de datos
                dbContext.Parametro.Remove(parametro);

                // Guardar los cambios en la base de datos
                dbContext.SaveChanges();

                // Refrescar los datos en el DataGridView
                DGVParametros.DataSource = dbContext.Parametro.ToList();

                // Mostrar un mensaje de éxito
                MessageBox.Show("El parámetro se ha eliminado correctamente.");
            }
            else
            {
                // Si no se encuentra el parámetro, mostrar un mensaje de error
                MessageBox.Show("No se encontró ningún parámetro con el nombre proporcionado.");
            }
        }

        private void TBCedulaUsuario_Leave(object sender, EventArgs e)
        {
            string cedula = TBCedulaUsuario.Text;
            if (!ValidateCedula(cedula))
            {
                LbValidarCedula.Text = "Cédula inválida";

                LbValidarCedula.ForeColor = Color.Red;
            }
            else
            {
                LbValidarCedula.Text = ""; // Clear the error message
            }
        }
        static bool ValidateCedula(string cedula)
        {
            // Check if the cedula has 10 digits
            if (cedula.Length != 10)
            {
                Console.WriteLine("Esta cédula tiene menos de 10 Dígitos");
                return false;
            }

            // Get the region digit, which is the first two digits
            string digitoRegion = cedula.Substring(0, 2);

            // Check if the region exists; Ecuador is divided into 24 regions
            if (!(int.TryParse(digitoRegion, out int region) && region >= 1 && region <= 24))
            {
                Console.WriteLine("Esta cédula no pertenece a ninguna región");
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

        private void PBVerPassword_Click(object sender, EventArgs e)
        {
            if (TBPasswordUsuario.PasswordChar == '*')
            {
                TBPasswordUsuario.PasswordChar = '\0'; // Mostrar contraseña
                PBVerPassword.Image = Image.FromFile("RECURSOS/REC_FORM_LOGIN/candadoAbierto.jpg");
            }
            else
            {
                TBPasswordUsuario.PasswordChar = '*'; // Ocultar contraseña
                PBVerPassword.Image = Image.FromFile("RECURSOS/REC_FORM_LOGIN/candadoCerrado.jpg");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (TBPasswordActualizar.PasswordChar == '*')
            {
                TBPasswordActualizar.PasswordChar = '\0'; // Mostrar contraseña
                PBVerPassActualizar.Image = Image.FromFile("RECURSOS/REC_FORM_LOGIN/candadoAbierto.jpg");
            }
            else
            {
                TBPasswordActualizar.PasswordChar = '*'; // Ocultar contraseña
                PBVerPassActualizar.Image = Image.FromFile("RECURSOS/REC_FORM_LOGIN/candadoCerrado.jpg");
            }
        }
    }
}
