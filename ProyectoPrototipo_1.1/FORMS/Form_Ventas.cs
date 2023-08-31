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


        private Connect connect;

        public int codigoProducto;
        public int cantidad;

        public Form_Ventas(Connect connect)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.connect = connect;
            LlenarDataGridViewFacturas(dataGridViewFactura);
            MostrarProductos(dataGridViewProductos);
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
                        DataGridViewButtonColumn buttonAgregar = new DataGridViewButtonColumn();
                        buttonAgregar.HeaderText = "Acción";
                        buttonAgregar.Text = "Agregar";
                        buttonAgregar.UseColumnTextForButtonValue = true;

                        // Agrega la columna de botones al final
                        dataGridView.Columns.Add(buttonAgregar);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la información de productos: " + ex.Message);
            }
        }

        // Llama a este método para mostrar la información de productos en un DataGridView
        // Pasar el DataGridView como argumento.


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

                    // Agrega las columnas de botones "Ver" y "Anular"
                    DataGridViewButtonColumn buttonVer = new DataGridViewButtonColumn();
                    buttonVer.HeaderText = "Ver";
                    buttonVer.Text = "Ver";
                    buttonVer.UseColumnTextForButtonValue = true;

                    DataGridViewButtonColumn buttonAnular = new DataGridViewButtonColumn();
                    buttonAnular.HeaderText = "Anular";
                    buttonAnular.Text = "Anular";
                    buttonAnular.UseColumnTextForButtonValue = true;

                    // Agrega las columnas de botones al DataGridView
                    dataGridView.Columns.Add(buttonVer);
                    dataGridView.Columns.Add(buttonAnular);

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
                            AND F.fechaEmision <= DATEADD(day, 1, @FechaFin);";

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
            //switch ()
            //{
            //    case 1:
            DateTime fechaInicio = dateTimeInicio.Value;
            DateTime fechaFin = dateTimeFin.Value;
            ConsultarFacturasPorFechas(fechaInicio, fechaFin, dataGridViewFactura);

            //        break;
            //    case 2:
            //     ConsultarFacturaPorNumeroFactura(int.Parse(txtBoxNumeroFacturaConsultar.Text), dataGridViewFactura);
            //        break;
            //    case 3:
            //    ConsultarFacturaPorCedulaCliente(txtBoxConsultarNumeroCedula.Text, dataGridViewFactura);
            //        break;
            //    default:
            //        break;
            //}
            //ConsultarFacturaPorNumeroFactura(int.Parse(txtBoxNumeroFacturaConsultar.Text), dataGridViewFactura);
        }

        private void Form_Ventas_Load(object sender, EventArgs e)
        {

        }


        private void button8_Click(object sender, EventArgs e)
        {
            this.codigoProducto = int.Parse(txtCodigo.Text);
            decimal precio = ObtenerPrecioProducto(codigoProducto);
            txtBPrecio.Text = precio.ToString();

            this.cantidad = int.Parse(txtCantidad.Text);

        }

        private decimal ObtenerPrecioProducto(int codigoProducto)
        {
            decimal precio = -1; // Valor predeterminado en caso de que el producto no se encuentre

            using (SqlConnection connection = new SqlConnection(con))
            {
                try
                {
                    connection.Open();

                    // Consulta SQL para obtener el precio del producto por su código
                    string sqlQuery = "SELECT precio_unitario FROM Producto WHERE codigo = @CodigoProducto";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@CodigoProducto", codigoProducto);

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            precio = Convert.ToDecimal(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener el precio del producto: {ex.Message}");
                }
            }

            return precio;
        }


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

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si el clic se hizo en una celda de botón "Agregar" (columna 3 en este caso)
            if (e.ColumnIndex == 4 && e.RowIndex >= 0) // Asegúrate de que el índice de fila sea válido
            {
                // Obtiene el valor de la celda en la fila actual (puedes usar esto para identificar el producto)
                string codigoProducto = dataGridViewProductos.Rows[e.RowIndex].Cells[1].Value.ToString();

                // Realiza la acción que desees, por ejemplo, agregar el producto al carrito
                // Puedes usar el código del producto (codigoProducto) para realizar la acción deseada.
                // Por ejemplo, puedes mostrar un mensaje, agregarlo a una lista, etc.
                MessageBox.Show("Producto agregado: " + codigoProducto);
            }
        }
    }
}

