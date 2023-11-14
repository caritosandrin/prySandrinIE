namespace prySandrinIE
{
    partial class FrmRegistroProveedorSeguro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroProveedorSeguro));
            this.btnTreeNivel1 = new System.Windows.Forms.Button();
            this.btnNivel2 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTreeNivel1
            // 
            this.btnTreeNivel1.Location = new System.Drawing.Point(12, 83);
            this.btnTreeNivel1.Name = "btnTreeNivel1";
            this.btnTreeNivel1.Size = new System.Drawing.Size(108, 23);
            this.btnTreeNivel1.TabIndex = 0;
            this.btnTreeNivel1.Text = "Ocultar Carpetas";
            this.btnTreeNivel1.UseVisualStyleBackColor = true;
            this.btnTreeNivel1.Click += new System.EventHandler(this.btnTreeNivel1_Click);
            // 
            // btnNivel2
            // 
            this.btnNivel2.Location = new System.Drawing.Point(12, 35);
            this.btnNivel2.Name = "btnNivel2";
            this.btnNivel2.Size = new System.Drawing.Size(108, 23);
            this.btnNivel2.TabIndex = 1;
            this.btnNivel2.Text = "Mostrar Carpetas";
            this.btnNivel2.UseVisualStyleBackColor = true;
            this.btnNivel2.Click += new System.EventHandler(this.btnNivel2_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 147);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(210, 258);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick_1);
            // 
            // lblMostrar
            // 
            this.lblMostrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblMostrar.Location = new System.Drawing.Point(344, 9);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(290, 365);
            this.lblMostrar.TabIndex = 3;
            this.lblMostrar.Click += new System.EventHandler(this.lblContenido_Click);
            // 
            // FrmRegistroProveedorSeguro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnNivel2);
            this.Controls.Add(this.btnTreeNivel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegistroProveedorSeguro";
            this.Text = "Registro De Proveedores De Seguro";
            this.Load += new System.EventHandler(this.FrmRegistroProveedorSeguro_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTreeNivel1;
        private System.Windows.Forms.Button btnNivel2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label lblMostrar;
    }
}