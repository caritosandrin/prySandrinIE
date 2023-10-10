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
using System.Xml.Linq;

namespace prySandrinIE
{
    public partial class FrmRegistroProveedorSeguro : Form
    {
        public FrmRegistroProveedorSeguro()
        {
            InitializeComponent();

        }
        private void CargarTreeView(string rutaCarpetaRaiz, string nombreCarpeta)
        {
            treeView1.Nodes.Clear();

            rutaCarpetaRaiz = rutaCarpetaRaiz + "\\Proveedor";

            if (Directory.Exists(rutaCarpetaRaiz))
            {
                TreeNode nodoRaiz = new TreeNode("Proveedor");
                treeView1.Nodes.Add(nodoRaiz);
                TraerSubCarpetas(rutaCarpetaRaiz, nodoRaiz);
                TraerArchivos(rutaCarpetaRaiz, nodoRaiz);
            }
        }
        private void TraerSubCarpetas(string ruta, TreeNode nodoRaiz)
        {
            try
            {
                string[] subCarpetas = Directory.GetDirectories(ruta);

                foreach (string subDirectorio in subCarpetas)
                {
                    TreeNode node = new TreeNode(Path.GetFileName(subDirectorio));
                    nodoRaiz.Nodes.Add(node);

                    //recursiva- se llama a si mismo para ver si hay màs carpetas
                    //buscar sub carpetas
                    TraerSubCarpetas(subDirectorio, node);
                    TraerArchivos(subDirectorio, node);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void TraerArchivos(string ruta, TreeNode nodoRaiz)
        {
            string[] archivos = Directory.GetFiles(ruta);

            foreach (string archivo in archivos)
            {
                TreeNode nodoArchivo = new TreeNode(Path.GetFileName(archivo));
                nodoRaiz.Nodes.Add(nodoArchivo);
            }

        }

        private void lblContenido_Click(object sender, EventArgs e)
        {

        }

        private void FrmRegistroProveedorSeguro_Load(object sender, EventArgs e)
        {
            DirectoryInfo info = new DirectoryInfo(@"../..");
            CargarTreeView(info.FullName, info.Name);
        }
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
           

        }
        private void btnTreeNivel1_Click(object sender, EventArgs e)
        {
            //una direcciòn estàtica de carpeta
            DirectoryInfo info = new DirectoryInfo("C:\\Users\\Alumno\\source\\repos\\prySandrinIE\\prySandrinIE\\Proveedor\\Proveedores");

            CargarTreeView(info.FullName, info.Name);
        }

        private void btnNivel2_Click(object sender, EventArgs e)
        {
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_NodeMouseDoubleClick_1(object sender, TreeNodeMouseClickEventArgs e)
        {
            lblMostrar.Text = "";

            try
            {
                DirectoryInfo info = new DirectoryInfo(@"../..");

                string rutaArchivo = info.FullName + "\\" + e.Node.FullPath;

                StreamReader lectorArchivos = new StreamReader(rutaArchivo);

                if (lectorArchivos != null)
                {
                    while (!lectorArchivos.EndOfStream)
                    {
                        lblMostrar.Text += lectorArchivos.ReadLine();
                    }
                }

                lectorArchivos.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
