namespace ProyectoPrototipo_1._0
{
    partial class Form_Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            bttModuloInventario = new Button();
            bttModuloClientes = new Button();
            bttModuloProveedores = new Button();
            bttModuloVentas = new Button();
            bttModuloCompras = new Button();
            label1 = new Label();
            label2 = new Label();
            BSalir = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // bttModuloInventario
            // 
            bttModuloInventario.Location = new Point(118, 675);
            bttModuloInventario.Margin = new Padding(3, 4, 3, 4);
            bttModuloInventario.Name = "bttModuloInventario";
            bttModuloInventario.Size = new Size(143, 145);
            bttModuloInventario.TabIndex = 0;
            bttModuloInventario.Text = "MÓDULO DE INVENTARIO";
            bttModuloInventario.UseVisualStyleBackColor = true;
            bttModuloInventario.Click += bttModuloInventario_Click;
            // 
            // bttModuloClientes
            // 
            bttModuloClientes.Location = new Point(207, 358);
            bttModuloClientes.Margin = new Padding(3, 4, 3, 4);
            bttModuloClientes.Name = "bttModuloClientes";
            bttModuloClientes.Size = new Size(145, 145);
            bttModuloClientes.TabIndex = 1;
            bttModuloClientes.Text = "MÓDULO DE CLIENTES";
            bttModuloClientes.UseVisualStyleBackColor = true;
            bttModuloClientes.Click += bttModuloClientes_Click;
            // 
            // bttModuloProveedores
            // 
            bttModuloProveedores.Location = new Point(207, 522);
            bttModuloProveedores.Margin = new Padding(3, 4, 3, 4);
            bttModuloProveedores.Name = "bttModuloProveedores";
            bttModuloProveedores.Size = new Size(137, 145);
            bttModuloProveedores.TabIndex = 2;
            bttModuloProveedores.Text = "MÓDULO DE PROVEEDORES";
            bttModuloProveedores.UseVisualStyleBackColor = true;
            bttModuloProveedores.Click += bttProveedores_Click;
            // 
            // bttModuloVentas
            // 
            bttModuloVentas.Location = new Point(32, 358);
            bttModuloVentas.Margin = new Padding(3, 4, 3, 4);
            bttModuloVentas.Name = "bttModuloVentas";
            bttModuloVentas.Size = new Size(145, 145);
            bttModuloVentas.TabIndex = 3;
            bttModuloVentas.Text = "MÓDULO DE VENTAS";
            bttModuloVentas.UseVisualStyleBackColor = true;
            bttModuloVentas.Click += bttModuloVentas_Click;
            // 
            // bttModuloCompras
            // 
            bttModuloCompras.Location = new Point(32, 522);
            bttModuloCompras.Margin = new Padding(3, 4, 3, 4);
            bttModuloCompras.Name = "bttModuloCompras";
            bttModuloCompras.Size = new Size(137, 145);
            bttModuloCompras.TabIndex = 4;
            bttModuloCompras.Text = "MÓDULO DE COMPRAS";
            bttModuloCompras.UseVisualStyleBackColor = true;
            bttModuloCompras.Click += bttModuloCompras_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 212);
            label1.Name = "label1";
            label1.Size = new Size(0, 39);
            label1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 34.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(319, 212);
            label2.Name = "label2";
            label2.Size = new Size(0, 67);
            label2.TabIndex = 6;
            // 
            // BSalir
            // 
            BSalir.Location = new Point(159, 891);
            BSalir.Margin = new Padding(3, 4, 3, 4);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(88, 49);
            BSalir.TabIndex = 9;
            BSalir.Text = "SALIR";
            BSalir.UseVisualStyleBackColor = true;
            BSalir.Click += BSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 336);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(bttModuloInventario);
            panel1.Controls.Add(bttModuloClientes);
            panel1.Controls.Add(bttModuloProveedores);
            panel1.Controls.Add(bttModuloVentas);
            panel1.Controls.Add(bttModuloCompras);
            panel1.Location = new Point(12, 13);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(381, 861);
            panel1.TabIndex = 13;
            // 
            // Form_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1510, 953);
            Controls.Add(panel1);
            Controls.Add(BSalir);
            Controls.Add(label2);
            Controls.Add(label1);
            IsMdiContainer = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_Menu";
            Text = "SISTEMA DE GESTIÓN PARA “FARMACY ECUADOR”";
            FormClosing += Form_Menu_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttModuloInventario;
        private Button bttModuloClientes;
        private Button bttModuloProveedores;
        private Button bttModuloVentas;
        private Button bttModuloCompras;
        private Label label1;
        private Label label2;
        private Button BSalir;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}

