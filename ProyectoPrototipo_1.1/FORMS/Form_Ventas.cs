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

        private void MostrarDetallesFactura(int numeroFactura, DataGridView dataGridView)
        {
            try
            {
                // Configura la cadena de conexión con autenticación de Windows
                string connectionString = con;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta SQL para obtener los detalles de la factura específica
                    string selectQuery = "SELECT\r\n    LP.idListaProducSelec AS 'ID',\r\n    P.codigo AS 'Código de Producto',\r\n    P.descripcion AS 'Descripción',\r\n    LP.cantidad AS 'Cantidad',\r\n    LP.precio AS 'Precio',\r\n    LP.subtotal AS 'Subtotal',\r\n    LP.descuentoDolares AS 'Descuento'\r\nFROM\r\n    ListaProductosSeleccionados AS LP\r\nINNER JOIN\r\n    Producto AS P ON LP.idProducto = P.codigo\r\nWHERE\r\n    LP.idFactura = @NumeroFactura;";

                    using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@NumeroFactura", numeroFactura);

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
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

        private void AvanzarPestana()
        {

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

        private void button7_Click(object sender, EventArgs e)
        {
            MostrarDetallesFactura(int.Parse(txtBoxNumeroFacturaConsultar.Text), dataGridViewFactura);
        }
    }
}

