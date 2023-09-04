namespace ProyectoPrototipo_1._1.FORMS
{
    partial class Form_AdministracionDelSistema
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
            TBCedulaUsuario = new TextBox();
            label22 = new Label();
            CBTipoUsuario = new ComboBox();
            label7 = new Label();
            label12 = new Label();
            BRegistrarUsuario = new Button();
            TBPasswordUsuario = new TextBox();
            label2 = new Label();
            TBNombreUsuario = new TextBox();
            label1 = new Label();
            tabPage8 = new TabPage();
            TBCedulaUConsultar = new TextBox();
            label6 = new Label();
            BConsultarUsuario = new Button();
            tabPage7 = new TabPage();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            label9 = new Label();
            BActualizarPass = new Button();
            TBPasswordActualizar = new TextBox();
            label11 = new Label();
            TBCedulaUActualizarPass = new TextBox();
            label13 = new Label();
            tabPage3 = new TabPage();
            CBActualizarTipo = new ComboBox();
            label8 = new Label();
            label10 = new Label();
            BActualizarTipo = new Button();
            TBCedulaUActualizarTipo = new TextBox();
            label15 = new Label();
            tabPage12 = new TabPage();
            TBResetearUsuario = new TextBox();
            label21 = new Label();
            BResetearUsuario = new Button();
            DGVUsuarios = new DataGridView();
            label3 = new Label();
            TCAdministracion = new TabControl();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            label4 = new Label();
            DGVParametros = new DataGridView();
            tabControl2 = new TabControl();
            tabPage6 = new TabPage();
            label5 = new Label();
            BRegistrarParametro = new Button();
            TBRegistrarValor = new TextBox();
            label14 = new Label();
            TBRegistrarParametro = new TextBox();
            label16 = new Label();
            tabPage9 = new TabPage();
            TBConsultarParametro = new TextBox();
            label17 = new Label();
            BConsultarParametro = new Button();
            tabPage10 = new TabPage();
            BActualizarParametro = new Button();
            TBActualizarValor = new TextBox();
            label18 = new Label();
            TBActualizarParametro = new TextBox();
            label19 = new Label();
            tabPage11 = new TabPage();
            TBEliminarParametro = new TextBox();
            label20 = new Label();
            BEliminarParametro = new Button();
            TCProveedores.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage8.SuspendLayout();
            tabPage7.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVUsuarios).BeginInit();
            TCAdministracion.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVParametros).BeginInit();
            tabControl2.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage9.SuspendLayout();
            tabPage10.SuspendLayout();
            tabPage11.SuspendLayout();
            SuspendLayout();
            // 
            // TCProveedores
            // 
            TCProveedores.Controls.Add(tabPage1);
            TCProveedores.Controls.Add(tabPage8);
            TCProveedores.Controls.Add(tabPage7);
            TCProveedores.Controls.Add(tabPage12);
            TCProveedores.Location = new Point(8, 8);
            TCProveedores.Margin = new Padding(3, 4, 3, 4);
            TCProveedores.Name = "TCProveedores";
            TCProveedores.SelectedIndex = 0;
            TCProveedores.Size = new Size(515, 320);
            TCProveedores.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.Controls.Add(TBCedulaUsuario);
            tabPage1.Controls.Add(label22);
            tabPage1.Controls.Add(CBTipoUsuario);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(BRegistrarUsuario);
            tabPage1.Controls.Add(TBPasswordUsuario);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(TBNombreUsuario);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(507, 287);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registrar Usuario";
            // 
            // TBCedulaUsuario
            // 
            TBCedulaUsuario.Location = new Point(165, 36);
            TBCedulaUsuario.Margin = new Padding(3, 4, 3, 4);
            TBCedulaUsuario.Name = "TBCedulaUsuario";
            TBCedulaUsuario.Size = new Size(169, 27);
            TBCedulaUsuario.TabIndex = 28;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(128, 39);
            label22.Name = "label22";
            label22.Size = new Size(28, 20);
            label22.TabIndex = 27;
            label22.Text = "C.I:";
            // 
            // CBTipoUsuario
            // 
            CBTipoUsuario.FormattingEnabled = true;
            CBTipoUsuario.Items.AddRange(new object[] { "Vendedor", "Administrador" });
            CBTipoUsuario.Location = new Point(165, 190);
            CBTipoUsuario.Name = "CBTipoUsuario";
            CBTipoUsuario.Size = new Size(169, 28);
            CBTipoUsuario.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 191);
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
            // BRegistrarUsuario
            // 
            BRegistrarUsuario.Location = new Point(374, 106);
            BRegistrarUsuario.Margin = new Padding(3, 4, 3, 4);
            BRegistrarUsuario.Name = "BRegistrarUsuario";
            BRegistrarUsuario.Size = new Size(88, 35);
            BRegistrarUsuario.TabIndex = 16;
            BRegistrarUsuario.Text = "Registrar";
            BRegistrarUsuario.UseVisualStyleBackColor = true;
            BRegistrarUsuario.Click += button4_Click;
            // 
            // TBPasswordUsuario
            // 
            TBPasswordUsuario.Location = new Point(165, 131);
            TBPasswordUsuario.Margin = new Padding(3, 4, 3, 4);
            TBPasswordUsuario.Name = "TBPasswordUsuario";
            TBPasswordUsuario.Size = new Size(169, 27);
            TBPasswordUsuario.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 139);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // TBNombreUsuario
            // 
            TBNombreUsuario.Location = new Point(165, 83);
            TBNombreUsuario.Margin = new Padding(3, 4, 3, 4);
            TBNombreUsuario.Name = "TBNombreUsuario";
            TBNombreUsuario.Size = new Size(169, 27);
            TBNombreUsuario.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 91);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // tabPage8
            // 
            tabPage8.Controls.Add(TBCedulaUConsultar);
            tabPage8.Controls.Add(label6);
            tabPage8.Controls.Add(BConsultarUsuario);
            tabPage8.Location = new Point(4, 29);
            tabPage8.Name = "tabPage8";
            tabPage8.Size = new Size(507, 287);
            tabPage8.TabIndex = 5;
            tabPage8.Text = "Consultar Usuario";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // TBCedulaUConsultar
            // 
            TBCedulaUConsultar.Location = new Point(133, 45);
            TBCedulaUConsultar.Margin = new Padding(3, 4, 3, 4);
            TBCedulaUConsultar.Name = "TBCedulaUConsultar";
            TBCedulaUConsultar.Size = new Size(169, 27);
            TBCedulaUConsultar.TabIndex = 54;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 51);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 53;
            label6.Text = "CI-Usuario:";
            // 
            // BConsultarUsuario
            // 
            BConsultarUsuario.Location = new Point(341, 41);
            BConsultarUsuario.Margin = new Padding(3, 4, 3, 4);
            BConsultarUsuario.Name = "BConsultarUsuario";
            BConsultarUsuario.Size = new Size(93, 35);
            BConsultarUsuario.TabIndex = 52;
            BConsultarUsuario.Text = "Consultar";
            BConsultarUsuario.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(tabControl1);
            tabPage7.Location = new Point(4, 29);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(507, 287);
            tabPage7.TabIndex = 4;
            tabPage7.Text = "Actualizar Usuario";
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
            tabControl1.Size = new Size(485, 245);
            tabControl1.TabIndex = 55;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(BActualizarPass);
            tabPage2.Controls.Add(TBPasswordActualizar);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(TBCedulaUActualizarPass);
            tabPage2.Controls.Add(label13);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(477, 212);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "Contraseña";
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
            // BActualizarPass
            // 
            BActualizarPass.Location = new Point(347, 75);
            BActualizarPass.Margin = new Padding(3, 4, 3, 4);
            BActualizarPass.Name = "BActualizarPass";
            BActualizarPass.Size = new Size(88, 35);
            BActualizarPass.TabIndex = 16;
            BActualizarPass.Text = "Actualizar";
            BActualizarPass.UseVisualStyleBackColor = true;
            // 
            // TBPasswordActualizar
            // 
            TBPasswordActualizar.Location = new Point(122, 83);
            TBPasswordActualizar.Margin = new Padding(3, 4, 3, 4);
            TBPasswordActualizar.Name = "TBPasswordActualizar";
            TBPasswordActualizar.Size = new Size(169, 27);
            TBPasswordActualizar.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(43, 87);
            label11.Name = "label11";
            label11.Size = new Size(73, 20);
            label11.TabIndex = 4;
            label11.Text = "Password:";
            // 
            // TBCedulaUActualizarPass
            // 
            TBCedulaUActualizarPass.Location = new Point(122, 35);
            TBCedulaUActualizarPass.Margin = new Padding(3, 4, 3, 4);
            TBCedulaUActualizarPass.Name = "TBCedulaUActualizarPass";
            TBCedulaUActualizarPass.Size = new Size(169, 27);
            TBCedulaUActualizarPass.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(88, 42);
            label13.Name = "label13";
            label13.Size = new Size(28, 20);
            label13.TabIndex = 2;
            label13.Text = "C.I:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(CBActualizarTipo);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(BActualizarTipo);
            tabPage3.Controls.Add(TBCedulaUActualizarTipo);
            tabPage3.Controls.Add(label15);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(477, 212);
            tabPage3.TabIndex = 4;
            tabPage3.Text = "Tipo de Usuario";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // CBActualizarTipo
            // 
            CBActualizarTipo.FormattingEnabled = true;
            CBActualizarTipo.Items.AddRange(new object[] { "Vendedor", "Administrador" });
            CBActualizarTipo.Location = new Point(153, 89);
            CBActualizarTipo.Name = "CBActualizarTipo";
            CBActualizarTipo.Size = new Size(169, 28);
            CBActualizarTipo.TabIndex = 57;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 94);
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
            // BActualizarTipo
            // 
            BActualizarTipo.Location = new Point(351, 85);
            BActualizarTipo.Margin = new Padding(3, 4, 3, 4);
            BActualizarTipo.Name = "BActualizarTipo";
            BActualizarTipo.Size = new Size(88, 35);
            BActualizarTipo.TabIndex = 54;
            BActualizarTipo.Text = "Actualizar";
            BActualizarTipo.UseVisualStyleBackColor = true;
            // 
            // TBCedulaUActualizarTipo
            // 
            TBCedulaUActualizarTipo.Location = new Point(151, 36);
            TBCedulaUActualizarTipo.Margin = new Padding(3, 4, 3, 4);
            TBCedulaUActualizarTipo.Name = "TBCedulaUActualizarTipo";
            TBCedulaUActualizarTipo.Size = new Size(169, 27);
            TBCedulaUActualizarTipo.TabIndex = 51;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(106, 39);
            label15.Name = "label15";
            label15.Size = new Size(28, 20);
            label15.TabIndex = 50;
            label15.Text = "C.I:";
            // 
            // tabPage12
            // 
            tabPage12.Controls.Add(TBResetearUsuario);
            tabPage12.Controls.Add(label21);
            tabPage12.Controls.Add(BResetearUsuario);
            tabPage12.Location = new Point(4, 29);
            tabPage12.Name = "tabPage12";
            tabPage12.Size = new Size(507, 287);
            tabPage12.TabIndex = 6;
            tabPage12.Text = "Resetear Usuario";
            tabPage12.UseVisualStyleBackColor = true;
            // 
            // TBResetearUsuario
            // 
            TBResetearUsuario.Location = new Point(133, 45);
            TBResetearUsuario.Margin = new Padding(3, 4, 3, 4);
            TBResetearUsuario.Name = "TBResetearUsuario";
            TBResetearUsuario.Size = new Size(169, 27);
            TBResetearUsuario.TabIndex = 54;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(50, 51);
            label21.Name = "label21";
            label21.Size = new Size(81, 20);
            label21.TabIndex = 53;
            label21.Text = "CI-Usuario:";
            // 
            // BResetearUsuario
            // 
            BResetearUsuario.Location = new Point(341, 41);
            BResetearUsuario.Margin = new Padding(3, 4, 3, 4);
            BResetearUsuario.Name = "BResetearUsuario";
            BResetearUsuario.Size = new Size(93, 35);
            BResetearUsuario.TabIndex = 52;
            BResetearUsuario.Text = "Eliminar";
            BResetearUsuario.UseVisualStyleBackColor = true;
            // 
            // DGVUsuarios
            // 
            DGVUsuarios.BackgroundColor = Color.White;
            DGVUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVUsuarios.Location = new Point(526, 37);
            DGVUsuarios.Margin = new Padding(3, 4, 3, 4);
            DGVUsuarios.Name = "DGVUsuarios";
            DGVUsuarios.RowHeadersWidth = 51;
            DGVUsuarios.RowTemplate.Height = 24;
            DGVUsuarios.Size = new Size(290, 389);
            DGVUsuarios.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(526, 15);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 3;
            label3.Text = "Tabla de Usuarios";
            // 
            // TCAdministracion
            // 
            TCAdministracion.Controls.Add(tabPage4);
            TCAdministracion.Controls.Add(tabPage5);
            TCAdministracion.Location = new Point(0, -3);
            TCAdministracion.Margin = new Padding(3, 4, 3, 4);
            TCAdministracion.Name = "TCAdministracion";
            TCAdministracion.SelectedIndex = 0;
            TCAdministracion.Size = new Size(891, 580);
            TCAdministracion.TabIndex = 4;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(TCProveedores);
            tabPage4.Controls.Add(label3);
            tabPage4.Controls.Add(DGVUsuarios);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(3, 4, 3, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 4, 3, 4);
            tabPage4.Size = new Size(883, 547);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "Administración de Usuarios";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(label4);
            tabPage5.Controls.Add(DGVParametros);
            tabPage5.Controls.Add(tabControl2);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Margin = new Padding(3, 4, 3, 4);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3, 4, 3, 4);
            tabPage5.Size = new Size(883, 547);
            tabPage5.TabIndex = 1;
            tabPage5.Text = "Administración de Parámetros";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(612, 8);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 8;
            label4.Text = "Tabla de Parámetros";
            // 
            // DGVParametros
            // 
            DGVParametros.BackgroundColor = Color.White;
            DGVParametros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVParametros.Location = new Point(612, 32);
            DGVParametros.Margin = new Padding(3, 4, 3, 4);
            DGVParametros.Name = "DGVParametros";
            DGVParametros.RowHeadersWidth = 51;
            DGVParametros.RowTemplate.Height = 24;
            DGVParametros.Size = new Size(262, 431);
            DGVParametros.TabIndex = 7;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage6);
            tabControl2.Controls.Add(tabPage9);
            tabControl2.Controls.Add(tabPage10);
            tabControl2.Controls.Add(tabPage11);
            tabControl2.Location = new Point(0, 8);
            tabControl2.Margin = new Padding(3, 4, 3, 4);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(606, 308);
            tabControl2.TabIndex = 6;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(label5);
            tabPage6.Controls.Add(BRegistrarParametro);
            tabPage6.Controls.Add(TBRegistrarValor);
            tabPage6.Controls.Add(label14);
            tabPage6.Controls.Add(TBRegistrarParametro);
            tabPage6.Controls.Add(label16);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Margin = new Padding(3, 4, 3, 4);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3, 4, 3, 4);
            tabPage6.Size = new Size(598, 275);
            tabPage6.TabIndex = 0;
            tabPage6.Text = "Registrar Parámetro";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(599, 97);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 24;
            // 
            // BRegistrarParametro
            // 
            BRegistrarParametro.Location = new Point(216, 148);
            BRegistrarParametro.Margin = new Padding(3, 4, 3, 4);
            BRegistrarParametro.Name = "BRegistrarParametro";
            BRegistrarParametro.Size = new Size(88, 35);
            BRegistrarParametro.TabIndex = 16;
            BRegistrarParametro.Text = "Registrar";
            BRegistrarParametro.UseVisualStyleBackColor = true;
            // 
            // TBRegistrarValor
            // 
            TBRegistrarValor.Location = new Point(190, 96);
            TBRegistrarValor.Margin = new Padding(3, 4, 3, 4);
            TBRegistrarValor.Name = "TBRegistrarValor";
            TBRegistrarValor.Size = new Size(169, 27);
            TBRegistrarValor.TabIndex = 8;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(142, 107);
            label14.Name = "label14";
            label14.Size = new Size(46, 20);
            label14.TabIndex = 4;
            label14.Text = "Valor:";
            // 
            // TBRegistrarParametro
            // 
            TBRegistrarParametro.Location = new Point(190, 48);
            TBRegistrarParametro.Margin = new Padding(3, 4, 3, 4);
            TBRegistrarParametro.Name = "TBRegistrarParametro";
            TBRegistrarParametro.Size = new Size(169, 27);
            TBRegistrarParametro.TabIndex = 3;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(107, 55);
            label16.Name = "label16";
            label16.Size = new Size(80, 20);
            label16.TabIndex = 2;
            label16.Text = "Parámetro:";
            // 
            // tabPage9
            // 
            tabPage9.Controls.Add(TBConsultarParametro);
            tabPage9.Controls.Add(label17);
            tabPage9.Controls.Add(BConsultarParametro);
            tabPage9.Location = new Point(4, 29);
            tabPage9.Name = "tabPage9";
            tabPage9.Padding = new Padding(3);
            tabPage9.Size = new Size(598, 275);
            tabPage9.TabIndex = 6;
            tabPage9.Text = "Consultar Parámetro";
            tabPage9.UseVisualStyleBackColor = true;
            // 
            // TBConsultarParametro
            // 
            TBConsultarParametro.Location = new Point(139, 44);
            TBConsultarParametro.Margin = new Padding(3, 4, 3, 4);
            TBConsultarParametro.Name = "TBConsultarParametro";
            TBConsultarParametro.Size = new Size(169, 27);
            TBConsultarParametro.TabIndex = 57;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(57, 49);
            label17.Name = "label17";
            label17.Size = new Size(80, 20);
            label17.TabIndex = 56;
            label17.Text = "Parámetro:";
            // 
            // BConsultarParametro
            // 
            BConsultarParametro.Location = new Point(336, 40);
            BConsultarParametro.Margin = new Padding(3, 4, 3, 4);
            BConsultarParametro.Name = "BConsultarParametro";
            BConsultarParametro.Size = new Size(93, 35);
            BConsultarParametro.TabIndex = 55;
            BConsultarParametro.Text = "Consultar";
            BConsultarParametro.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            tabPage10.Controls.Add(BActualizarParametro);
            tabPage10.Controls.Add(TBActualizarValor);
            tabPage10.Controls.Add(label18);
            tabPage10.Controls.Add(TBActualizarParametro);
            tabPage10.Controls.Add(label19);
            tabPage10.Location = new Point(4, 29);
            tabPage10.Name = "tabPage10";
            tabPage10.Padding = new Padding(3);
            tabPage10.Size = new Size(598, 275);
            tabPage10.TabIndex = 4;
            tabPage10.Text = "Actualizar Parámetro";
            tabPage10.UseVisualStyleBackColor = true;
            // 
            // BActualizarParametro
            // 
            BActualizarParametro.Location = new Point(217, 156);
            BActualizarParametro.Margin = new Padding(3, 4, 3, 4);
            BActualizarParametro.Name = "BActualizarParametro";
            BActualizarParametro.Size = new Size(88, 35);
            BActualizarParametro.TabIndex = 21;
            BActualizarParametro.Text = "Actualizar";
            BActualizarParametro.UseVisualStyleBackColor = true;
            // 
            // TBActualizarValor
            // 
            TBActualizarValor.Location = new Point(191, 104);
            TBActualizarValor.Margin = new Padding(3, 4, 3, 4);
            TBActualizarValor.Name = "TBActualizarValor";
            TBActualizarValor.Size = new Size(169, 27);
            TBActualizarValor.TabIndex = 20;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(143, 113);
            label18.Name = "label18";
            label18.Size = new Size(46, 20);
            label18.TabIndex = 19;
            label18.Text = "Valor:";
            // 
            // TBActualizarParametro
            // 
            TBActualizarParametro.Location = new Point(191, 56);
            TBActualizarParametro.Margin = new Padding(3, 4, 3, 4);
            TBActualizarParametro.Name = "TBActualizarParametro";
            TBActualizarParametro.Size = new Size(169, 27);
            TBActualizarParametro.TabIndex = 18;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(109, 61);
            label19.Name = "label19";
            label19.Size = new Size(80, 20);
            label19.TabIndex = 17;
            label19.Text = "Parámetro:";
            // 
            // tabPage11
            // 
            tabPage11.Controls.Add(TBEliminarParametro);
            tabPage11.Controls.Add(label20);
            tabPage11.Controls.Add(BEliminarParametro);
            tabPage11.Location = new Point(4, 29);
            tabPage11.Name = "tabPage11";
            tabPage11.Size = new Size(598, 275);
            tabPage11.TabIndex = 5;
            tabPage11.Text = "Eliminar Parámetro";
            tabPage11.UseVisualStyleBackColor = true;
            // 
            // TBEliminarParametro
            // 
            TBEliminarParametro.Location = new Point(139, 44);
            TBEliminarParametro.Margin = new Padding(3, 4, 3, 4);
            TBEliminarParametro.Name = "TBEliminarParametro";
            TBEliminarParametro.Size = new Size(169, 27);
            TBEliminarParametro.TabIndex = 54;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(54, 47);
            label20.Name = "label20";
            label20.Size = new Size(80, 20);
            label20.TabIndex = 53;
            label20.Text = "Parámetro:";
            // 
            // BEliminarParametro
            // 
            BEliminarParametro.Location = new Point(336, 40);
            BEliminarParametro.Margin = new Padding(3, 4, 3, 4);
            BEliminarParametro.Name = "BEliminarParametro";
            BEliminarParametro.Size = new Size(93, 35);
            BEliminarParametro.TabIndex = 52;
            BEliminarParametro.Text = "Eliminar";
            BEliminarParametro.UseVisualStyleBackColor = true;
            // 
            // Form_AdministracionDelSistema
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1760, 1055);
            ControlBox = false;
            Controls.Add(TCAdministracion);
            Name = "Form_AdministracionDelSistema";
            Text = "Administración del Sistema";
            Load += Form_Administracion_Load;
            TCProveedores.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage8.ResumeLayout(false);
            tabPage8.PerformLayout();
            tabPage7.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage12.ResumeLayout(false);
            tabPage12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVUsuarios).EndInit();
            TCAdministracion.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVParametros).EndInit();
            tabControl2.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            tabPage9.ResumeLayout(false);
            tabPage9.PerformLayout();
            tabPage10.ResumeLayout(false);
            tabPage10.PerformLayout();
            tabPage11.ResumeLayout(false);
            tabPage11.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TCProveedores;
        private TabPage tabPage1;
        private Label label12;
        private Button BRegistrarUsuario;
        private TextBox TBPasswordUsuario;
        private Label label2;
        private TextBox TBNombreUsuario;
        private Label label1;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private Button BConsultarUsuario;
        private DataGridView DGVUsuarios;
        private TextBox TBCedulaUConsultar;
        private Label label6;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private Label label9;
        private Button BActualizarPass;
        private TextBox TBPasswordActualizar;
        private Label label11;
        private TextBox TBCedulaUActualizarPass;
        private Label label13;
        private TabPage tabPage3;
        private Button BActualizarTipo;
        private TextBox TBCedulaUActualizarTipo;
        private Label label15;
        private ComboBox CBTipoUsuario;
        private Label label7;
        private ComboBox CBActualizarTipo;
        private Label label8;
        private Label label10;
        private Label label3;
        private TabControl TCAdministracion;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Label label4;
        private DataGridView DGVParametros;
        private TabControl tabControl2;
        private TabPage tabPage6;
        private Label label5;
        private Button BRegistrarParametro;
        private TextBox TBRegistrarValor;
        private Label label14;
        private TextBox TBRegistrarParametro;
        private Label label16;
        private TabPage tabPage9;
        private TextBox TBConsultarParametro;
        private Label label17;
        private Button BConsultarParametro;
        private TabPage tabPage10;
        private Button BActualizarParametro;
        private TextBox TBActualizarValor;
        private Label label18;
        private TextBox TBActualizarParametro;
        private Label label19;
        private TabPage tabPage11;
        private TextBox TBEliminarParametro;
        private Label label20;
        private Button BEliminarParametro;
        private TabPage tabPage12;
        private TextBox TBResetearUsuario;
        private Label label21;
        private Button BResetearUsuario;
        private TextBox TBCedulaUsuario;
        private Label label22;
    }
}