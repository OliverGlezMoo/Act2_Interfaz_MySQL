namespace Act2_Interfaz_MySQL
{
    partial class Act2_Interfaz_MySQL
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
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.TxtHost = new System.Windows.Forms.TextBox();
            this.TxtBD = new System.Windows.Forms.TextBox();
            this.TxtPuerto = new System.Windows.Forms.TextBox();
            this.DgvDatos = new System.Windows.Forms.DataGridView();
            this.BtnConectar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(41, 42);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(146, 20);
            this.TxtUsuario.TabIndex = 0;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Location = new System.Drawing.Point(41, 68);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(146, 20);
            this.TxtContraseña.TabIndex = 1;
            this.TxtContraseña.TextChanged += new System.EventHandler(this.TxtContraseña_TextChanged);
            // 
            // TxtHost
            // 
            this.TxtHost.Location = new System.Drawing.Point(41, 94);
            this.TxtHost.Name = "TxtHost";
            this.TxtHost.Size = new System.Drawing.Size(146, 20);
            this.TxtHost.TabIndex = 2;
            // 
            // TxtBD
            // 
            this.TxtBD.Location = new System.Drawing.Point(41, 120);
            this.TxtBD.Name = "TxtBD";
            this.TxtBD.Size = new System.Drawing.Size(146, 20);
            this.TxtBD.TabIndex = 3;
            // 
            // TxtPuerto
            // 
            this.TxtPuerto.Location = new System.Drawing.Point(41, 146);
            this.TxtPuerto.Name = "TxtPuerto";
            this.TxtPuerto.Size = new System.Drawing.Size(146, 20);
            this.TxtPuerto.TabIndex = 4;
            // 
            // DgvDatos
            // 
            this.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDatos.Location = new System.Drawing.Point(193, 42);
            this.DgvDatos.Name = "DgvDatos";
            this.DgvDatos.Size = new System.Drawing.Size(459, 166);
            this.DgvDatos.TabIndex = 5;
            // 
            // BtnConectar
            // 
            this.BtnConectar.Location = new System.Drawing.Point(41, 172);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(146, 36);
            this.BtnConectar.TabIndex = 6;
            this.BtnConectar.Text = "Conectar";
            this.BtnConectar.UseVisualStyleBackColor = true;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click_1);
            // 
            // Act2_Interfaz_MySQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 254);
            this.Controls.Add(this.BtnConectar);
            this.Controls.Add(this.DgvDatos);
            this.Controls.Add(this.TxtPuerto);
            this.Controls.Add(this.TxtBD);
            this.Controls.Add(this.TxtHost);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.TxtUsuario);
            this.Name = "Act2_Interfaz_MySQL";
            this.Text = "Act2_Interfaz_MySQL";
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.TextBox TxtHost;
        private System.Windows.Forms.TextBox TxtBD;
        private System.Windows.Forms.TextBox TxtPuerto;
        private System.Windows.Forms.DataGridView DgvDatos;
        private System.Windows.Forms.Button BtnConectar;
    }
}

