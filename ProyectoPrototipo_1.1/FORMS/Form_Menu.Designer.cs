﻿namespace ProyectoPrototipo_1._0
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
            label1 = new Label();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            administraciónToolStripMenuItem = new ToolStripMenuItem();
            moduloProveedoresToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            comprasToolStripMenuItem = new ToolStripMenuItem();
            proveedoresToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesiónToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(37, 212);
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
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { administraciónToolStripMenuItem, moduloProveedoresToolStripMenuItem, ventasToolStripMenuItem, comprasToolStripMenuItem, proveedoresToolStripMenuItem, clientesToolStripMenuItem, cerrarSesiónToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1131, 30);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // administraciónToolStripMenuItem
            // 
            administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            administraciónToolStripMenuItem.Size = new Size(123, 24);
            administraciónToolStripMenuItem.Text = "Administración";
            administraciónToolStripMenuItem.Click += administraciónToolStripMenuItem_Click;
            // 
            // moduloProveedoresToolStripMenuItem
            // 
            moduloProveedoresToolStripMenuItem.Name = "moduloProveedoresToolStripMenuItem";
            moduloProveedoresToolStripMenuItem.Size = new Size(89, 24);
            moduloProveedoresToolStripMenuItem.Text = "Inventario";
            moduloProveedoresToolStripMenuItem.Click += moduloProveedoresToolStripMenuItem_Click;
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(66, 24);
            ventasToolStripMenuItem.Text = "Ventas";
            ventasToolStripMenuItem.Click += ventasToolStripMenuItem_Click;
            // 
            // comprasToolStripMenuItem
            // 
            comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            comprasToolStripMenuItem.Size = new Size(82, 24);
            comprasToolStripMenuItem.Text = "Compras";
            comprasToolStripMenuItem.Click += comprasToolStripMenuItem_Click;
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.Size = new Size(105, 24);
            proveedoresToolStripMenuItem.Text = "Proveedores";
            proveedoresToolStripMenuItem.Click += proveedoresToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(75, 24);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            cerrarSesiónToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            cerrarSesiónToolStripMenuItem.Size = new Size(108, 24);
            cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            cerrarSesiónToolStripMenuItem.Click += cerrarSesiónToolStripMenuItem_Click;
            // 
            // Form_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1131, 763);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlText;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_Menu";
            Text = "SISTEMA DE GESTIÓN PARA “FARMACY ECUADOR”";
            FormClosing += Form_Menu_FormClosing;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem moduloProveedoresToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem comprasToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem administraciónToolStripMenuItem;
        private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
    }
}

