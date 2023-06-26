using Microsoft.EntityFrameworkCore;
using ProyectoPrototipo_1._0.CLASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrototipo_1._0
{
    public partial class Form_Proveedores : Form
    {
        private FarmaciaDbContext dbContext;
        public Form_Proveedores()
        {
            dbContext = new FarmaciaDbContext();
            InitializeComponent();
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox13.Enabled = false;
            textBox14.Enabled = false;

        }

        private void Form_Proveedores_Load(object sender, EventArgs e)
        {
            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                                      (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2); ;

            dbContext.Proveedor.Load();
            dataGridView1.DataSource = dbContext.Proveedor.Local.ToBindingList();
            //dbContext.SaveChanges();
        }
        // Variable para almacenar el índice de la pestaña actual
        private int indicePestanaActual = 0;
        private void AvanzarPestana()
        {
            // Deshabilitar la pestaña actual
            //TCProveedores.TabPages[indicePestanaActual].Enabled = false;

            // Incrementar el índice de la pestaña actual
            indicePestanaActual++;

            // Habilitar la siguiente pestaña
            if (indicePestanaActual < TCProveedores.TabCount)
            {
                TCProveedores.TabPages[indicePestanaActual].Enabled = true;
                TCProveedores.SelectedIndex = indicePestanaActual;
            }
        }


        private void BInfoProveedor_Click(object sender, EventArgs e)
        {
            this.AvanzarPestana();
        }

        private void BEvaluacion_Click(object sender, EventArgs e)
        {
            this.AvanzarPestana();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener el RUC del proveedor desde la fila seleccionada
                int ruc = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Ruc"].Value);
                Class_Proveedor? proveedorToUpdate = dbContext.Proveedor.FirstOrDefault(p => p.ruc == ruc);

                if (proveedorToUpdate != null)
                {
                    textBox1.Text = proveedorToUpdate.ruc.ToString();
                    textBox11.Text = proveedorToUpdate.ruc.ToString();
                    textBox13.Text = proveedorToUpdate.ruc.ToString();
                    textBox2.Text = proveedorToUpdate.razon_social;
                    textBox10.Text = proveedorToUpdate.razon_social;
                    textBox14.Text = proveedorToUpdate.razon_social;
                    textBox3.Text = proveedorToUpdate.nombre;
                    textBox4.Text = proveedorToUpdate.apellido;
                    textBox5.Text = proveedorToUpdate.email;
                    textBox6.Text = proveedorToUpdate.ciudad;
                    textBox7.Text = proveedorToUpdate.direccion;
                    textBox8.Text = proveedorToUpdate.telefono;
                    textBox12.Text = proveedorToUpdate.rubro;
                    textBox9.Text = proveedorToUpdate.observaciones;
                    textBox15.Text = proveedorToUpdate.observaciones;
                    tabPage4.Text = proveedorToUpdate.informacion_bancaria;
                    CBEvaluarProveedor.Text = proveedorToUpdate.calificacion;
                }
            }
            textBox1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)//create
        {
            // Obtener los datos ingresados por el usuario
            int ruc;
            if (!int.TryParse(textBox1.Text, out ruc))
            {
                MessageBox.Show("Ingrese un RUC válido.");
                return; // Salir del método sin agregar el proveedor
            }

            string razonSocial = textBox2.Text.Trim();
            if (string.IsNullOrEmpty(razonSocial))
            {
                MessageBox.Show("Ingrese una razón social válida.");
                return; // Salir del método sin agregar el proveedor
            }

            string nombre = textBox3.Text.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Ingrese un nombre válido.");
                return; // Salir del método sin agregar el proveedor
            }

            string apellido = textBox4.Text.Trim();
            if (string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("Ingrese un apellido válido.");
                return; // Salir del método sin agregar el proveedor
            }

            string email = textBox5.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Ingrese un email válido.");
                return; // Salir del método sin agregar el proveedor
            }

            string ciudad = textBox6.Text.Trim();
            if (string.IsNullOrEmpty(ciudad))
            {
                MessageBox.Show("Ingrese una ciudad válida.");
                return; // Salir del método sin agregar el proveedor
            }

            string direccion = textBox7.Text.Trim();
            if (string.IsNullOrEmpty(direccion))
            {
                MessageBox.Show("Ingrese una dirección válida.");
                return; // Salir del método sin agregar el proveedor
            }

            string telefono = textBox8.Text.Trim();
            if (string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("Ingrese un teléfono válido.");
                return; // Salir del método sin agregar el proveedor
            }

            string rubro = textBox12.Text.Trim();
            if (string.IsNullOrEmpty(rubro))
            {
                MessageBox.Show("Ingrese un rubro válido.");
                return; // Salir del método sin agregar el proveedor
            }

            string observaciones = textBox9.Text;
            string informacionBancaria = tabPage4.Text;
            string calificacion = CBEvaluarProveedor.Text;

            // Verificar si el RUC ya existe en la base de datos
            bool rucExists = dbContext.Proveedor.Any(p => p.ruc == ruc);

            if (rucExists)
            {
                MessageBox.Show("El RUC ya existe. Ingrese un RUC único.");
                return; // Salir del método sin agregar el proveedor
            }

            // Crear una nueva instancia de Proveedor y asignar los valores
            Class_Proveedor newProveedor = new Class_Proveedor
            {
                ruc = ruc,
                razon_social = razonSocial,
                nombre = nombre,
                apellido = apellido,
                email = email,
                ciudad = ciudad,
                direccion = direccion,
                telefono = telefono,
                rubro = rubro,
                observaciones = observaciones,
                informacion_bancaria = informacionBancaria,
                calificacion = calificacion
            };

            // Agregar el nuevo proveedor a la base de datos
            dbContext.Proveedor.Add(newProveedor);
            dbContext.SaveChanges();
            dataGridView1.DataSource = dbContext.Proveedor.Local.ToBindingList();
            MessageBox.Show("Proveedor creado exitosamente");
            ClearCreateControls();

        }

        private void ClearCreateControls()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            tabPage4.Text = string.Empty;
            CBEvaluarProveedor.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)//update
        {
            // Obtener el RUC del proveedor desde la fila seleccionada
            int ruc = Convert.ToInt32(textBox1.Text);

            // Buscar el proveedor por RUC en la base de datos
            Class_Proveedor? existingProveedor = dbContext.Proveedor.FirstOrDefault(p => p.ruc == ruc);

            if (existingProveedor != null)
            {
                // Obtener los nuevos datos ingresados por el usuario
                string razonSocial = textBox2.Text;
                string nombre = textBox3.Text;
                string apellido = textBox4.Text;
                string email = textBox5.Text;
                string ciudad = textBox6.Text;
                string direccion = textBox7.Text;
                string telefono = textBox8.Text;
                string rubro = textBox12.Text;
                string observaciones = textBox9.Text;
                string informacionBancaria = tabPage4.Text;
                string calificacion = CBEvaluarProveedor.Text;

                // Actualizar los datos del proveedor existente
                existingProveedor.razon_social = razonSocial;
                existingProveedor.nombre = nombre;
                existingProveedor.apellido = apellido;
                existingProveedor.email = email;
                existingProveedor.ciudad = ciudad;
                existingProveedor.direccion = direccion;
                existingProveedor.telefono = telefono;
                existingProveedor.rubro = rubro;
                existingProveedor.observaciones = observaciones;
                existingProveedor.informacion_bancaria = informacionBancaria;
                existingProveedor.calificacion = calificacion;

                // Guardar los cambios en la base de datos
                dbContext.SaveChanges();
                MessageBox.Show("Proveedor actualizado exitosamente");
                dataGridView1.DataSource = dbContext.Proveedor.Local.ToBindingList();
                dataGridView1.Refresh();

                // Limpiar los controles
                ClearCreateControls();
            }
            else
            {
                MessageBox.Show("No se encontró el proveedor");
                ClearCreateControls();
            }
            textBox1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)//Delete
        {
            // Obtener el RUC del proveedor desde el TextBox
            int ruc = Convert.ToInt32(textBox1.Text);

            // Buscar el proveedor por RUC en la base de datos
            Class_Proveedor? proveedorToDelete = dbContext.Proveedor.FirstOrDefault(p => p.ruc == ruc);

            if (proveedorToDelete != null)
            {
                dbContext.Proveedor.Remove(proveedorToDelete);
                dbContext.SaveChanges();
                MessageBox.Show("Proveedor eliminado exitosamente");

                // Vaciar el DataGridView seleccionado
                dataGridView1.DataSource = dbContext.Proveedor.Local.ToBindingList();
                dataGridView1.Refresh();
                // Limpiar los controles
                ClearCreateControls();
            }
            else
            {
                MessageBox.Show("No se encontró el proveedor");
                ClearCreateControls();
            }
            //RucDelete.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)//Cancelar
        {
            dataGridView1.DataSource = dbContext.Proveedor.Local.ToBindingList();
            dataGridView1.Refresh();
            // Limpiar los controles
            ClearCreateControls();
        }

        private void button1_Click(object sender, EventArgs e)//Buscar
        {
            // Obtener los valores de los campos de búsqueda
            int ruc;
            int.TryParse(textBox1.Text, out ruc);

            string razonSocial = textBox2.Text.Trim();

            string nombre = textBox3.Text.Trim();

            string apellido = textBox4.Text.Trim();

            string email = textBox5.Text.Trim();

            string ciudad = textBox6.Text.Trim();

            string direccion = textBox7.Text.Trim();

            string telefono = textBox8.Text.Trim();

            string rubro = textBox12.Text.Trim();

            string observaciones = textBox9.Text.Trim();

            string informacionBancaria = tabPage4.Text.Trim();

            string calificacion = CBEvaluarProveedor.Text.Trim();

            // Filtrar los proveedores según los campos ingresados
            var filteredProveedores = dbContext.Proveedor.AsQueryable();

            if (ruc != 0)
            {
                filteredProveedores = filteredProveedores.Where(p => p.ruc == ruc);
            }

            if (!string.IsNullOrEmpty(razonSocial))
            {
                filteredProveedores = filteredProveedores.Where(p => p.razon_social.Contains(razonSocial));
            }

            if (!string.IsNullOrEmpty(nombre))
            {
                filteredProveedores = filteredProveedores.Where(p => p.nombre.Contains(nombre));
            }

            if (!string.IsNullOrEmpty(apellido))
            {
                filteredProveedores = filteredProveedores.Where(p => p.apellido.Contains(apellido));
            }

            if (!string.IsNullOrEmpty(email))
            {
                filteredProveedores = filteredProveedores.Where(p => p.email.Contains(email));
            }

            if (!string.IsNullOrEmpty(ciudad))
            {
                filteredProveedores = filteredProveedores.Where(p => p.ciudad.Contains(ciudad));
            }

            if (!string.IsNullOrEmpty(direccion))
            {
                filteredProveedores = filteredProveedores.Where(p => p.direccion.Contains(direccion));
            }

            if (!string.IsNullOrEmpty(telefono))
            {
                filteredProveedores = filteredProveedores.Where(p => p.telefono.Contains(telefono));
            }

            if (!string.IsNullOrEmpty(rubro))
            {
                filteredProveedores = filteredProveedores.Where(p => p.rubro.Contains(rubro));
            }

            if (!string.IsNullOrEmpty(observaciones))
            {
                filteredProveedores = filteredProveedores.Where(p => p.observaciones.Contains(observaciones));
            }

            if (!string.IsNullOrEmpty(informacionBancaria))
            {
                filteredProveedores = filteredProveedores.Where(p => p.informacion_bancaria.Contains(informacionBancaria));
            }

            if (!string.IsNullOrEmpty(calificacion))
            {
                filteredProveedores = filteredProveedores.Where(p => p.calificacion.Contains(calificacion));
            }

            // Mostrar los proveedores filtrados en el DataGridView
            dataGridView1.DataSource = filteredProveedores.ToList();
        }

        private void BEvaluarProveedor_Click(object sender, EventArgs e)//Evaluar
        {

            // Obtener el RUC del proveedor desde la fila seleccionada
            int ruc = Convert.ToInt32(textBox1.Text);

            // Buscar el proveedor por RUC en la base de datos
            Class_Proveedor? existingProveedor = dbContext.Proveedor.FirstOrDefault(p => p.ruc == ruc);

            if (existingProveedor != null)
            {
                // Obtener los nuevos datos ingresados por el usuario
                string razonSocial = textBox2.Text;
                string nombre = textBox3.Text;
                string apellido = textBox4.Text;
                string email = textBox5.Text;
                string ciudad = textBox6.Text;
                string direccion = textBox7.Text;
                string telefono = textBox8.Text;
                string rubro = textBox12.Text;
                string observaciones = textBox15.Text;
                string informacionBancaria = tabPage4.Text;
                string calificacion = CBEvaluarProveedor.Text;

                // Actualizar los datos del proveedor existente
                existingProveedor.razon_social = razonSocial;
                existingProveedor.nombre = nombre;
                existingProveedor.apellido = apellido;
                existingProveedor.email = email;
                existingProveedor.ciudad = ciudad;
                existingProveedor.direccion = direccion;
                existingProveedor.telefono = telefono;
                existingProveedor.rubro = rubro;
                existingProveedor.observaciones = observaciones;
                existingProveedor.informacion_bancaria = informacionBancaria;
                existingProveedor.calificacion = calificacion;

                // Guardar los cambios en la base de datos
                dbContext.SaveChanges();
                MessageBox.Show("Proveedor actualizado exitosamente");
                dataGridView1.DataSource = dbContext.Proveedor.Local.ToBindingList();
                dataGridView1.Refresh();

                // Limpiar los controles
                ClearCreateControls();
            }
        }
    }
}
