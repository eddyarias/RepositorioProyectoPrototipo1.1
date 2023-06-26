namespace ProyectoPrototipo_1._0
{
    partial class Form_Ventas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TabSecuencialVentas = new TabControl();
            tabPage1 = new TabPage();
            lbTotal = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            button3 = new Button();
            tabPage2 = new TabPage();
            txtBcorreoCliente = new TextBox();
            label10 = new Label();
            button2 = new Button();
            txtBdireccionCliente = new TextBox();
            txtBtelefonoCliente = new TextBox();
            txtBapellidosClientes = new TextBox();
            txtBnombresCliente = new TextBox();
            txtBcedulaCliente = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage3 = new TabPage();
            txtBDescripcionAdicional = new TextBox();
            label11 = new Label();
            label9 = new Label();
            comboBox2 = new ComboBox();
            checkedListBox2 = new CheckedListBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            checkedListBox1 = new CheckedListBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            tabPage4 = new TabPage();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            TabSecuencialVentas.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // TabSecuencialVentas
            // 
            TabSecuencialVentas.Controls.Add(tabPage1);
            TabSecuencialVentas.Controls.Add(tabPage2);
            TabSecuencialVentas.Controls.Add(tabPage3);
            TabSecuencialVentas.Controls.Add(tabPage4);
            TabSecuencialVentas.Location = new Point(22, 4);
            TabSecuencialVentas.Margin = new Padding(3, 4, 3, 4);
            TabSecuencialVentas.Name = "TabSecuencialVentas";
            TabSecuencialVentas.SelectedIndex = 0;
            TabSecuencialVentas.Size = new Size(862, 558);
            TabSecuencialVentas.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lbTotal);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(button3);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(854, 525);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Seleccion Producto";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(736, 390);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(44, 20);
            lbTotal.TabIndex = 17;
            lbTotal.Text = "00.00";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(368, 358);
            label15.Name = "label15";
            label15.Size = new Size(351, 20);
            label15.TabIndex = 16;
            label15.Text = "_________________________________________________________";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(656, 390);
            label14.Name = "label14";
            label14.Size = new Size(50, 20);
            label14.TabIndex = 15;
            label14.Text = "TOTAL";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Cascadia Mono", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(368, 99);
            label13.Name = "label13";
            label13.Size = new Size(16, 17);
            label13.TabIndex = 14;
            label13.Text = ".";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(368, 65);
            label12.Name = "label12";
            label12.Size = new Size(422, 20);
            label12.TabIndex = 13;
            label12.Text = "PRODUCTO              PRECIO UNI.            CANT.           SUBTOTAL";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Producto, Precio, Cantidad });
            dataGridView1.Location = new Point(6, 50);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(336, 449);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 125;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 125;
            // 
            // button3
            // 
            button3.Location = new Point(659, 428);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(150, 71);
            button3.TabIndex = 11;
            button3.Text = "CONTINUAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtBcorreoCliente);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(txtBdireccionCliente);
            tabPage2.Controls.Add(txtBtelefonoCliente);
            tabPage2.Controls.Add(txtBapellidosClientes);
            tabPage2.Controls.Add(txtBnombresCliente);
            tabPage2.Controls.Add(txtBcedulaCliente);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(854, 525);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Datos cliente";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtBcorreoCliente
            // 
            txtBcorreoCliente.Location = new Point(226, 354);
            txtBcorreoCliente.Margin = new Padding(3, 4, 3, 4);
            txtBcorreoCliente.Name = "txtBcorreoCliente";
            txtBcorreoCliente.Size = new Size(309, 27);
            txtBcorreoCliente.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(82, 358);
            label10.Name = "label10";
            label10.Size = new Size(135, 20);
            label10.TabIndex = 11;
            label10.Text = "Correo electrónico:";
            // 
            // button2
            // 
            button2.Location = new Point(601, 400);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(156, 86);
            button2.TabIndex = 10;
            button2.Text = "CONTINUAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtBdireccionCliente
            // 
            txtBdireccionCliente.Location = new Point(226, 296);
            txtBdireccionCliente.Margin = new Padding(3, 4, 3, 4);
            txtBdireccionCliente.Name = "txtBdireccionCliente";
            txtBdireccionCliente.Size = new Size(309, 27);
            txtBdireccionCliente.TabIndex = 9;
            // 
            // txtBtelefonoCliente
            // 
            txtBtelefonoCliente.Location = new Point(226, 249);
            txtBtelefonoCliente.Margin = new Padding(3, 4, 3, 4);
            txtBtelefonoCliente.Name = "txtBtelefonoCliente";
            txtBtelefonoCliente.Size = new Size(309, 27);
            txtBtelefonoCliente.TabIndex = 8;
            // 
            // txtBapellidosClientes
            // 
            txtBapellidosClientes.Location = new Point(226, 196);
            txtBapellidosClientes.Margin = new Padding(3, 4, 3, 4);
            txtBapellidosClientes.Name = "txtBapellidosClientes";
            txtBapellidosClientes.Size = new Size(309, 27);
            txtBapellidosClientes.TabIndex = 7;
            // 
            // txtBnombresCliente
            // 
            txtBnombresCliente.Location = new Point(226, 138);
            txtBnombresCliente.Margin = new Padding(3, 4, 3, 4);
            txtBnombresCliente.Name = "txtBnombresCliente";
            txtBnombresCliente.RightToLeft = RightToLeft.No;
            txtBnombresCliente.Size = new Size(309, 27);
            txtBnombresCliente.TabIndex = 6;
            // 
            // txtBcedulaCliente
            // 
            txtBcedulaCliente.Location = new Point(226, 85);
            txtBcedulaCliente.Margin = new Padding(3, 4, 3, 4);
            txtBcedulaCliente.Name = "txtBcedulaCliente";
            txtBcedulaCliente.Size = new Size(309, 27);
            txtBcedulaCliente.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 304);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 4;
            label5.Text = "Dirección:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 256);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 200);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Apellidos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 145);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombres: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 89);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 0;
            label1.Text = "Cedula/Ruc:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(txtBDescripcionAdicional);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(comboBox2);
            tabPage3.Controls.Add(checkedListBox2);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(checkedListBox1);
            tabPage3.Controls.Add(comboBox1);
            tabPage3.Controls.Add(button1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(854, 525);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Cobro";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtBDescripcionAdicional
            // 
            txtBDescripcionAdicional.Location = new Point(73, 435);
            txtBDescripcionAdicional.Margin = new Padding(3, 4, 3, 4);
            txtBDescripcionAdicional.Name = "txtBDescripcionAdicional";
            txtBDescripcionAdicional.Size = new Size(302, 27);
            txtBDescripcionAdicional.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(38, 382);
            label11.Name = "label11";
            label11.Size = new Size(211, 20);
            label11.TabIndex = 9;
            label11.Text = "Agregar descripción adicional:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(484, 89);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 8;
            label9.Text = "Porcentaje";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "5%", "10%", "15%", "20%", "25%", "30%", "45%", "50%", "60%", "65%" });
            comboBox2.Location = new Point(484, 116);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 28);
            comboBox2.TabIndex = 7;
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "SI", "NO" });
            checkedListBox2.Location = new Point(360, 105);
            checkedListBox2.Margin = new Padding(3, 4, 3, 4);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(103, 48);
            checkedListBox2.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(365, 39);
            label8.Name = "label8";
            label8.Size = new Size(82, 20);
            label8.TabIndex = 5;
            label8.Text = "Descuento:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 208);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 4;
            label7.Text = "Selección:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 40);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 3;
            label6.Text = "Forma de pago:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Consumidor final", "Factura con datos" });
            checkedListBox1.Location = new Point(73, 251);
            checkedListBox1.Margin = new Padding(3, 4, 3, 4);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(145, 48);
            checkedListBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Efectivo", "Tarjeta de credito", "Transferencia" });
            comboBox1.Location = new Point(73, 105);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 28);
            comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(518, 366);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(221, 100);
            button1.TabIndex = 0;
            button1.Text = "GENERAR FACTURA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label22);
            tabPage4.Controls.Add(label21);
            tabPage4.Controls.Add(label20);
            tabPage4.Controls.Add(label19);
            tabPage4.Controls.Add(label18);
            tabPage4.Controls.Add(label17);
            tabPage4.Controls.Add(label16);
            tabPage4.Controls.Add(button6);
            tabPage4.Controls.Add(button5);
            tabPage4.Controls.Add(button4);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(3, 4, 3, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(854, 525);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Factura";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(178, 189);
            label22.Name = "label22";
            label22.Size = new Size(422, 20);
            label22.TabIndex = 20;
            label22.Text = "PRODUCTO              PRECIO UNI.            CANT.           SUBTOTAL";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(414, 394);
            label21.Name = "label21";
            label21.Size = new Size(50, 20);
            label21.TabIndex = 19;
            label21.Text = "TOTAL";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(504, 394);
            label20.Name = "label20";
            label20.Size = new Size(44, 20);
            label20.TabIndex = 18;
            label20.Text = "00.00";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(200, 374);
            label19.Name = "label19";
            label19.Size = new Size(315, 20);
            label19.TabIndex = 17;
            label19.Text = "___________________________________________________";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Consolas", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(178, 38);
            label18.Name = "label18";
            label18.Size = new Size(56, 15);
            label18.TabIndex = 5;
            label18.Text = "label18";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Consolas", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(178, 220);
            label17.Name = "label17";
            label17.Size = new Size(56, 15);
            label17.TabIndex = 4;
            label17.Text = "label17";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(301, 0);
            label16.Name = "label16";
            label16.Size = new Size(204, 25);
            label16.TabIndex = 3;
            label16.Text = "FACTURA N°   00001";
            // 
            // button6
            // 
            button6.Location = new Point(296, 444);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(209, 56);
            button6.TabIndex = 2;
            button6.Text = "Anular";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(570, 444);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(209, 56);
            button5.TabIndex = 1;
            button5.Text = "Imprimir";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(25, 444);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(209, 56);
            button4.TabIndex = 0;
            button4.Text = "Enviar al correo electronico cliente";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form_Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 591);
            Controls.Add(TabSecuencialVentas);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_Ventas";
            Text = "Ventas";
            Load += Form_Ventas_Load;
            TabSecuencialVentas.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabSecuencialVentas;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private Label label1;
        private TabPage tabPage3;
        private Button button1;
        private TabPage tabPage4;
        private Label label3;
        private Button button2;
        private TextBox txtBdireccionCliente;
        private TextBox txtBtelefonoCliente;
        private TextBox txtBapellidosClientes;
        private TextBox txtBnombresCliente;
        private TextBox txtBcedulaCliente;
        private Label label5;
        private Label label4;
        private CheckedListBox checkedListBox1;
        private ComboBox comboBox1;
        private Button button3;
        private Label label9;
        private ComboBox comboBox2;
        private CheckedListBox checkedListBox2;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtBcorreoCliente;
        private Label label10;
        private Button button4;
        private Button button6;
        private Button button5;
        private Label label11;
        private TextBox txtBDescripcionAdicional;
        private DataGridView dataGridView1;
        private Label label12;
        private Label label13;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private Label lbTotal;
        private Label label15;
        private Label label14;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label20;
        private Label label19;
        private Label label21;
        private Label label22;
    }
}