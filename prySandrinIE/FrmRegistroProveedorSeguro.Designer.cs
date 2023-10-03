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
            this.lblContenido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTreeNivel1
            // 
            this.btnTreeNivel1.Location = new System.Drawing.Point(60, 13);
            this.btnTreeNivel1.Name = "btnTreeNivel1";
            this.btnTreeNivel1.Size = new System.Drawing.Size(75, 23);
            this.btnTreeNivel1.TabIndex = 0;
            this.btnTreeNivel1.Text = "Nivel 1";
            this.btnTreeNivel1.UseVisualStyleBackColor = true;
            this.btnTreeNivel1.Click += new System.EventHandler(this.btnTreeNivel1_Click);
            // 
            // btnNivel2
            // 
            this.btnNivel2.Location = new System.Drawing.Point(60, 58);
            this.btnNivel2.Name = "btnNivel2";
            this.btnNivel2.Size = new System.Drawing.Size(75, 23);
            this.btnNivel2.TabIndex = 1;
            this.btnNivel2.Text = "Nivel 2";
            this.btnNivel2.UseVisualStyleBackColor = true;
            this.btnNivel2.Click += new System.EventHandler(this.btnNivel2_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(29, 120);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(189, 214);
            this.treeView1.TabIndex = 2;
            // 
            // lblContenido
            // 
            this.lblContenido.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblContenido.Location = new System.Drawing.Point(280, 13);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(290, 363);
            this.lblContenido.TabIndex = 3;
            this.lblContenido.Click += new System.EventHandler(this.lblContenido_Click);
            // 
            // FrmRegistroProveedorSeguro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.lblContenido);
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
        private System.Windows.Forms.Label lblContenido;
    }
}