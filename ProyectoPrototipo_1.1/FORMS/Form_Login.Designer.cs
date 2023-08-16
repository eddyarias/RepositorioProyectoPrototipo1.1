namespace ProyectoPrototipo_1._0
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            BLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            TBUsername = new TextBox();
            TBPassword = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BLogin
            // 
            BLogin.BackColor = SystemColors.ButtonFace;
            BLogin.Image = (Image)resources.GetObject("BLogin.Image");
            BLogin.Location = new Point(59, 190);
            BLogin.Margin = new Padding(3, 4, 3, 4);
            BLogin.Name = "BLogin";
            BLogin.Size = new Size(190, 69);
            BLogin.TabIndex = 0;
            BLogin.UseVisualStyleBackColor = false;
            BLogin.Click += BLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 56);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 125);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // TBUsername
            // 
            TBUsername.Location = new Point(114, 52);
            TBUsername.Margin = new Padding(3, 4, 3, 4);
            TBUsername.Name = "TBUsername";
            TBUsername.Size = new Size(160, 27);
            TBUsername.TabIndex = 3;
            // 
            // TBPassword
            // 
            TBPassword.Location = new Point(114, 118);
            TBPassword.Margin = new Padding(3, 4, 3, 4);
            TBPassword.Name = "TBPassword";
            TBPassword.PasswordChar = '*';
            TBPassword.Size = new Size(160, 27);
            TBPassword.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 9);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 299);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(TBUsername);
            panel1.Controls.Add(BLogin);
            panel1.Controls.Add(TBPassword);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(274, 9);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 298);
            panel1.TabIndex = 6;
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(578, 318);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_Login";
            Text = "Autenticación";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BLogin;
        private Label label1;
        private Label label2;
        private TextBox TBUsername;
        private TextBox TBPassword;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}