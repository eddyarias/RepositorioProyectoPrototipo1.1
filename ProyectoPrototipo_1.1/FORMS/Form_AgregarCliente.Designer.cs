namespace ProyectoPrototipo_1._1.FORMS
{
    partial class Form_AgregarCliente
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
            clientesTabControl = new TabControl();
            registrarTabPage = new TabPage();
            comboBoxTipoPersona = new ComboBox();
            Tipo = new Label();
            label5 = new Label();
            comboBEstadoCivil = new ComboBox();
            dateTimePickerFechaNacimiento = new DateTimePicker();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            codeLabel = new Label();
            txtBCedula = new TextBox();
            button4 = new Button();
            personNameLabel = new Label();
            comercialNameLabel = new Label();
            txtBNombres = new TextBox();
            txtBApellidos = new TextBox();
            txtBEmail = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtBDireccion = new TextBox();
            label1 = new Label();
            txtBCelular = new TextBox();
            label3 = new Label();
            label6 = new Label();
            tabPage3 = new TabPage();
            button8 = new Button();
            label25 = new Label();
            textBox28 = new TextBox();
            tabPage2 = new TabPage();
            label2 = new Label();
            findClientButton = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            clientesTabControl.SuspendLayout();
            registrarTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // clientesTabControl
            // 
            clientesTabControl.Controls.Add(registrarTabPage);
            clientesTabControl.Location = new Point(39, 31);
            clientesTabControl.Name = "clientesTabControl";
            clientesTabControl.SelectedIndex = 0;
            clientesTabControl.Size = new Size(500, 600);
            clientesTabControl.TabIndex = 43;
            // 
            // registrarTabPage
            // 
            registrarTabPage.Controls.Add(comboBoxTipoPersona);
            registrarTabPage.Controls.Add(Tipo);
            registrarTabPage.Controls.Add(label5);
            registrarTabPage.Controls.Add(comboBEstadoCivil);
            registrarTabPage.Controls.Add(dateTimePickerFechaNacimiento);
            registrarTabPage.Controls.Add(label17);
            registrarTabPage.Controls.Add(label18);
            registrarTabPage.Controls.Add(label19);
            registrarTabPage.Controls.Add(label20);
            registrarTabPage.Controls.Add(label21);
            registrarTabPage.Controls.Add(label22);
            registrarTabPage.Controls.Add(label23);
            registrarTabPage.Controls.Add(label24);
            registrarTabPage.Controls.Add(codeLabel);
            registrarTabPage.Controls.Add(txtBCedula);
            registrarTabPage.Controls.Add(button4);
            registrarTabPage.Controls.Add(personNameLabel);
            registrarTabPage.Controls.Add(comercialNameLabel);
            registrarTabPage.Controls.Add(txtBNombres);
            registrarTabPage.Controls.Add(txtBApellidos);
            registrarTabPage.Controls.Add(txtBEmail);
            registrarTabPage.Controls.Add(label8);
            registrarTabPage.Controls.Add(label7);
            registrarTabPage.Controls.Add(txtBDireccion);
            registrarTabPage.Controls.Add(label1);
            registrarTabPage.Controls.Add(txtBCelular);
            registrarTabPage.Controls.Add(label3);
            registrarTabPage.Controls.Add(label6);
            registrarTabPage.Location = new Point(4, 29);
            registrarTabPage.Name = "registrarTabPage";
            registrarTabPage.Padding = new Padding(3);
            registrarTabPage.Size = new Size(492, 567);
            registrarTabPage.TabIndex = 0;
            registrarTabPage.Text = "Registrar";
            registrarTabPage.UseVisualStyleBackColor = true;
            // 
            // comboBoxTipoPersona
            // 
            comboBoxTipoPersona.FormattingEnabled = true;
            comboBoxTipoPersona.Items.AddRange(new object[] { "Persona Natural", "Persona Jurídica" });
            comboBoxTipoPersona.Location = new Point(154, 99);
            comboBoxTipoPersona.Name = "comboBoxTipoPersona";
            comboBoxTipoPersona.Size = new Size(151, 28);
            comboBoxTipoPersona.TabIndex = 53;
            // 
            // Tipo
            // 
            Tipo.AutoSize = true;
            Tipo.Location = new Point(97, 107);
            Tipo.Name = "Tipo";
            Tipo.Size = new Size(42, 20);
            Tipo.TabIndex = 52;
            Tipo.Text = "Tipo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 96);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 50;
            // 
            // comboBEstadoCivil
            // 
            comboBEstadoCivil.FormattingEnabled = true;
            comboBEstadoCivil.Items.AddRange(new object[] { "Soltero(a)", "Casado(a)", "Divorciado(a)" });
            comboBEstadoCivil.Location = new Point(154, 348);
            comboBEstadoCivil.Name = "comboBEstadoCivil";
            comboBEstadoCivil.Size = new Size(151, 28);
            comboBEstadoCivil.TabIndex = 49;
            // 
            // dateTimePickerFechaNacimiento
            // 
            dateTimePickerFechaNacimiento.Location = new Point(154, 396);
            dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            dateTimePickerFechaNacimiento.Size = new Size(285, 27);
            dateTimePickerFechaNacimiento.TabIndex = 48;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(101, 65);
            label17.Name = "label17";
            label17.Size = new Size(45, 20);
            label17.TabIndex = 40;
            label17.Text = "CI: (*)";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(53, 154);
            label18.Name = "label18";
            label18.Size = new Size(93, 20);
            label18.TabIndex = 41;
            label18.Text = "Nombres: (*)";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(53, 196);
            label19.Name = "label19";
            label19.Size = new Size(95, 20);
            label19.TabIndex = 42;
            label19.Text = "Apellidos: (*)";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(99, 314);
            label20.Name = "label20";
            label20.Size = new Size(49, 20);
            label20.TabIndex = 45;
            label20.Text = "Email:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(73, 236);
            label21.Name = "label21";
            label21.Size = new Size(75, 20);
            label21.TabIndex = 44;
            label21.Text = "Dirección:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(90, 276);
            label22.Name = "label22";
            label22.Size = new Size(58, 20);
            label22.TabIndex = 46;
            label22.Text = "Celular:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(45, 401);
            label23.Name = "label23";
            label23.Size = new Size(103, 20);
            label23.TabIndex = 47;
            label23.Text = "F. Nacimiento:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(59, 356);
            label24.Name = "label24";
            label24.Size = new Size(89, 20);
            label24.TabIndex = 43;
            label24.Text = "Estado Civil:";
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new Point(108, 65);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new Size(0, 20);
            codeLabel.TabIndex = 3;
            // 
            // txtBCedula
            // 
            txtBCedula.Location = new Point(154, 54);
            txtBCedula.Margin = new Padding(3, 4, 3, 4);
            txtBCedula.Multiline = true;
            txtBCedula.Name = "txtBCedula";
            txtBCedula.Size = new Size(165, 31);
            txtBCedula.TabIndex = 4;
            // 
            // button4
            // 
            button4.Location = new Point(205, 459);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(114, 38);
            button4.TabIndex = 39;
            button4.Text = "Registrar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // personNameLabel
            // 
            personNameLabel.AutoSize = true;
            personNameLabel.Location = new Point(60, 105);
            personNameLabel.Name = "personNameLabel";
            personNameLabel.Size = new Size(0, 20);
            personNameLabel.TabIndex = 6;
            // 
            // comercialNameLabel
            // 
            comercialNameLabel.AutoSize = true;
            comercialNameLabel.Location = new Point(59, 145);
            comercialNameLabel.Name = "comercialNameLabel";
            comercialNameLabel.Size = new Size(0, 20);
            comercialNameLabel.TabIndex = 7;
            // 
            // txtBNombres
            // 
            txtBNombres.Location = new Point(154, 145);
            txtBNombres.Margin = new Padding(3, 4, 3, 4);
            txtBNombres.Multiline = true;
            txtBNombres.Name = "txtBNombres";
            txtBNombres.Size = new Size(285, 29);
            txtBNombres.TabIndex = 15;
            // 
            // txtBApellidos
            // 
            txtBApellidos.Location = new Point(154, 185);
            txtBApellidos.Margin = new Padding(3, 4, 3, 4);
            txtBApellidos.Multiline = true;
            txtBApellidos.Name = "txtBApellidos";
            txtBApellidos.Size = new Size(285, 29);
            txtBApellidos.TabIndex = 16;
            // 
            // txtBEmail
            // 
            txtBEmail.Location = new Point(154, 305);
            txtBEmail.Margin = new Padding(3, 4, 3, 4);
            txtBEmail.Multiline = true;
            txtBEmail.Name = "txtBEmail";
            txtBEmail.Size = new Size(285, 29);
            txtBEmail.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(103, 316);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(80, 185);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 9;
            // 
            // txtBDireccion
            // 
            txtBDireccion.Location = new Point(154, 225);
            txtBDireccion.Margin = new Padding(3, 4, 3, 4);
            txtBDireccion.Multiline = true;
            txtBDireccion.Name = "txtBDireccion";
            txtBDireccion.Size = new Size(285, 29);
            txtBDireccion.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 276);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 19;
            // 
            // txtBCelular
            // 
            txtBCelular.Location = new Point(154, 265);
            txtBCelular.Margin = new Padding(3, 4, 3, 4);
            txtBCelular.Multiline = true;
            txtBCelular.Name = "txtBCelular";
            txtBCelular.Size = new Size(285, 29);
            txtBCelular.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 322);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(64, 305);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 8;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(404, 436);
            tabPage3.TabIndex = 1;
            tabPage3.Text = "Compras";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(134, 102);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(114, 40);
            button8.TabIndex = 2;
            button8.Text = "Consultar";
            button8.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(71, 64);
            label25.Name = "label25";
            label25.Size = new Size(25, 20);
            label25.TabIndex = 0;
            // 
            // textBox28
            // 
            textBox28.Location = new Point(93, 50);
            textBox28.Name = "textBox28";
            textBox28.Size = new Size(233, 27);
            textBox28.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(404, 436);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "Datos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 33);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 0;
            // 
            // findClientButton
            // 
            findClientButton.Location = new Point(137, 162);
            findClientButton.Margin = new Padding(3, 4, 3, 4);
            findClientButton.Name = "findClientButton";
            findClientButton.Size = new Size(114, 40);
            findClientButton.TabIndex = 2;
            findClientButton.Text = "Consultar";
            findClientButton.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Toda la información", "Nombres", "Apellidos", "Dirección", "N. Celular", "Email", "Estado civil", "Fecha de nacimiento" });
            comboBox1.Location = new Point(80, 82);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(233, 28);
            comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 27);
            textBox1.TabIndex = 1;
            // 
            // Form_AgregarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 653);
            Controls.Add(clientesTabControl);
            Name = "Form_AgregarCliente";
            Text = "Form_AgregarCliente";
            Load += Form_AgregarCliente_Load;
            clientesTabControl.ResumeLayout(false);
            registrarTabPage.ResumeLayout(false);
            registrarTabPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl clientesTabControl;
        private TabPage registrarTabPage;
        private Label codeLabel;
        private TextBox txtBCedula;
        private Button button4;
        private Label personNameLabel;
        private Label comercialNameLabel;
        private TextBox txtBNombres;
        private TextBox txtBApellidos;
        private TextBox txtBEmail;
        private Label label8;
        private Label label7;
        private TextBox txtBDireccion;
        private Label label1;
        private TextBox txtBCelular;
        private Label label3;
        private Label label6;
        private TabPage tabPage3;
        private Button button8;
        private Label label25;
        private TextBox textBox28;
        private TabPage tabPage2;
        private Label label2;
        private Button findClientButton;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private ComboBox comboBEstadoCivil;
        private DateTimePicker dateTimePickerFechaNacimiento;
        private ComboBox comboBoxTipoPersona;
        private Label Tipo;
        private Label label5;
    }
}