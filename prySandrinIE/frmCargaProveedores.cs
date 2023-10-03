using System;
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
    public partial class frmCargaProveedores : Form
    {
        //declaracion de variables globales
        StreamReader objetoLectorArchivo;
        StreamWriter objetoEscribeArchivo;
        string rutaArchivo;

        string LeerLinea;
        string[] separadorTexto;
        public frmCargaProveedores()
        {
            InitializeComponent();
        }

        private void frmCargaProveedores_Load(object sender, EventArgs e)
        {
            DirectoryInfo informacionCarpetas = new DirectoryInfo(@"..\..");


            rutaArchivo =informacionCarpetas.FullName;

            rutaArchivo += "\\baseDatos\\Listado de aseguradores.csv";

            objetoLectorArchivo = new StreamReader(rutaArchivo);

            while (!objetoLectorArchivo.EndOfStream)
            {
                LeerLinea = objetoLectorArchivo.ReadLine();

                separadorTexto = LeerLinea.Split(';');

                //lblDatos.Text += objetoLectorArchivo.ReadLine();
                dgvDatos.Rows.Add(separadorTexto);
            }
            objetoLectorArchivo.Close();
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblNº.Text = "hizo doble click";

            txtN.Text = dgvDatos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtEntidad.Text = dgvDatos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtApertura.Text = dgvDatos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtExpte.Text = dgvDatos.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtJuzgado.Text = dgvDatos.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtJurisdiccion.Text = dgvDatos.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtDireccion.Text = dgvDatos.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtLiquidador.Text = dgvDatos.Rows[e.RowIndex].Cells[7].Value.ToString();


        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            DirectoryInfo informacionCarpetas = new DirectoryInfo(@"..\..");


            rutaArchivo = informacionCarpetas.FullName;

            rutaArchivo += "\\baseDatos\\ Listado de aseguradores.csv";

            objetoEscribeArchivo = new StreamWriter(rutaArchivo,true);

            objetoEscribeArchivo.WriteLine(txtN.Text + ";" +
                txtEntidad.Text + ";" + txtApertura.Text + ";" +
                txtExpte.Text + ";" + txtJuzgado.Text + ";" +
                txtJurisdiccion.Text + ";" + txtDireccion.Text + ";" +
                txtLiquidador.Text);

            objetoEscribeArchivo.Close();

            MessageBox.Show("Registro Realizado");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvDatos.Rows.Clear();
        }
    }
}
