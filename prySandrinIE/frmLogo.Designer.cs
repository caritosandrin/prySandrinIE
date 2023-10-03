namespace prySandrinIE
{
    partial class frmlogo
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
            this.components = new System.ComponentModel.Container();
            this.btniniciar = new System.Windows.Forms.Button();
            this.barraDeCarga = new System.Windows.Forms.ProgressBar();
            this.reloj = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btniniciar
            // 
            this.btniniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniniciar.Location = new System.Drawing.Point(140, 324);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(127, 38);
            this.btniniciar.TabIndex = 0;
            this.btniniciar.Text = "Iniciar Sistema";
            this.btniniciar.UseVisualStyleBackColor = true;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // barraDeCarga
            // 
            this.barraDeCarga.Location = new System.Drawing.Point(118, 387);
            this.barraDeCarga.Name = "barraDeCarga";
            this.barraDeCarga.Size = new System.Drawing.Size(170, 23);
            this.barraDeCarga.TabIndex = 1;
            this.barraDeCarga.Click += new System.EventHandler(this.barraDeCarga_Click);
            // 
            // reloj
            // 
            this.reloj.Enabled = true;
            this.reloj.Tick += new System.EventHandler(this.reloj_Tick);
            // 
            // frmlogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::prySandrinIE.Properties.Resources.LOGO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(438, 422);
            this.Controls.Add(this.barraDeCarga);
            this.Controls.Add(this.btniniciar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmlogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de gestion";
            this.Load += new System.EventHandler(this.frmlogo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.ProgressBar barraDeCarga;
        private System.Windows.Forms.Timer reloj;
    }
}

