﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.IO;

namespace prySandrinIE
{
    public partial class frmListarProveedor : Form
    {

        public frmListarProveedor()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmListarProveedor_Load(object sender, EventArgs e)
        {
            // = new es instanciar un objeto de una clase
            StreamReader LeerArchivo = new StreamReader("datos proveedores,text");


            while (!LeerArchivo.EndOfStream) 
            {
                lblMostrar.Text += LeerArchivo.ReadLine();
            }
            LeerArchivo.Close();

        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
