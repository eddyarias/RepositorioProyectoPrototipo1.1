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

        private Connect connect;

        public Form_Ventas(Connect connect)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.connect = connect;
        }

        public void LlenarDataGridViewFacturas(DataGridView dataGridView)
        {
            try
            {
                using (SqlConnection connection = connect.RealizarConexion())
                {
                    if (connection == null)
                    {
                        Console.WriteLine("No se pudo establecer la conexión.");
                        return;
                    }

                    // Aquí puedes escribir tu consulta SQL para obtener los datos de las facturas
                    string selectQuery = "SELECT * FROM Factura";

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Asigna los datos al DataGridView
                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al llenar el DataGridView: " + ex.Message);
            }
        }

        private void Form_Ventas_Load(object sender, EventArgs e)
        {

            LlenarDataGridViewFacturas(dataGridViewProductos);

            //this.TabSecuencialVentas.TabPages[1].Enabled = false;
            //this.TabSecuencialVentas.TabPages[2].Enabled = false;
            //this.TabSecuencialVentas.TabPages[3].Enabled = false;


            //dataGridView1.Rows.Add("1", "Pasta dental       .", 3.99);
            //dataGridView1.Rows.Add("2", "Paños húmedos      .", 2.99);
            //dataGridView1.Rows.Add("3", "Analgesia en crema .", 4.99);
            //dataGridView1.Rows.Add("4", "Antiséptico bucal  .", 5.99);
            //dataGridView1.Rows.Add("5", "Protector solar    .", 9.99);
            //dataGridView1.Rows.Add("6", "Jarabe para la tos .", 6.99);
            //dataGridView1.Rows.Add("7", "Vendas adhesivas   .", 2.49);
            //dataGridView1.Rows.Add("8", "Antidiarreico      .", 7.99);
            //dataGridView1.Rows.Add("9", "Repelente insecto  .", 8.99);
            //dataGridView1.Rows.Add("10", "Jabón antibacterial.", 1.99);
            //dataGridView1.Rows.Add("11", "Suplemento         .", 1.99);
            //dataGridView1.Rows.Add("12", "Descongestionante  .", 4.99);
            //dataGridView1.Rows.Add("13", "Gotas para los ojos.", 6.99);
            //dataGridView1.Rows.Add("14", "Analgésico en gel  .", 5.99);
            //dataGridView1.Rows.Add("15", "Antihistamínico    .", 3.99);
            //dataGridView1.Rows.Add("16", "Desodorante        .", 7.99);



            //dataGridView1.Columns[0].Width = 4;

            //// Establecer el ancho de la columna "Producto"
            //dataGridView1.Columns["Codigo"].Width = 60;
            //dataGridView1.Columns["Producto"].Width = 226;
            //dataGridView1.Columns["Precio"].Width = 90;
            //dataGridView1.Columns["Cantidad"].Width = 90;
            //dataGridView1.Columns["Cantidad"].ReadOnly = false;
        }

        // Método para avanzar a la siguiente pestaña
        private void AvanzarPestana()
        {
            // Deshabilitar la pestaña actual
            //TabSecuencialVentas.TabPages[indicePestanaActual].Enabled = false;

            //// Incrementar el índice de la pestaña actual
            //indicePestanaActual++;

            //// Habilitar la siguiente pestaña
            //if (indicePestanaActual < TabSecuencialVentas.TabCount)
            //{
            //    TabSecuencialVentas.TabPages[indicePestanaActual].Enabled = true;
            //    TabSecuencialVentas.SelectedIndex = indicePestanaActual;
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //this.AvanzarPestana();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (txtBcedulaCliente.Text != string.Empty && txtBnombresCliente.Text != string.Empty && txtBapellidosClientes.Text != string.Empty &&
            //txtBtelefonoCliente.Text != string.Empty && txtBdireccionCliente.Text != string.Empty && txtBcorreoCliente.Text != string.Empty)
            //{
            //    cedulaCLiente = int.Parse(txtBcedulaCliente.Text);
            //    nombreCliente = txtBnombresCliente.Text;
            //    apellidoCliente = txtBapellidosClientes.Text;
            //    direccionCliente = txtBdireccionCliente.Text;
            //    telefonoCliente = txtBtelefonoCliente.Text;
            //    correoCliente = txtBcorreoCliente.Text;

            //    this.AvanzarPestana();
            //}
            //else
            //{
            //    MessageBox.Show("Ingrese todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (checkedListBox1.CheckedItems.Count > 0 && checkedListBox2.CheckedItems.Count > 0 && comboBox1.SelectedItem != null)
            //{
            //    if (checkedListBox2.SelectedItem.ToString() == "SI")
            //    {
            //        if (comboBox2.SelectedItem != null)
            //        {
            //            this.AvanzarPestana();
            //            descripcionAdicionalCobro = txtBDescripcionAdicional.Text;
            //            this.imprimirCliente();
            //            this.imprimirDetalle();
            //        }
            //        else
            //        {
            //            // Muestra un mensaje de error
            //            MessageBox.Show("Debes seleccionar al menos una opción en el descuento.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //    else
            //    {
            //        this.AvanzarPestana();
            //        descripcionAdicionalCobro = txtBDescripcionAdicional.Text;
            //        this.imprimirCliente();
            //        this.imprimirDetalle();
            //    }
            //}
            //else
            //{
            //    // Muestra un mensaje de error
            //    MessageBox.Show("Debes seleccionar todos los campos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //seRealizaronEdiciones = true;

            //int rowIndex = e.RowIndex;
            //int columnIndex = e.ColumnIndex;

            //DataGridViewRow row = dataGridView1.Rows[rowIndex];

            //DataGridViewCell cantCell = row.Cells["Cantidad"];
            //DataGridViewCell precioCell = row.Cells["Precio"];
            //DataGridViewCell productoCell = row.Cells["Producto"];

            //if (cantCell != null && cantCell.Value != null &&
            //    precioCell != null && precioCell.Value != null &&
            //    productoCell != null && productoCell.Value != null)
            //{
            //    if (!arregloProductos.Contains(productoCell.Value.ToString()))
            //    {
            //        if (int.TryParse(cantCell.Value.ToString(), out int cantidad) && float.TryParse(precioCell.Value.ToString(), out float precio))
            //        {
            //            string producto = productoCell.Value.ToString();

            //            if (cantidad != 0)
            //            {
            //                arregloCantidad.Add(cantidad);
            //                arregloPrecios.Add(precio);
            //                arregloProductos.Add(producto);
            //            }

            //            this.label13.Text = ImprimirInformacion(arregloPrecios, arregloCantidad, arregloProductos);
            //            this.lbTotal.Text = TotalVenta.ToString();
            //        }
            //    }
            //    else
            //    {
            //        string productoExistente = productoCell.Value.ToString();
            //        int indice = arregloProductos.IndexOf(productoExistente);

            //        if (indice >= 0)
            //        {
            //            if (int.TryParse(cantCell.Value.ToString(), out int nuevaCantidad))
            //            {
            //                if (nuevaCantidad != 0)
            //                {
            //                    arregloCantidad[indice] = nuevaCantidad;
            //                    // También puedes actualizar el precio si es necesario
            //                    // arregloPrecios[indice] = nuevoPrecio;
            //                }
            //                else
            //                {
            //                    // Eliminar el producto de las listas
            //                    arregloCantidad.RemoveAt(indice);
            //                    arregloPrecios.RemoveAt(indice);
            //                    arregloProductos.RemoveAt(indice);
            //                }

            //                this.label13.Text = ImprimirInformacion(arregloPrecios, arregloCantidad, arregloProductos);
            //                this.lbTotal.Text = TotalVenta.ToString();
            //            }
            //        }
            //    }
            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //// Manejar el evento de clic del botón
            //if (seRealizaronEdiciones)
            //{
            //    this.label13.Text = ImprimirInformacion(arregloPrecios, arregloCantidad, arregloProductos);
            //}
            //else
            //{
            //    // No se realizaron ediciones
            //    MessageBox.Show("No se realizaron ediciones en el DataGridView.");
            //}

            //// Restablecer la bandera de ediciones
            //seRealizaronEdiciones = false;
        }

        //private string ImprimirInformacion(List<float> arregloPrecios, List<int> arregloCantidad, List<string> arregloProductos)
        //{
        //int cantidadElementos = arregloPrecios.Count;
        //StringBuilder sb = new StringBuilder();

        //TotalVenta = 0; // Reiniciar el valor del total de la venta

        //for (int i = 0; i < cantidadElementos; i++)
        //{
        //    float precio = arregloPrecios[i];
        //    int cantidad = arregloCantidad[i];
        //    string producto = arregloProductos[i];

        //    float total = precio * cantidad;
        //    TotalVenta += total;

        //    sb.AppendLine(producto.ToString() + precio.ToString().PadRight(15) + cantidad.ToString().PadRight(8) + total.ToString());
        //    precio = cantidad = 0;
        //    total = 0;
        //}

        //return sb.ToString();
        // }

        public void imprimirCliente()
        {
            //String impresionCliente;
            //impresionCliente =
            //    "                   DATOS CLIENTE " + "\n" +
            //    "CEDULA:                          ." + cedulaCLiente + "\n" +
            //    "NOMBRE:                          ." + nombreCliente + "\n" +
            //    "APELLIDO:                        ." + apellidoCliente + "\n" +
            //    "TELEFONO:                        ." + telefonoCliente + "\n" +
            //    "DIRECCION:                       ." + direccionCliente + "\n" +
            //    "CORREO:                          ." + correoCliente + "\n";
            //this.label18.Text = impresionCliente;
        }

        public void imprimirDetalle()
        {
            //    this.label17.Text = ImprimirInformacion(arregloPrecios, arregloCantidad, arregloProductos) + "\n" +
            //        "Descripción adicional: " + descripcionAdicionalCobro;
            //    this.label20.Text = TotalVenta.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}

