﻿using Microsoft.EntityFrameworkCore;
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
    public partial class Form_Clientes : Form
    {
        private FarmaciaDbContext dbContext;
        public Form_Clientes()
        {
            dbContext = new FarmaciaDbContext();
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        private void Form_Clientes_Load_1(object sender, EventArgs e)
        {
            dbContext.Cliente.Load();
            dataGridView1.DataSource = dbContext.Cliente.Local.ToBindingList();
            dbContext.SaveChanges();
        }

        private void registrarTabPage_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
