using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySandrinIE
{
    public partial class FrmIniciarSesion : Form
    {
        
        
        clsBasedeDatos objAcceso = new clsBasedeDatos();

        Int32 IntentosFallidos = 0;

        private void btnConectar_Click(object sender, EventArgs e)
        {
             if (objAcceso.ValidarUsuarios(txtNombreUsuario.Text, txtContraseña.Text) == true)
            {
                frmLogo fb = new frmLogo();
                fb.ShowDialog();
                frmInicioSesion fin = new frmInicioSesion();
                fin.Close();
                IntentosFallidos = 0;
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña ingresada es incorrecta");
                txtNombreUsuario.Text = "";
                txtContraseña.Text = "";
                IntentosFallidos++;
                if (IntentosFallidos >= 3)
                {
                    btnIniciarSesion.Enabled = false;
                    MessageBox.Show("Alcanzó el límite máximo de intentos");
                }
            }
        }
            
           

        private void btnTraer_Click(object sender, EventArgs e)
        {

        }

        private void FrmIniciarSesion_Load(object sender, EventArgs e)
        {
            objAcceso.ConectarBaseDatos();
            txtContraseña.PasswordChar = '*';
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            frmRegistrarse fr = new frmRegistrarse();
            fr.ShowDialog();
        }
    }

    internal class frmInicioSesion
    {
        internal void Close()
        {
            throw new NotImplementedException();
        }
    }

    internal class frmLogo
    {
        public frmLogo()
        {
        }

        internal void ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}
