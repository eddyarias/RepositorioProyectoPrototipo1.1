using ProyectoPrototipo_1._0.CLASES;
using ProyectoPrototipo_1._1.FORMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrototipo_1._0
{



    public partial class Form_Ventas : Form
    {


        string con = "Server=DESKTOP-OUHSBBV;Database=db_farmacia;Integrated Security=True;";

        //string con = "Server=DESKTOP-0BLRF7R\\MSSQLSERVER01;Database=db_farmacia;Integrated Security=True;";

        public Connect connect;


        public int codigoProducto;
        public int cantidad;

        public int tabSeleccionado;
        public int tabRegistrarFacturaSeleccionado;

        // Variable para controlar si el formulario está bloqueado
        private bool formularioBloqueado = false;

        public List<ProductoCarrito> carritoDeCompras = new List<ProductoCarrito>();

        public Form_Ventas(Connect connect)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.connect = connect;
            LlenarDataGridViewFacturas(dataGridViewFactura);
            MostrarProductos(dataGridViewProductos);
            this.txtBcedulaCliente.Enabled = false;
            TabSecuencialVentas.TabPages[1].Enabled = false;
            TabSecuencialVentas.TabPages[2].Enabled = false;
        }

        private void MostrarProductos(DataGridView dataGridView)
        {
            try
            {
                // Configura la cadena de conexión con autenticación de Windows
                string connectionString = con;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta SQL para obtener la información de los productos
                    string selectQuery = @"SELECT
                    codigo AS 'Código',
                    descripcion AS 'Descripción',
                    precio_unitario AS 'Precio'
                FROM
                    Producto;";

                    using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Agrega las columnas al DataGridView
                        dataGridView.DataSource = dataTable;

                        // Configura el modo de ajuste automático del ancho de las columnas
                        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                        // Agrega una columna de botones "Agregar" al final
                        if (!dataGridView.Columns.Contains("Agregar"))
                        {
                            DataGridViewButtonColumn buttonAgregar = new DataGridViewButtonColumn();
                            buttonAgregar.HeaderText = "Agregar";
                            buttonAgregar.Text = "Agregar";
                            buttonAgregar.UseColumnTextForButtonValue = true;

                            // Agrega la columna de botones al final
                            dataGridView.Columns.Add(buttonAgregar);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la información de productos: " + ex.Message);
            }
        }


        public void LlenarDataGridViewFacturas(DataGridView dataGridView)
        {
            try
            {
                // Configura la cadena de conexión con autenticación de Windows
                string connectionString = con;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Aquí puedes escribir tu consulta SQL para obtener los datos de las facturas
                    string selectQuery = "SELECT\r\n    F.idFactura AS '#Factura',\r\n    F.fechaEmision AS 'Fecha emisión',\r\n    F.cedula AS 'Cedula cliente',\r\n    C.nombres_c + ' ' + C.apellidos_c AS 'Nombres y Apellido cliente',\r\n    F.subtotal AS 'Subtotal',\r\n    F.iva AS 'I.V.A',\r\n    F.descuentoTotalDolares AS 'Descuento',\r\n    F.total AS 'Total',\r\n    F.formaPago AS 'Forma de pago',\r\n    F.estado AS 'Estado'\r\nFROM\r\n    Factura AS F\r\nINNER JOIN\r\n    Cliente AS C ON F.cedula = C.cedula;";

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);


                    // Asigna los datos al DataGridView
                    dataGridView.DataSource = dataTable;

                    // Configura el modo de ajuste automático del ancho de las columnas
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al llenar el DataGridView: " + ex.Message);
            }
        }

        private void ConsultarFacturaPorNumeroFactura(int numeroFactura, DataGridView dataGridView)
        {
            try
            {
                // Configura la cadena de conexión con autenticación de Windows
                string connectionString = con;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta SQL para obtener los detalles de la factura específica
                    string selectQuery = @"SELECT
                                            F.idFactura AS '#Factura',
                                            F.fechaEmision AS 'Fecha emisión',
                                            F.cedula AS 'Cédula cliente',
                                            CONCAT(C.nombres_c, ' ', C.apellidos_c) AS 'Nombres y Apellido cliente',
                                            F.subtotal AS 'Subtotal',
                                            F.iva AS 'I.V.A',
                                            F.descuentoTotalDolares AS 'Descuento',
                                            F.total AS 'Total',
                                            F.formaPago AS 'Forma de pago',
                                            F.estado AS 'Estado'
                                        FROM
                                            Factura AS F
                                        INNER JOIN
                                            Cliente AS C ON F.cedula = C.cedula
                                        WHERE
                                            F.idFactura = @NumeroFactura;";

                    using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@NumeroFactura", numeroFactura);

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Asigna los datos al DataGridView proporcionado
                        dataGridView.DataSource = dataTable;

                        // Configura el modo de ajuste automático del ancho de las columnas
                        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los detalles de la factura: " + ex.Message);
            }
        }

        private void ConsultarFacturaPorCedulaCliente(string numeroCedula, DataGridView dataGridView)
        {
            try
            {
                // Configura la cadena de conexión con autenticación de Windows
                string connectionString = con;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta SQL para obtener las facturas por número de cédula del cliente
                    string selectQuery = @"SELECT
                                    F.idFactura AS '#Factura',
                                    F.fechaEmision AS 'Fecha emisión',
                                    F.cedula AS 'Cédula cliente',
                                    CONCAT(C.nombres_c, ' ', C.apellidos_c) AS 'Nombres y Apellido cliente',
                                    F.subtotal AS 'Subtotal',
                                    F.iva AS 'I.V.A',
                                    F.descuentoTotalDolares AS 'Descuento',
                                    F.total AS 'Total',
                                    F.formaPago AS 'Forma de pago',
                                    F.estado AS 'Estado'
                                FROM
                                    Factura AS F
                                INNER JOIN
                                    Cliente AS C ON F.cedula = C.cedula
                                WHERE
                                    C.cedula = @NumeroCedula;";

                    using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@NumeroCedula", numeroCedula);

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Asigna los datos al DataGridView proporcionado
                        dataGridView.DataSource = dataTable;

                        // Configura el modo de ajuste automático del ancho de las columnas
                        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los detalles de la factura: " + ex.Message);
            }
        }

        private void ConsultarFacturasPorFechas(DateTime fechaInicio, DateTime fechaFin, DataGridView dataGridView)
        {
            try
            {
                // Configura la cadena de conexión con autenticación de Windows
                string connectionString = con;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {



                    connection.Open();

                    // Resta un día a la fecha de inicio
                    fechaInicio = fechaInicio.AddDays(-1);

                    // Consulta SQL para obtener las facturas dentro del intervalo de fechas
                    string selectQuery = @"SELECT
                            F.idFactura AS '#Factura',
                            F.fechaEmision AS 'Fecha emisión',
                            F.cedula AS 'Cédula cliente',
                            CONCAT(C.nombres_c, ' ', C.apellidos_c) AS 'Nombres y Apellido cliente',
                            F.subtotal AS 'Subtotal',
                            F.iva AS 'I.V.A',
                            F.descuentoTotalDolares AS 'Descuento',
                            F.total AS 'Total',
                            F.formaPago AS 'Forma de pago',
                            F.estado AS 'Estado'
                        FROM
                            Factura AS F
                        INNER JOIN
                            Cliente AS C ON F.cedula = C.cedula
                        WHERE
                            F.fechaEmision >= @FechaInicio
                            AND F.fechaEmision <= @FechaFin;";

                    using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@FechaFin", fechaFin);

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Asigna los datos al DataGridView proporcionado
                        dataGridView.DataSource = dataTable;

                        // Configura el modo de ajuste automático del ancho de las columnas
                        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los detalles de la factura: " + ex.Message);
            }
        }



        private void button7_Click(object sender, EventArgs e)
        {
            //switch (tabControlConsultar.SelectedIndex)
            //{
            //    case 1:
            DateTime fechaInicio = dateTimeInicio.Value;
            DateTime fechaFin = dateTimeFin.Value;
            ConsultarFacturasPorFechas(fechaInicio, fechaFin, dataGridViewFactura);

            //        break;
            //    case 2:
            //        ConsultarFacturaPorNumeroFactura(int.Parse(txtBoxNumeroFacturaConsultar.Text), dataGridViewFactura);
            //        break;
            //    case 3:
            //        ConsultarFacturaPorCedulaCliente(txtBoxConsultarNumeroCedula.Text, dataGridViewFactura);
            //        break;
            //    default:
            //        break;
            //}
        }

        private void Form_Ventas_Load(object sender, EventArgs e)
        {

        }


        private void bttAgregarProdCodBarr_Click(object sender, EventArgs e)
        {
            this.codigoProducto = int.Parse(txtCodigo.Text);
            ProductoInfo productoInfo = ObtenerPrecioYDescripcionProducto(codigoProducto);

            if (productoInfo != null)
            {
                // Crear una instancia del formulario de cuadro de diálogo personalizado
                AgregarProductoForm agregarProductoForm = new AgregarProductoForm();

                // Configurar las propiedades del formulario de acuerdo con los datos del producto
                agregarProductoForm.Descripcion = productoInfo.Descripcion;
                agregarProductoForm.Precio = productoInfo.Precio;

                // Mostrar el formulario de cuadro de diálogo personalizado
                DialogResult result = agregarProductoForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // El usuario hizo clic en "Aceptar" en el formulario de cuadro de diálogo
                    int cantidad = agregarProductoForm.CantidadIngresada;

                    // Crear un objeto ProductoCarrito para el producto seleccionado
                    ProductoCarrito productoSeleccionado = new ProductoCarrito(this.codigoProducto, productoInfo.Descripcion, productoInfo.Precio, cantidad);


                    // Agregar el producto al carrito
                    carritoDeCompras.Add(productoSeleccionado);

                    // Ahora puedes usar el carritoDeCompras para realizar un seguimiento de los productos seleccionados
                    ActualizarResumenCarrito();
                }
                else
                {
                    // El usuario hizo clic en "Cancelar" o cerró el cuadro de diálogo sin aceptar
                }
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }

        private void ActualizarResumenCarrito()
        {
            decimal total = 0;
            StringBuilder resumen = new StringBuilder();

            foreach (ProductoCarrito producto in carritoDeCompras)
            {
                decimal subtotal = producto.PrecioUnitario * producto.Cantidad;
                total += subtotal;

                // Agrega la información del producto al resumen en el formato deseado
                resumen.AppendLine($"{producto.CodigoProducto,-10} {producto.Descripcion,-45} {producto.PrecioUnitario,-20:C2} {producto.Cantidad,-15} {subtotal,-10:C2}");
            }

            // Actualiza el texto del Label con el resumen
            labelDetalle.Text = resumen.ToString();

            // Actualiza el total en el Label lbTotal
            lbTotal.Text = $"{total:C2}";
        }




        private ProductoInfo ObtenerPrecioYDescripcionProducto(int codigoProducto)
        {
            ProductoInfo productoInfo = null; // Valor predeterminado en caso de que el producto no se encuentre

            using (SqlConnection connection = new SqlConnection(con))
            {
                try
                {
                    connection.Open();

                    // Consulta SQL para obtener la descripción y el precio del producto por su código
                    string sqlQuery = "SELECT descripcion, precio_unitario FROM Producto WHERE codigo = @CodigoProducto";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@CodigoProducto", codigoProducto);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Se encontró el producto, crea un objeto ProductoInfo para almacenar los datos
                                productoInfo = new ProductoInfo
                                {
                                    Descripcion = reader["descripcion"].ToString(),
                                    Precio = Convert.ToDecimal(reader["precio_unitario"])
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener la información del producto: {ex.Message}");
                }
            }

            return productoInfo;
        }

        // Define una clase ProductoInfo para almacenar la descripción y el precio del producto




        private void button3_Click(object sender, EventArgs e)
        {

            //this.AvanzarPestana();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void imprimirCliente()
        {

        }

        public void imprimirDetalle()
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dataGridViewProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewProductos.Columns[e.ColumnIndex].Name == "Agregar")
            {
                MessageBox.Show("HOla");
            }
        }

        Class_Cliente clienteEncontrado;

        private void tabControlConsultar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  LlenarDataGridViewFacturas(dataGridViewFactura);
        }



        private void bttBuscarClienteBaseDatos_Click_1(object sender, EventArgs e)
        {
            
            string cedula = txtBcedulaCliente.Text.Trim();

            if (!string.IsNullOrEmpty(cedula))
            {
                // Define la consulta SQL
                string connectionString = con;
                string query = "SELECT * FROM Cliente WHERE cedula = @Cedula";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Cedula", cedula);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Verifica si se encontraron resultados
                            {
                                // Crea una instancia de Class_Cliente y asigna los valores desde el SqlDataReader
                                Class_Cliente clienteEncontrado = new Class_Cliente
                                {
                                    cedula = Convert.ToInt64(reader["cedula"]),
                                    tipo_persona = reader["tipo_persona"].ToString(),
                                    nombres_c = reader["nombres_c"].ToString(),
                                    apellidos_c = reader["apellidos_c"].ToString(),
                                    parroquia = reader["parroquia"].ToString(),
                                    direccion_c = reader["direccion_c"].ToString(),
                                    email_c = reader["email_c"].ToString(),
                                    telefono_c = reader["telefono_c"].ToString(),
                                    fecha_nac = Convert.ToDateTime(reader["fecha_nac"]),
                                    observaciones_c = reader["observaciones_c"].ToString()
                                };

                                // Puedes usar clienteEncontrado en tu aplicación
                                // Por ejemplo, mostrar los datos en controles TextBox
                                txtBnombresCliente.Text = clienteEncontrado.nombres_c;
                                txtBapellidosClientes.Text = clienteEncontrado.apellidos_c;
                                txtBtelefonoCliente.Text = clienteEncontrado.telefono_c;
                                txtBdireccionCliente.Text = clienteEncontrado.direccion_c;
                                txtBcorreoCliente.Text = clienteEncontrado.email_c;

                                // ...
                            }
                            else
                            {
                                // Cliente no encontrado en la base de datos. Pregunta si se desea registrar.
                                DialogResult result = MessageBox.Show("Cliente no encontrado en la base de datos. ¿Desea registrarlo?", "Cliente no encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                if (result == DialogResult.Yes)
                                {

                                    // Muestra el botón de "Desbloquear" para permitir al usuario desbloquear el formulario

                                    Form_AgregarCliente formAgregarCliente = new Form_AgregarCliente(connect, this);
                                    formAgregarCliente.ShowDialog();

                                    // Después de que se complete el registro del cliente, puedes obtener la cédula así:
                                    string cedulaRegistrada = formAgregarCliente.CedulaClienteRegistrada;

                                    // Haz algo con la cédula registrada, por ejemplo, mostrarla en un TextBox
                                    string cedulaRecientementeRegistrada = cedulaRegistrada;
                                    txtBcedulaCliente.Text = cedulaRegistrada;
                                    BuscarCliente(cedulaRecientementeRegistrada);

                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido.");
            }
        }

        private void BuscarCliente(string cedula)
        {
            if (!string.IsNullOrEmpty(cedula))
            {
                // Define la consulta SQL
                string connectionString = con;
                string query = "SELECT * FROM Cliente WHERE cedula = @Cedula";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Cedula", cedula);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Verifica si se encontraron resultados
                            {
                                // Crea una instancia de Class_Cliente y asigna los valores desde el SqlDataReader
                                Class_Cliente clienteEncontrado = new Class_Cliente
                                {
                                    cedula = Convert.ToInt64(reader["cedula"]),
                                    tipo_persona = reader["tipo_persona"].ToString(),
                                    nombres_c = reader["nombres_c"].ToString(),
                                    apellidos_c = reader["apellidos_c"].ToString(),
                                    parroquia = reader["parroquia"].ToString(),
                                    direccion_c = reader["direccion_c"].ToString(),
                                    email_c = reader["email_c"].ToString(),
                                    telefono_c = reader["telefono_c"].ToString(),
                                    fecha_nac = Convert.ToDateTime(reader["fecha_nac"]),
                                    observaciones_c = reader["observaciones_c"].ToString()
                                };

                                // Puedes usar clienteEncontrado en tu aplicación
                                // Por ejemplo, mostrar los datos en controles TextBox
                                txtBnombresCliente.Text = clienteEncontrado.nombres_c;
                                txtBapellidosClientes.Text = clienteEncontrado.apellidos_c;
                                txtBtelefonoCliente.Text = clienteEncontrado.telefono_c;
                                txtBdireccionCliente.Text = clienteEncontrado.direccion_c;
                                txtBcorreoCliente.Text = clienteEncontrado.email_c;

                                // ...
                            }
                            else
                            {
                                // Cliente no encontrado en la base de datos. Pregunta si se desea registrar.
                                DialogResult result = MessageBox.Show("Cliente no encontrado en la base de datos. ¿Desea registrarlo?", "Cliente no encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                if (result == DialogResult.Yes)
                                {

                                    // Muestra el formulario de registro del cliente
                                    Form_AgregarCliente formAgregarCliente = new Form_AgregarCliente(connect, this);

                                    formAgregarCliente.ShowDialog();
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido.");
            }
        }
        public class ProductoInfo
        {
            public string Descripcion { get; set; }
            public decimal Precio { get; set; }
        }
        public class ProductoCarrito
        {
            public int CodigoProducto { get; set; }
            public string Descripcion { get; set; }
            public decimal PrecioUnitario { get; set; }
            public int Cantidad { get; set; }

            public ProductoCarrito(int codigo, string descripcion, decimal precio, int cantidad)
            {
                CodigoProducto = codigo;
                Descripcion = descripcion;
                PrecioUnitario = precio;
                Cantidad = cantidad;
            }
        }

        private void bttContinuarSelecProd_Click(object sender, EventArgs e)
        {
            TabSecuencialVentas.TabPages[0].Enabled = false;
            TabSecuencialVentas.TabPages[1].Enabled = true;
        }



        private void button2_Click_1(object sender, EventArgs e)
        {


            String mensaje = "";
            Boolean esNecesarioMensaje = false;

            string formaPago;

            if (radButtEfectivo.Checked)
            {
                formaPago = radButtEfectivo.Text;
            }
            else
            {
                if (radButtTarjeDeb.Checked)
                {
                    formaPago = radButtTarjeDeb.Text;
                }
                else
                {
                    if (radButtTarjetaCredito.Checked)
                    {
                        formaPago = radButtTarjetaCredito.Text;
                    }
                    else
                    {
                        if (radButtTransferencia.Checked)
                        {
                            formaPago = radButtTransferencia.Text;
                        }
                        else
                        {
                            mensaje += "Seleccione una forma de pago.\n";
                            esNecesarioMensaje = true;
                        }
                    }
                }
            }
            Boolean consumidorFinal;

            if (radButtConsumidorfinal.Checked)
            {
                consumidorFinal = true;
            }
            else
            {
                if (radButtFacturaDatos.Checked)
                {
                    consumidorFinal = false;
                }
                else
                {
                    mensaje += "Seleccione consumidor final o factura con datos.\n";
                    esNecesarioMensaje = true;

                }
            }



            if (esNecesarioMensaje)
            {
                MessageBox.Show(mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void radButtConsumidorfinal_CheckedChanged(object sender, EventArgs e)
        {
            if (radButtConsumidorfinal.Checked)
            {
                txtBcedulaCliente.Enabled = false;
            }
            else
            {
                txtBcedulaCliente.Enabled = true;
            }
        }

        private void radButtFacturaDatos_CheckedChanged(object sender, EventArgs e)
        {
            if (radButtFacturaDatos.Checked)
            {
                txtBcedulaCliente.Enabled = true;
            }
            else
            {
                txtBcedulaCliente.Enabled = false;
            }
        }
    }
}

