using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace prySandrinIE
{
    public partial class frmlogo : Form
    {
        public frmlogo()
        {
            InitializeComponent();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {

            this.Hide();

            frmPrincipal frm = new frmPrincipal();
            frm.Show();
                
            
        }

        private void barraDeCarga_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void reloj_Tick(object sender, EventArgs e)
        {
            if (barraDeCarga.Value ==100)
            {
                //apago el reloj 
                reloj.Enabled = false;
                this.Hide();
                frmPrincipal venta = new frmPrincipal();
                venta.ShowDialog();
                    
            }
            else
            {
                barraDeCarga.Value += 5;
                    
            }

        }

        private void frmlogo_Load(object sender, EventArgs e)
        {

        }
    }
}
    

