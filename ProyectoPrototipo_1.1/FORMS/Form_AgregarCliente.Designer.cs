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
            this.clientesTabControl = new System.Windows.Forms.TabControl();
            this.registrarTabPage = new System.Windows.Forms.TabPage();
            this.comboBoxTipoPersona = new System.Windows.Forms.ComboBox();
            this.Tipo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBEstadoCivil = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.codeLabel = new System.Windows.Forms.Label();
            this.txtBCedula = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.personNameLabel = new System.Windows.Forms.Label();
            this.comercialNameLabel = new System.Windows.Forms.Label();
            this.txtBNombres = new System.Windows.Forms.TextBox();
            this.txtBApellidos = new System.Windows.Forms.TextBox();
            this.txtBEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBCelular = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.findClientButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clientesTabControl.SuspendLayout();
            this.registrarTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientesTabControl
            // 
            this.clientesTabControl.Controls.Add(this.registrarTabPage);
            this.clientesTabControl.Location = new System.Drawing.Point(187, 29);
            this.clientesTabControl.Name = "clientesTabControl";
            this.clientesTabControl.SelectedIndex = 0;
            this.clientesTabControl.Size = new System.Drawing.Size(426, 511);
            this.clientesTabControl.TabIndex = 43;
            // 
            // registrarTabPage
            // 
            this.registrarTabPage.Controls.Add(this.comboBoxTipoPersona);
            this.registrarTabPage.Controls.Add(this.Tipo);
            this.registrarTabPage.Controls.Add(this.label5);
            this.registrarTabPage.Controls.Add(this.comboBEstadoCivil);
            this.registrarTabPage.Controls.Add(this.dateTimePickerFechaNacimiento);
            this.registrarTabPage.Controls.Add(this.label17);
            this.registrarTabPage.Controls.Add(this.label18);
            this.registrarTabPage.Controls.Add(this.label19);
            this.registrarTabPage.Controls.Add(this.label20);
            this.registrarTabPage.Controls.Add(this.label21);
            this.registrarTabPage.Controls.Add(this.label22);
            this.registrarTabPage.Controls.Add(this.label23);
            this.registrarTabPage.Controls.Add(this.label24);
            this.registrarTabPage.Controls.Add(this.codeLabel);
            this.registrarTabPage.Controls.Add(this.txtBCedula);
            this.registrarTabPage.Controls.Add(this.button4);
            this.registrarTabPage.Controls.Add(this.personNameLabel);
            this.registrarTabPage.Controls.Add(this.comercialNameLabel);
            this.registrarTabPage.Controls.Add(this.txtBNombres);
            this.registrarTabPage.Controls.Add(this.txtBApellidos);
            this.registrarTabPage.Controls.Add(this.txtBEmail);
            this.registrarTabPage.Controls.Add(this.label8);
            this.registrarTabPage.Controls.Add(this.label7);
            this.registrarTabPage.Controls.Add(this.txtBDireccion);
            this.registrarTabPage.Controls.Add(this.label1);
            this.registrarTabPage.Controls.Add(this.txtBCelular);
            this.registrarTabPage.Controls.Add(this.label3);
            this.registrarTabPage.Controls.Add(this.label6);
            this.registrarTabPage.Location = new System.Drawing.Point(4, 29);
            this.registrarTabPage.Name = "registrarTabPage";
            this.registrarTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.registrarTabPage.Size = new System.Drawing.Size(418, 478);
            this.registrarTabPage.TabIndex = 0;
            this.registrarTabPage.Text = "Registrar";
            this.registrarTabPage.UseVisualStyleBackColor = true;
            // 
            // comboBoxTipoPersona
            // 
            this.comboBoxTipoPersona.FormattingEnabled = true;
            this.comboBoxTipoPersona.Items.AddRange(new object[] {
            "Persona Natural",
            "Persona Jurídica"});
            this.comboBoxTipoPersona.Location = new System.Drawing.Point(112, 76);
            this.comboBoxTipoPersona.Name = "comboBoxTipoPersona";
            this.comboBoxTipoPersona.Size = new System.Drawing.Size(151, 28);
            this.comboBoxTipoPersona.TabIndex = 53;
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Location = new System.Drawing.Point(11, 84);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(93, 20);
            this.Tipo.TabIndex = 52;
            this.Tipo.Text = "Nombres: (*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 50;
            // 
            // comboBEstadoCivil
            // 
            this.comboBEstadoCivil.FormattingEnabled = true;
            this.comboBEstadoCivil.Items.AddRange(new object[] {
            "Soltero(a)",
            "Casado(a)",
            "Divorciado(a)"});
            this.comboBEstadoCivil.Location = new System.Drawing.Point(112, 325);
            this.comboBEstadoCivil.Name = "comboBEstadoCivil";
            this.comboBEstadoCivil.Size = new System.Drawing.Size(151, 28);
            this.comboBEstadoCivil.TabIndex = 49;
            // 
            // dateTimePickerFechaNacimiento
            // 
            this.dateTimePickerFechaNacimiento.Location = new System.Drawing.Point(112, 373);
            this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            this.dateTimePickerFechaNacimiento.Size = new System.Drawing.Size(285, 27);
            this.dateTimePickerFechaNacimiento.TabIndex = 48;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(59, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 20);
            this.label17.TabIndex = 40;
            this.label17.Text = "CI: (*)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 133);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 20);
            this.label18.TabIndex = 41;
            this.label18.Text = "Nombres: (*)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 173);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 20);
            this.label19.TabIndex = 42;
            this.label19.Text = "Apellidos: (*)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(57, 291);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 20);
            this.label20.TabIndex = 45;
            this.label20.Text = "Email:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(31, 213);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 20);
            this.label21.TabIndex = 44;
            this.label21.Text = "Dirección:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(48, 253);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 20);
            this.label22.TabIndex = 46;
            this.label22.Text = "Celular:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 378);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(103, 20);
            this.label23.TabIndex = 47;
            this.label23.Text = "F. Nacimiento:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(17, 333);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(89, 20);
            this.label24.TabIndex = 43;
            this.label24.Text = "Estado Civil:";
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(66, 42);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(0, 20);
            this.codeLabel.TabIndex = 3;
            // 
            // txtBCedula
            // 
            this.txtBCedula.Location = new System.Drawing.Point(112, 31);
            this.txtBCedula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBCedula.Multiline = true;
            this.txtBCedula.Name = "txtBCedula";
            this.txtBCedula.Size = new System.Drawing.Size(165, 31);
            this.txtBCedula.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(163, 436);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 38);
            this.button4.TabIndex = 39;
            this.button4.Text = "Registrar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // personNameLabel
            // 
            this.personNameLabel.AutoSize = true;
            this.personNameLabel.Location = new System.Drawing.Point(18, 82);
            this.personNameLabel.Name = "personNameLabel";
            this.personNameLabel.Size = new System.Drawing.Size(0, 20);
            this.personNameLabel.TabIndex = 6;
            // 
            // comercialNameLabel
            // 
            this.comercialNameLabel.AutoSize = true;
            this.comercialNameLabel.Location = new System.Drawing.Point(17, 122);
            this.comercialNameLabel.Name = "comercialNameLabel";
            this.comercialNameLabel.Size = new System.Drawing.Size(0, 20);
            this.comercialNameLabel.TabIndex = 7;
            // 
            // txtBNombres
            // 
            this.txtBNombres.Location = new System.Drawing.Point(112, 122);
            this.txtBNombres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBNombres.Multiline = true;
            this.txtBNombres.Name = "txtBNombres";
            this.txtBNombres.Size = new System.Drawing.Size(285, 29);
            this.txtBNombres.TabIndex = 15;
            // 
            // txtBApellidos
            // 
            this.txtBApellidos.Location = new System.Drawing.Point(112, 162);
            this.txtBApellidos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBApellidos.Multiline = true;
            this.txtBApellidos.Name = "txtBApellidos";
            this.txtBApellidos.Size = new System.Drawing.Size(285, 29);
            this.txtBApellidos.TabIndex = 16;
            // 
            // txtBEmail
            // 
            this.txtBEmail.Location = new System.Drawing.Point(112, 282);
            this.txtBEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBEmail.Multiline = true;
            this.txtBEmail.Name = "txtBEmail";
            this.txtBEmail.Size = new System.Drawing.Size(285, 29);
            this.txtBEmail.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 9;
            // 
            // txtBDireccion
            // 
            this.txtBDireccion.Location = new System.Drawing.Point(112, 202);
            this.txtBDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBDireccion.Multiline = true;
            this.txtBDireccion.Name = "txtBDireccion";
            this.txtBDireccion.Size = new System.Drawing.Size(285, 29);
            this.txtBDireccion.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 19;
            // 
            // txtBCelular
            // 
            this.txtBCelular.Location = new System.Drawing.Point(112, 242);
            this.txtBCelular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBCelular.Multiline = true;
            this.txtBCelular.Name = "txtBCelular";
            this.txtBCelular.Size = new System.Drawing.Size(285, 29);
            this.txtBCelular.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(404, 436);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Compras";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(134, 102);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(114, 40);
            this.button8.TabIndex = 2;
            this.button8.Text = "Consultar";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(71, 64);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(25, 20);
            this.label25.TabIndex = 0;
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(93, 50);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(233, 27);
            this.textBox28.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(404, 436);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Datos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 0;
            // 
            // findClientButton
            // 
            this.findClientButton.Location = new System.Drawing.Point(137, 162);
            this.findClientButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.findClientButton.Name = "findClientButton";
            this.findClientButton.Size = new System.Drawing.Size(114, 40);
            this.findClientButton.TabIndex = 2;
            this.findClientButton.Text = "Consultar";
            this.findClientButton.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Toda la información",
            "Nombres",
            "Apellidos",
            "Dirección",
            "N. Celular",
            "Email",
            "Estado civil",
            "Fecha de nacimiento"});
            this.comboBox1.Location = new System.Drawing.Point(80, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 27);
            this.textBox1.TabIndex = 1;
            // 
            // Form_AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.clientesTabControl);
            this.Name = "Form_AgregarCliente";
            this.Text = "Form_AgregarCliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_AgregarCliente_FormClosed);
            this.Load += new System.EventHandler(this.Form_AgregarCliente_Load);
            this.clientesTabControl.ResumeLayout(false);
            this.registrarTabPage.ResumeLayout(false);
            this.registrarTabPage.PerformLayout();
            this.ResumeLayout(false);

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