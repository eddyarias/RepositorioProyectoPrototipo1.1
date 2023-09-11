using Microsoft.EntityFrameworkCore;
using ProyectoPrototipo_1._0.CLASES;
using ProyectoPrototipo_1._1.FORMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProyectoPrototipo_1._0
{
    public partial class Form_Ventas : Form
    {
        //para el iva
        private FarmaciaDbContext dbContext;
        private void Form_Ventas_Load_1(object sender, EventArgs e)
        {
            dbContext = new FarmaciaDbContext();
            dbContext.Parametro.Load();
        }

        string con;
        public Connect connect;

        public long codigoProducto;
        public int cantidad;
        public int cantidadIC;//cantidad del producto ingresado

        public int tabSeleccionado;
        public int tabRegistrarFacturaSeleccionado;


        public List<ProductoCarrito> carritoDeCompras = new List<ProductoCarrito>();

        public decimal descuento;

        public decimal iva;
        public decimal subtotal1;
        public decimal total;


        public string cedulaCliente;


        public string formaPago;

        public class ProductoInfo
        {
            public string Descripcion { get; set; }
            public decimal Precio { get; set; }
            public int Cantidad { get; set; }
        }
        public class ProductoCarrito
        {
            public long CodigoProducto { get; set; }
            public string Descripcion { get; set; }
            public decimal PrecioUnitario { get; set; }
            public int Cantidad { get; set; }

            public ProductoCarrito(long codigo, string descripcion, decimal precio, int cantidad)
            {
                CodigoProducto = codigo;
                Descripcion = descripcion;
                PrecioUnitario = precio;
                Cantidad = cantidad;
            }
        }

        public string cedulaClienteEncontrado;

        public Form_Ventas(Connect connect)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.connect = connect;
            con = connect.stringconnect;
            LlenarDataGridViewFacturas(dataGridViewFactura);
            MostrarProductos(dataGridViewProductos);
            this.txtBcedulaCliente.Enabled = false;
            TabSecuencialVentas.TabPages[1].Enabled = false;
            TabSecuencialVentas.TabPages[2].Enabled = false;
            this.bttContinuarSelecProd.Enabled = false;
            // Declaración e inicialización de dataGridViewFactura

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
                    cantidad  AS 'Cantidad',
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



        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConsultarFacturaPorNumeroFactura(BigInteger numeroFactura, DataGridView dataGridView)
        {
            string numeroFac = numeroFactura.ToString();
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
                        cmd.Parameters.AddWithValue("@NumeroFactura", numeroFac);

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




        private void Form_Ventas_Load(object sender, EventArgs e)
        {

        }


        private void bttAgregarProdCodBarr_Click(object sender, EventArgs e)
        {
            long codigo;
            if (long.TryParse(txtCodigo.Text, out codigo))
            {
                this.codigoProducto = codigo;
            }
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
                while (agregarProductoForm.CantidadIngresada > productoInfo.Cantidad)
                {

                    MessageBox.Show($"No hay suficientes existencias disponibles. Stock {productoInfo.Cantidad}");
                    result = agregarProductoForm.ShowDialog();

                }
                if (result == DialogResult.OK)
                {

                    // El usuario hizo clic en "Aceptar" en el formulario de cuadro de diálogo AQUI SE AÑADIÓ
                    cantidadIC = agregarProductoForm.CantidadIngresada;
                    using (SqlConnection connection = new SqlConnection(con))
                    {
                        connection.Open();

                        //Paso 1: Consulta SQL para obtener la cantidad actual del producto
                        string consultaCantidadActual = "SELECT cantidad FROM Producto WHERE codigo = @codigo";
                        SqlCommand cmdConsulta = new SqlCommand(consultaCantidadActual, connection);
                        cmdConsulta.Parameters.AddWithValue("@codigo", codigoProducto);

                        int cantidadActual = (int)cmdConsulta.ExecuteScalar();


                        //Paso 2: Resta la cantidad ingresada a la cantidad actual
                        int nuevaCantidad = cantidadActual - cantidadIC;


                        //Paso 3: Actualiza la cantidad en la base de datos
                        string consultaActualizarCantidad = "UPDATE Producto SET cantidad = @nuevaCantidad WHERE codigo = @codigo";
                        SqlCommand cmdActualizar = new SqlCommand(consultaActualizarCantidad, connection);
                        cmdActualizar.Parameters.AddWithValue("@nuevaCantidad", nuevaCantidad);
                        cmdActualizar.Parameters.AddWithValue("@codigo", codigoProducto);

                        cmdActualizar.ExecuteNonQuery();
                        //Paso 4: Recarga los datos en el DataGridView
                        MostrarProductos(dataGridViewProductos);


                        // Crear un objeto ProductoCarrito para el producto seleccionado
                        ProductoCarrito productoSeleccionado = new ProductoCarrito(this.codigoProducto, productoInfo.Descripcion, productoInfo.Precio, cantidadIC);


                        // Agregar el producto al carrito
                        carritoDeCompras.Add(productoSeleccionado);
                        this.bttContinuarSelecProd.Enabled = true;

                        // Ahora puedes usar el carritoDeCompras para realizar un seguimiento de los productos seleccionados
                        ActualizarResumenCarrito();
                    }
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
            var parametroIVA = dbContext.Parametro.Local.FirstOrDefault(p => p.parametro == "IVA");
            if (parametroIVA != null)
            {
                StringBuilder resumen = new StringBuilder();
                subtotal1 = 0;
                foreach (ProductoCarrito producto in carritoDeCompras)
                {
                    decimal subtotal = producto.PrecioUnitario * producto.Cantidad;
                    subtotal1 += subtotal;

                    // Agrega la información del producto al resumen en el formato deseado
                    resumen.AppendLine($"{producto.CodigoProducto,-17} {producto.Descripcion,-43} {producto.PrecioUnitario,-25:C2} {producto.Cantidad,-15} {subtotal,-10:C2}");
                }


                iva = subtotal1 * Math.Round(parametroIVA.valor, 2);
                total = subtotal1 + iva - descuento;
                // Actualiza el texto del Label con el resumen
                labelDetalle.Text = resumen.ToString();

                label43.Text = (parametroIVA.valor * 100).ToString();


                // Actualiza el total en el Label lbTotal
                lbTotal.Text = $"{subtotal1:C2}";
                label9.Text = $"{iva:C2}";
                label13.Text = $"{descuento:C2}";
                label44.Text = $"{total:C2}";
            }
            else
            {
                label43.Text = "No se encontró el valor del IVA";
            }

        }




        private ProductoInfo ObtenerPrecioYDescripcionProducto(long codigoProducto)
        {
            ProductoInfo productoInfo = null; // Valor predeterminado en caso de que el producto no se encuentre

            using (SqlConnection connection = new SqlConnection(con))
            {
                try
                {
                    connection.Open();

                    // Consulta SQL para obtener la descripción y el precio del producto por su código
                    string sqlQuery = "SELECT descripcion, precio_unitario, cantidad FROM Producto WHERE codigo = @CodigoProducto";

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
                                    Precio = Convert.ToDecimal(reader["precio_unitario"]),
                                    Cantidad = Convert.ToInt32(reader["cantidad"])
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



        private void dataGridViewProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewProductos.Columns[e.ColumnIndex].Name == "Agregar")
            {

            }
        }

        Class_Cliente clienteEncontrado;

        private void tabControlConsultar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  LlenarDataGridViewFacturas(dataGridViewFactura);
        }




        private void bttBuscarClienteBaseDatos_Click_1(object sender, EventArgs e)
        {

            cedulaClienteEncontrado = txtBcedulaCliente.Text.Trim();

            if (!string.IsNullOrEmpty(cedulaClienteEncontrado))
            {
                // Define la consulta SQL
                string connectionString = con;
                string query = "SELECT * FROM Cliente WHERE cedula = @Cedula";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Cedula", cedulaClienteEncontrado);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Verifica si se encontraron resultados
                            {
                                // Crea una instancia de Class_Cliente y asigna los valores desde el SqlDataReader
                                Class_Cliente clienteEncontrado = new Class_Cliente
                                {
                                    cedula = Convert.ToInt64(reader["cedula"]),
                                    nombres_c = reader["nombres_c"].ToString(),
                                    apellidos_c = reader["apellidos_c"].ToString(),
                                    direccion_c = reader["direccion_c"].ToString(),
                                    email_c = reader["email_c"].ToString(),
                                    telefono_c = reader["telefono_c"].ToString(),
                                    fecha_nac = Convert.ToDateTime(reader["fecha_nac"]),
                                };

                                // Puedes usar clienteEncontrado en tu aplicación
                                // Por ejemplo, mostrar los datos en controles TextBox
                                txtBnombresCliente.Text = clienteEncontrado.nombres_c;
                                txtBapellidosClientes.Text = clienteEncontrado.apellidos_c;
                                txtBtelefonoCliente.Text = clienteEncontrado.telefono_c;
                                txtBdireccionCliente.Text = clienteEncontrado.direccion_c;
                                txtBcorreoCliente.Text = clienteEncontrado.email_c;

                                Continuar.Enabled = true;
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
                                    nombres_c = reader["nombres_c"].ToString(),
                                    apellidos_c = reader["apellidos_c"].ToString(),
                                    direccion_c = reader["direccion_c"].ToString(),
                                    email_c = reader["email_c"].ToString(),
                                    telefono_c = reader["telefono_c"].ToString(),
                                    fecha_nac = Convert.ToDateTime(reader["fecha_nac"]),
                                };

                                // Puedes usar clienteEncontrado en tu aplicación
                                // Por ejemplo, mostrar los datos en controles TextBox
                                txtBnombresCliente.Text = clienteEncontrado.nombres_c;
                                txtBapellidosClientes.Text = clienteEncontrado.apellidos_c;
                                txtBtelefonoCliente.Text = clienteEncontrado.telefono_c;
                                txtBdireccionCliente.Text = clienteEncontrado.direccion_c;
                                txtBcorreoCliente.Text = clienteEncontrado.email_c;

                                Continuar.Enabled = true;
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


        private void bttContinuarSelecProd_Click(object sender, EventArgs e)
        {

            // Mostrar un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Está seguro de terminar con la selección de productos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                // Si el usuario selecciona "Sí", habilitar la siguiente pestaña y cambiar a ella
                TabSecuencialVentas.TabPages[0].Enabled = false;
                TabSecuencialVentas.TabPages[1].Enabled = true;
                TabSecuencialVentas.SelectedTab = TabSecuencialVentas.TabPages[1];
                panel3.Focus();
                Continuar.Enabled = false;
            }
            // Si el usuario selecciona "No", no se realizará ninguna acción.
        }


        public BigInteger ObtenerIdFacturaMasAlto()
        {
            BigInteger idMasAlto = -1; // Valor predeterminado en caso de que no haya registros

            using (SqlConnection connection = new SqlConnection(con))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT MAX(CAST(idFactura AS BigINT)) FROM Factura";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            idMasAlto = Convert.ToInt64(result); // Convertir a BigInteger en lugar de int
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores, por ejemplo, puedes registrar el error o lanzar una excepción.
                    Console.WriteLine("Error al obtener el ID de factura más alto: " + ex.Message);
                }
            }

            return idMasAlto;
        }


        public int ObtenerIdListaProductosSeleccionadosMasAlto()
        {
            int idMasAlto = -1; // Valor predeterminado en caso de que no haya registros

            using (SqlConnection connection = new SqlConnection(con))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT MAX(idListaProducSelec) FROM ListaProductosSeleccionados";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            idMasAlto = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores, por ejemplo, puedes registrar el error o lanzar una excepción.
                    Console.WriteLine("Error al obtener el ID de ListaProductosSeleccionados más alto: " + ex.Message);
                }
            }

            return idMasAlto;
        }


        public String idFacturaManejable;
        private void button2_Click_1(object sender, EventArgs e)
        {
            string mensaje = "";
            bool esNecesarioMensaje = false;

            // Validar la forma de pago seleccionada
            if (radButtEfectivo.Checked)
                formaPago = radButtEfectivo.Text;
            else if (radButtTarjeDeb.Checked)
                formaPago = radButtTarjeDeb.Text;
            else if (radButtTarjetaCredito.Checked)
                formaPago = radButtTarjetaCredito.Text;
            else if (radButtTransferencia.Checked)
                formaPago = radButtTransferencia.Text;
            else
            {
                mensaje += "Seleccione una forma de pago.\n";
                esNecesarioMensaje = true;
            }

            // Validar si es consumidor final o factura con datos
            Boolean consumidorFinal = radButtConsumidorfinal.Checked;

            if (!consumidorFinal && !radButtFacturaDatos.Checked)
            {
                mensaje += "Seleccione consumidor final o factura con datos.\n";
                esNecesarioMensaje = true;
            }
            if (Consumidorfinal1)
            {

            }
            else
            {
                // Validar la cédula
                if (!ValidateCedula(txtBcedulaCliente.Text))
                {
                    mensaje += "Por favor, introduzca un número de cédula válido.\n";
                    esNecesarioMensaje = true;
                }
            }


            // Mostrar mensajes de error si es necesario
            if (esNecesarioMensaje)
            {
                MessageBox.Show(mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cedulaCliente = txtBcedulaCliente.Text;

                // Confirmar los datos de la factura
                DialogResult result = MessageBox.Show("¿Desea confirmar los datos de la factura?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    BigInteger idFactura = ObtenerIdFacturaMasAlto() + 1;
                    idFacturaManejable = "00" + idFactura;
                    int idListaProducSelec = ObtenerIdListaProductosSeleccionadosMasAlto() + 1;

                    using (SqlConnection connection = new SqlConnection(con))
                    {
                        try
                        {
                            connection.Open();



                            // Insertar una nueva factura en la tabla "Factura"
                            string insertFacturaQuery = "INSERT INTO Factura (idFactura, fechaEmision, cedula, subtotal, iva, descuentoTotalDolares, total, formaPago, estado) " +
                                                        "VALUES (@idFactura, @fechaEmision, @cedula,  @subtotal, @iva, @descuento, @total, @formaPago, 'Vigente');";

                            decimal subtotalConDescuento = subtotal1 - descuento;

                            using (SqlCommand cmd = new SqlCommand(insertFacturaQuery, connection))
                            {
                                cmd.Parameters.AddWithValue("@idFactura", idFacturaManejable); // Utilizamos el ID calculado
                                cmd.Parameters.AddWithValue("@fechaEmision", DateTime.Now); // Fecha actual
                                cmd.Parameters.AddWithValue("@cedula", cedulaCliente);
                                cmd.Parameters.AddWithValue("@subtotal", subtotalConDescuento);
                                cmd.Parameters.AddWithValue("@iva", iva);
                                cmd.Parameters.AddWithValue("@descuento", descuento);
                                cmd.Parameters.AddWithValue("@total", total);
                                cmd.Parameters.AddWithValue("@formaPago", formaPago);

                                cmd.ExecuteNonQuery();


                                // Insertar los productos del carrito en la tabla "ListaProductosSeleccionados"
                                foreach (ProductoCarrito producto in carritoDeCompras)
                                {
                                    string insertProductoQuery = "INSERT INTO ListaProductosSeleccionados (idListaProducSelec, idFactura, idProducto, cantidad, precio, subtotal, descuentoDolares) " +
                                                                "VALUES (@idListaProducSelec,@idFactura, @idProducto, @cantidad, @precio, @subtotal, @descuentoDolares);";

                                    using (SqlCommand productoCmd = new SqlCommand(insertProductoQuery, connection))
                                    {
                                        productoCmd.Parameters.AddWithValue("@idListaProducSelec", idListaProducSelec);
                                        productoCmd.Parameters.AddWithValue("@idFactura", idFacturaManejable);
                                        productoCmd.Parameters.AddWithValue("@idProducto", producto.CodigoProducto);
                                        productoCmd.Parameters.AddWithValue("@cantidad", producto.Cantidad);
                                        productoCmd.Parameters.AddWithValue("@precio", producto.PrecioUnitario);
                                        productoCmd.Parameters.AddWithValue("@subtotal", producto.PrecioUnitario * producto.Cantidad);
                                        productoCmd.Parameters.AddWithValue("@descuentoDolares", 0); // Puedes ajustar esto según tus necesidades

                                        productoCmd.ExecuteNonQuery();
                                    }
                                    idListaProducSelec++;
                                }
                            }

                            // Mostrar un mensaje de éxito
                            MessageBox.Show("La factura se ha guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ConsultarFactura(label18);
                            LBNumFactura.Text = idFacturaManejable.ToString();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al guardar la factura en la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }

                    TabSecuencialVentas.TabPages[1].Enabled = false;
                    TabSecuencialVentas.TabPages[2].Enabled = true;
                    TabSecuencialVentas.SelectedTab = TabSecuencialVentas.TabPages[2];
                }
            }
        }

        public void ConsultarFactura(Label labelFactura)
        {
            var parametroIVA = dbContext.Parametro.Local.FirstOrDefault(p => p.parametro == "IVA");//para el iva
            if (parametroIVA != null)
            {
                // Comprobar si hay productos en el carrito de compras
                if (carritoDeCompras.Count == 0)
                {
                    labelFactura.Text = "El carrito de compras está vacío.";
                    return;
                }

                // Calcular el subtotal1, descuento, iva y total en función de los productos en el carrito
                subtotal1 = carritoDeCompras.Sum(producto => producto.PrecioUnitario * producto.Cantidad);
                // Asumiendo que ya tienes valores válidos para descuento, iva y formaPago
                decimal descuentoDolares = descuento; // Ajusta esto según tu lógica
                iva = subtotal1 * parametroIVA.valor; // 12% de IVA, ajusta según tus necesidades
                total = subtotal1 + iva - descuentoDolares;

                // Construir el texto de la factura
                string facturaText = "Fecha emisión:       " + DateTime.Now.ToShortDateString() + "\n" +
                                     "Datos del cliente\n" +
                                    "Cédula:           " + cedulaCliente + "\n\n" +
                                     BuscarCliente2(cedulaCliente) + "\n" +
                                     "Forma de pago:            " + formaPago + "\n\n" +
                                     "Detalle\n" +
                                     "Código                     \tDescripción                                    \tPrecio               \tCantidad              \tSubtotal\n";

                foreach (ProductoCarrito producto in carritoDeCompras)
                {
                    facturaText += $" {producto.CodigoProducto,-10} {producto.Descripcion,-47} {producto.PrecioUnitario,-20:F2} {producto.Cantidad,-20} {(producto.PrecioUnitario * producto.Cantidad),-20:F2}\n";
                }

                facturaText += "\n                                                                                 Subtotal:             " + subtotal1.ToString("F2") + "\n" +
                               "                                                                                  IVA " + Convert.ToInt32(parametroIVA.valor * 100) + " %:             " + iva.ToString("F2") + "\n" +

                               "                                                                                 _____________________________\n" +
                               "                                                                                    Total:             " + total.ToString("F2");


                // Mostrar la factura en el control Label
                labelFactura.Text = facturaText;
            }
            else
            {
                label43.Text = "No se encontró el valor del IVA";
            }
        }

        private string BuscarCliente2(string cedula)
        {
            if (string.IsNullOrEmpty(cedula))
            {
                return "Cédula no proporcionada.";
            }

            string salida = "Cliente no encontrado.";

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
                                nombres_c = reader["nombres_c"].ToString(),
                                apellidos_c = reader["apellidos_c"].ToString(),
                                direccion_c = reader["direccion_c"].ToString(),
                                email_c = reader["email_c"].ToString(),
                                telefono_c = reader["telefono_c"].ToString(),
                                fecha_nac = Convert.ToDateTime(reader["fecha_nac"]),
                            };

                            // Puedes usar clienteEncontrado en tu aplicación
                            // Por ejemplo, mostrar los datos en controles TextBox
                            salida = "Nombre:             " + clienteEncontrado.nombres_c + " " + clienteEncontrado.apellidos_c + "\n";
                            salida += "Teléfono:          " + clienteEncontrado.telefono_c + "\n";
                            salida += "Email:             " + clienteEncontrado.email_c + "\n";
                            salida += "Dirección:         " + clienteEncontrado.direccion_c + "\n";
                        }
                    }
                }
            }

            return salida;
        }
        Boolean Consumidorfinal1;
        private void radButtConsumidorfinal_CheckedChanged(object sender, EventArgs e)
        {
            if (radButtConsumidorfinal.Checked)
            {
                txtBcedulaCliente.Enabled = false;
                BuscarCliente("1111111111");
                txtBcedulaCliente.Text = "1111111111";
                Consumidorfinal1 = true;
            }
            else
            {
                txtBcedulaCliente.Enabled = true;
                Consumidorfinal1 = false;
            }
        }

        private void radButtFacturaDatos_CheckedChanged(object sender, EventArgs e)
        {
            if (radButtFacturaDatos.Checked)
            {
                txtBcedulaCliente.Enabled = true;
                Consumidorfinal1 = false;
            }
            else
            {
                txtBcedulaCliente.Enabled = false;
                BuscarCliente("1111111111");
                txtBcedulaCliente.Text = "1111111111";
                Consumidorfinal1 = true;

            }
        }

        private bool cedulaEsValida = false;

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

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bttConsultarFactura_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dateTimeInicio.Value;
            DateTime fechaFin = dateTimeFin.Value;

            ConsultarFacturasPorFechas(fechaInicio, fechaFin, dataGridViewFactura);
            this.txtBoxConsultarNumeroCedula.Text = "";
            this.txtBoxNumeroFacturaConsultar.Text = "";
        }



        private void button2_Click(object sender, EventArgs e)
        {
            string numeroFactura = txtBoxNumeroFacturaConsultar.Text;

            // Verifica que la cadena no esté vacía
            if (!string.IsNullOrEmpty(numeroFactura))
            {
                // Realiza la consulta SQL utilizando la cadena "numeroFactura"
                string consultaSQL = "SELECT * FROM Factura WHERE idFactura = @numeroFactura";

                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(consultaSQL, connection))
                    {
                        // Agrega el parámetro para "numeroFactura"
                        cmd.Parameters.AddWithValue("@numeroFactura", numeroFactura);

                        // Crea un adaptador de datos y llena un DataTable con los resultados
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Asigna el DataTable al DataGridView
                        dataGridViewFactura.DataSource = dataTable;

                        // Limpia el contenido del TextBox
                        txtBoxNumeroFacturaConsultar.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de factura válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

            // La cédula es válida, aquí puedes realizar la consulta con "txtBoxConsultarNumeroCedula.Text"
            ConsultarFacturaPorCedulaCliente(txtBoxConsultarNumeroCedula.Text, dataGridViewFactura);
            this.txtBoxNumeroFacturaConsultar.Text = "";
            dateTimeFin.Value = DateTime.Now;
            dateTimeInicio.Value = DateTime.Now;


        }


        private void dateTimeInicio_Leave(object sender, EventArgs e)
        {
            DateTime fechaInicio = dateTimeInicio.Value;
            DateTime fechaFin = dateTimeFin.Value;
            if (fechaInicio > fechaFin)
            {
                label17.Text = "La fecha de inicio debe ser anterior a la fecha de fin.";
                label17.ForeColor = Color.Red;
            }
            else
            {
                label17.Text = ""; // Borrar el mensaje de error 
            }
        }

        private void dateTimeFin_Leave(object sender, EventArgs e)
        {
            DateTime fechaInicio = dateTimeInicio.Value;
            DateTime fechaFin = dateTimeFin.Value;
            if (fechaInicio > fechaFin)
            {
                label17.Text = "La fecha de inicio debe ser anterior a la fecha de fin.";
                label17.ForeColor = Color.Red;
            }
            else
            {
                label17.Text = ""; // Borrar el mensaje de error 
            }
        }

        private void bttAnular_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();

                foreach (ProductoCarrito productoCarrito in carritoDeCompras)
                {
                    // Obtener el código y la cantidad del producto en el carrito
                    long codigoProducto = productoCarrito.CodigoProducto;
                    int cantidadIC = productoCarrito.Cantidad;

                    // Paso 1: Consulta SQL para obtener la cantidad actual del producto
                    string consultaCantidadActual = "SELECT cantidad FROM Producto WHERE codigo = @codigo";
                    SqlCommand cmdConsulta = new SqlCommand(consultaCantidadActual, connection);
                    cmdConsulta.Parameters.AddWithValue("@codigo", codigoProducto);

                    int cantidadActual = (int)cmdConsulta.ExecuteScalar();

                    // Paso 2: Resta la cantidad ingresada a la cantidad actual
                    int nuevaCantidad = cantidadActual + cantidadIC;

                    // Paso 3: Actualiza la cantidad en la base de datos
                    string consultaActualizarCantidad = "UPDATE Producto SET cantidad = @nuevaCantidad WHERE codigo = @codigo";
                    SqlCommand cmdActualizar = new SqlCommand(consultaActualizarCantidad, connection);
                    cmdActualizar.Parameters.AddWithValue("@nuevaCantidad", nuevaCantidad);
                    cmdActualizar.Parameters.AddWithValue("@codigo", codigoProducto);

                    cmdActualizar.ExecuteNonQuery();
                }

                // Paso 4: Recarga los datos en el DataGridView
                MostrarProductos(dataGridViewProductos);
            }
            DialogResult result = MessageBox.Show($"¿Estás seguro de que deseas anular la factura con ID {idFacturaManejable}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario confirma la acción, procede a anular la factura
            if (result == DialogResult.Yes)
            {
                // Llama a un método para anular la factura y pasa el ID de la factura como argumento
                AnularFactura(idFacturaManejable);
            }
        }


        public void AnularFactura(String idFactura)
        {
            // Cadena de conexión a la base de datos (reemplaza con tu propia cadena de conexión)
            string connectionString = con;

            // Query SQL para actualizar el estado de la factura a 'Anulada'
            string updateQuery = "UPDATE Factura SET estado = 'Anulada' WHERE idFactura = @idFactura";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        // Asigna el valor del parámetro
                        cmd.Parameters.AddWithValue("@idFactura", idFactura);

                        // Ejecuta la consulta SQL para actualizar el estado
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Factura con ID {idFactura} ha sido anulada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"No se encontró una factura con ID {idFactura}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al anular la factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bttNuevaVenta_Click(object sender, EventArgs e)
        {
            carritoDeCompras = new List<ProductoCarrito>();
            descuento = 0;
            iva = 0;
            subtotal1 = 0;
            total = 0;

            TabSecuencialVentas.SelectedTab = tabPage1;
            this.txtBcedulaCliente.Enabled = false;
            TabSecuencialVentas.TabPages[0].Enabled = true;
            TabSecuencialVentas.TabPages[2].Enabled = false;
            this.bttContinuarSelecProd.Enabled = false;

            txtBcedulaCliente.Text = string.Empty;
            txtBnombresCliente.Text = string.Empty;
            txtBapellidosClientes.Text = string.Empty;
            txtBtelefonoCliente.Text = string.Empty;
            txtBdireccionCliente.Text = string.Empty;
            txtBcorreoCliente.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            label18.Text = string.Empty;
            LBNumFactura.Text = string.Empty;
            labelDetalle.Text = string.Empty;
            label9.Text = string.Empty;
            label13.Text = string.Empty;
            label44.Text = string.Empty;
            lbTotal.Text = string.Empty;

            radButtFacturaDatos.Checked = false;
            radButtConsumidorfinal.Checked = false;
            radButtTransferencia.Checked = false;
            radButtTarjeDeb.Checked = false;
            radButtTarjetaCredito.Checked = false;
            radButtEfectivo.Checked = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Obtén la fecha de cierre de algún lugar, por ejemplo, un DateTimePicker
            DateTime diacierre = diaCierre.Value.Date;

            string fecha = diacierre.ToString("yyyy-MM-dd");

            //MessageBox.Show(fecha);

            // Realiza una consulta SQL para obtener la suma de los totales de las facturas vigentes
            decimal ingresos = ObtenerTotalIngresos(fecha);

            //MessageBox.Show(ingresos + "");
            // Establece el saldo inicial como $10
            decimal saldoInicial = 10.0m;

            // El egreso es 0 según tus requerimientos
            decimal egresos = 0.0m;

            // Calcula el saldo final
            decimal saldoFinal = ingresos + saldoInicial - egresos;

            // Actualiza las etiquetas en el formulario
            lblIngresos.Text = ingresos.ToString("C"); // "C" formatea como moneda
            lblEgresos.Text = egresos.ToString("C");
            lblSaldoInicial.Text = saldoInicial.ToString("C");
            lblSaldoFinal.Text = saldoFinal.ToString("C");

            // Llena la primera columna del DataGridViewCierreCaja
            LlenarDataGridViewCierreCaja(fecha);
        }

        private decimal ObtenerTotalIngresos(string diacierre)
        {
            decimal totalIngresos = 0.0m;

            string query = "SELECT SUM(total) FROM Factura WHERE fechaEmision = @diacierre AND estado = 'Vigente';";

            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@diacierre", diacierre);

                    object resultado = cmd.ExecuteScalar();

                    MessageBox.Show(resultado.ToString());

                    if (resultado != null && resultado != DBNull.Value)
                    {
                        totalIngresos = Convert.ToDecimal(resultado);
                    }
                }
            }

            return totalIngresos;
        }


        private void LlenarDataGridViewCierreCaja(string diacierre)
        {
            // Limpia el DataGridView antes de llenarlo
            dataGridViewCierreCaja.Rows.Clear();

            // Realiza una consulta SQL para obtener los detalles de las facturas vigentes
            // Reemplaza esto con tu código real de consulta a la base de datos
            // Supongamos que tienes una conexión de base de datos llamada "connection"

            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();

                // Define tu consulta SQL aquí
                string consultaSQL = "SELECT idFactura, total, formaPago FROM Factura WHERE fechaEmision = @diacierre AND estado = 'Vigente';";

                using (SqlCommand cmd = new SqlCommand(consultaSQL, connection))
                {
                    cmd.Parameters.AddWithValue("@diacierre", diacierre);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string idFactura = reader.GetString(0); // Si idFactura es de tipo char
                            decimal totalFactura = reader.GetDecimal(1);
                            string formaPago = reader.GetString(2);

                            string descripcion = $"Factura #{idFactura}, valor: {totalFactura:C}, recibido por {formaPago}";

                            // Agrega una fila al DataGridView con la descripción
                            dataGridViewCierreCaja.Rows.Add(descripcion);
                        }
                    }
                }
            }
        }

        private void dataGridViewFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridViewFactura_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                // Obtén el valor de la celda en la primera columna de la fila actual
                string numeroFactura = dataGridViewFactura[0, e.RowIndex].Value.ToString();

                if (numeroFactura != null)
                {

                    // Muestra un cuadro de diálogo de confirmación antes de anular la factura
                    DialogResult confirmResult = MessageBox.Show($"¿Seguro que deseas anular la factura #{numeroFactura}?", "Confirmar Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmResult == DialogResult.Yes)
                    {
                        // Llama a tu función de anulación de factura pasando el número de factura
                        AnularFactura(numeroFactura.ToString());

                        // Refresca el DataGridView para actualizar los datos
                        LlenarDataGridViewFacturas(dataGridViewFactura);
                    }
                }



            }
        }

        private void dataGridViewProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                // Obtén el valor de la celda en la primera columna de la fila actual
                long codigo = long.Parse(dataGridViewProductos[0, e.RowIndex].Value.ToString());

                ProductoInfo productoInfo = ObtenerPrecioYDescripcionProducto(codigo);

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
                        this.bttContinuarSelecProd.Enabled = true;

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
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es un número o la tecla BackSpace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Si no es un número ni BackSpace, cancela la entrada
                e.Handled = true;

                // Configura el color de fuente del Label en rojo
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Solo se aceptan números";
            }
            else
            {
                // Si la entrada es válida, borra el mensaje y restaura el color de fuente
                lblMensaje.Text = "";
                lblMensaje.ForeColor = Color.Black; // O el color que desees para el texto regular
            }
        }

        private void txtBcedulaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es un número o la tecla BackSpace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Si no es un número ni BackSpace, cancela la entrada
                e.Handled = true;

                // Configura el color de fuente del Label en rojo
                lblMensaje2.ForeColor = Color.Red;
                lblMensaje2.Text = "Solo se aceptan números";
            }
            else
            {
                // Si la entrada es válida, borra el mensaje y restaura el color de fuente
                lblMensaje2.Text = "";
                lblMensaje2.ForeColor = Color.Black; // O el color que desees para el texto regular
            }
        }
    }
}

