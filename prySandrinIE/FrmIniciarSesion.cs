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
        public FrmIniciarSesion()
        {
            InitializeComponent();
        }
        

        private void btnConectar_Click(object sender, EventArgs e)
        {
            //Declaraciòn de variable y objetos globales
            OleDbConnection conexionBD = new OleDbConnection();
            OleDbCommand comandarBD = new OleDbCommand();
            OleDbDataReader BDDataReader;


            string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source="+@"../../BaseDatos.accdb";

            conexionBD.ConnectionString = cadenaConexion;
            conexionBD.Open();
            
            comandarBD.Connection = conexionBD;
            comandarBD.CommandType = CommandType.TableDirect;
            comandarBD.CommandText = "Users";

            BDDataReader = comandarBD.ExecuteReader();

            while (BDDataReader.Read())
            {
                if (BDDataReader[1].ToString()==txtUsuario.Text)
                {
                    MessageBox.Show("encontras");
                }
            }
        }

        private void btnTraer_Click(object sender, EventArgs e)
        {

        }

        private void FrmIniciarSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
