namespace ProyectoPrototipo_1._1.FORMS
{
    partial class Form_AdministracionDeUsuarios
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
            TCProveedores = new TabControl();
            tabPage1 = new TabPage();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label12 = new Label();
            button4 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            tabPage7 = new TabPage();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            label9 = new Label();
            button2 = new Button();
            textBox6 = new TextBox();
            label11 = new Label();
            textBox7 = new TextBox();
            label13 = new Label();
            tabPage3 = new TabPage();
            comboBox2 = new ComboBox();
            label8 = new Label();
            label10 = new Label();
            button3 = new Button();
            textBox9 = new TextBox();
            label15 = new Label();
            tabPage8 = new TabPage();
            textBox5 = new TextBox();
            label6 = new Label();
            button8 = new Button();
            dataGridView1 = new DataGridView();
            TCProveedores.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage7.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TCProveedores
            // 
            TCProveedores.Controls.Add(tabPage1);
            TCProveedores.Controls.Add(tabPage7);
            TCProveedores.Controls.Add(tabPage8);
            TCProveedores.Location = new Point(9, 9);
            TCProveedores.Margin = new Padding(3, 4, 3, 4);
            TCProveedores.Name = "TCProveedores";
            TCProveedores.SelectedIndex = 0;
            TCProveedores.Size = new Size(882, 317);
            TCProveedores.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(874, 284);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Asignar credenciales";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Vendedor", "Administrador" });
            comboBox1.Location = new Point(158, 140);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(169, 28);
            comboBox1.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 141);
            label7.Name = "label7";
            label7.Size = new Size(115, 20);
            label7.TabIndex = 25;
            label7.Text = "Tipo de usuario:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(592, 89);
            label12.Name = "label12";
            label12.Size = new Size(0, 20);
            label12.TabIndex = 24;
            // 
            // button4
            // 
            button4.Location = new Point(399, 82);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(88, 35);
            button4.TabIndex = 16;
            button4.Text = "Asignar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(158, 82);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(169, 27);
            textBox2.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 89);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 34);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 27);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 41);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(tabControl1);
            tabPage7.Location = new Point(4, 29);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(874, 284);
            tabPage7.TabIndex = 4;
            tabPage7.Text = "Actualizar";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(3, 4);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(827, 245);
            tabControl1.TabIndex = 55;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(textBox7);
            tabPage2.Controls.Add(label13);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(819, 212);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "Credenciales";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(595, 93);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 24;
            // 
            // button2
            // 
            button2.Location = new Point(384, 74);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(88, 35);
            button2.TabIndex = 16;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(158, 82);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(169, 27);
            textBox6.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(79, 93);
            label11.Name = "label11";
            label11.Size = new Size(73, 20);
            label11.TabIndex = 4;
            label11.Text = "Password:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(158, 34);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(169, 27);
            textBox7.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(79, 45);
            label13.Name = "label13";
            label13.Size = new Size(78, 20);
            label13.TabIndex = 2;
            label13.Text = "Username:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(comboBox2);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(textBox9);
            tabPage3.Controls.Add(label15);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(819, 212);
            tabPage3.TabIndex = 4;
            tabPage3.Text = "Privilegios";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Vendedor", "Administrador" });
            comboBox2.Location = new Point(163, 92);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(169, 28);
            comboBox2.TabIndex = 57;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 97);
            label8.Name = "label8";
            label8.Size = new Size(115, 20);
            label8.TabIndex = 56;
            label8.Text = "Tipo de usuario:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(56, 177);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 55;
            // 
            // button3
            // 
            button3.Location = new Point(361, 88);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(88, 35);
            button3.TabIndex = 54;
            button3.Text = "Actualizar";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(161, 39);
            textBox9.Margin = new Padding(3, 4, 3, 4);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(169, 27);
            textBox9.TabIndex = 51;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(79, 44);
            label15.Name = "label15";
            label15.Size = new Size(78, 20);
            label15.TabIndex = 50;
            label15.Text = "Username:";
            // 
            // tabPage8
            // 
            tabPage8.Controls.Add(textBox5);
            tabPage8.Controls.Add(label6);
            tabPage8.Controls.Add(button8);
            tabPage8.Location = new Point(4, 29);
            tabPage8.Name = "tabPage8";
            tabPage8.Size = new Size(874, 284);
            tabPage8.TabIndex = 5;
            tabPage8.Text = "Eliminar";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(152, 37);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(169, 27);
            textBox5.TabIndex = 54;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 42);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 53;
            label6.Text = "Username:";
            // 
            // button8
            // 
            button8.Location = new Point(360, 33);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(93, 35);
            button8.TabIndex = 52;
            button8.Text = "Eliminar";
            button8.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 306);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(878, 246);
            dataGridView1.TabIndex = 2;
            // 
            // Form_Administracion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 591);
            Controls.Add(TCProveedores);
            Controls.Add(dataGridView1);
            Name = "Form_Administracion";
            Text = "Form_Administración";
            Load += Form_Administracion_Load;
            TCProveedores.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage7.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage8.ResumeLayout(false);
            tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TCProveedores;
        private TabPage tabPage1;
        private Label label12;
        private Button button4;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private Button button8;
        private DataGridView dataGridView1;
        private TextBox textBox5;
        private Label label6;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private Label label9;
        private Button button2;
        private TextBox textBox6;
        private Label label11;
        private TextBox textBox7;
        private Label label13;
        private TabPage tabPage3;
        private Button button3;
        private TextBox textBox9;
        private Label label15;
        private ComboBox comboBox1;
        private Label label7;
        private ComboBox comboBox2;
        private Label label8;
        private Label label10;
    }
}