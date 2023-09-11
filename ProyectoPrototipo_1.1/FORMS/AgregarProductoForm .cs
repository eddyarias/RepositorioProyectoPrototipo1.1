using System;
using System.Windows.Forms;

namespace ProyectoPrototipo_1._1.FORMS
{
    public partial class AgregarProductoForm : Form
    {
        public AgregarProductoForm()
        {
            InitializeComponent();
            // Inicializar componentes (generados por el diseñador)
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(350, 211);
            this.Name = "AgregarProductoForm";
            this.Text = "Agregar Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

            // Crear etiqueta para la descripción
            Label lblDescripcion = new Label();
            lblDescripcion.Text = "Descripción:";
            lblDescripcion.Location = new System.Drawing.Point(12, 12);
            lblDescripcion.AutoSize = true;

            // Crear cuadro de texto para la descripción
            txtDescripcion = new TextBox();
            txtDescripcion.Location = new System.Drawing.Point(120, 12);
            txtDescripcion.Width = 200;
            txtDescripcion.Enabled = false;

            // Crear etiqueta para el precio
            Label lblPrecio = new Label();
            lblPrecio.Text = "Precio:";
            lblPrecio.Location = new System.Drawing.Point(12, 50);
            lblPrecio.AutoSize = true;

            // Crear cuadro de texto para el precio
            txtPrecio = new TextBox();
            txtPrecio.Location = new System.Drawing.Point(120, 50);
            txtPrecio.Width = 200;
            txtPrecio.Enabled = false;

            // Crear etiqueta para la cantidad
            Label lblCantidad = new Label();
            lblCantidad.Text = "Cantidad:";
            lblCantidad.Location = new System.Drawing.Point(12, 88);
            lblCantidad.AutoSize = true;

            // Crear NumericUpDown para la cantidad
            numericUpDownCantidad = new NumericUpDown();
            numericUpDownCantidad.Location = new System.Drawing.Point(120, 88);
            numericUpDownCantidad.Width = 100;

            // Crear botón Aceptar (más grande)
            Button btnAceptar = new Button();
            btnAceptar.Text = "Aceptar";
            btnAceptar.Location = new System.Drawing.Point(120, 130);
            btnAceptar.Size = new System.Drawing.Size(100, 40); // Ajusta el ancho y alto del botón
            btnAceptar.Click += BtnAceptar_Click;

            // Crear botón Cancelar (más grande)
            Button btnCancelar = new Button();
            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new System.Drawing.Point(240, 130); // Alinea el botón Cancelar más a la derecha
            btnCancelar.Size = new System.Drawing.Size(100, 40); // Ajusta el ancho y alto del botón
            btnCancelar.Click += BtnCancelar_Click;

            // Agregar los controles al formulario
            this.Controls.Add(lblDescripcion);
            this.Controls.Add(txtDescripcion);
            this.Controls.Add(lblPrecio);
            this.Controls.Add(txtPrecio);
            this.Controls.Add(lblCantidad);
            this.Controls.Add(numericUpDownCantidad);
            this.Controls.Add(btnAceptar);
            this.Controls.Add(btnCancelar);
        }

        public string Descripcion
        {
            get { return txtDescripcion.Text; }
            set { txtDescripcion.Text = value; }
        }

        public decimal Precio
        {
            get { return decimal.Parse(txtPrecio.Text); }
            set { txtPrecio.Text = value.ToString("0.00"); }
        }

        public int CantidadIngresada
        {
            get { return (int)numericUpDownCantidad.Value; }
        }





        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        // Declaración de los controles como variables miembro
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private NumericUpDown numericUpDownCantidad;

        private void AgregarProductoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
