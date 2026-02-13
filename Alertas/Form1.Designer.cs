namespace Alertas
{
    partial class Alertas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBLTitulo = new System.Windows.Forms.Label();
            this.BTNAlertasimples = new System.Windows.Forms.Button();
            this.btnAlertaRobustu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLTitulo
            // 
            this.LBLTitulo.AutoSize = true;
            this.LBLTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTitulo.Location = new System.Drawing.Point(228, 81);
            this.LBLTitulo.Name = "LBLTitulo";
            this.LBLTitulo.Size = new System.Drawing.Size(198, 31);
            this.LBLTitulo.TabIndex = 0;
            this.LBLTitulo.Text = "Testo de Alerta";
            // 
            // BTNAlertasimples
            // 
            this.BTNAlertasimples.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(103)))), ((int)(((byte)(86)))));
            this.BTNAlertasimples.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAlertasimples.ForeColor = System.Drawing.Color.White;
            this.BTNAlertasimples.Location = new System.Drawing.Point(273, 126);
            this.BTNAlertasimples.Name = "BTNAlertasimples";
            this.BTNAlertasimples.Size = new System.Drawing.Size(123, 45);
            this.BTNAlertasimples.TabIndex = 1;
            this.BTNAlertasimples.Text = "Alerta Simples";
            this.BTNAlertasimples.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNAlertasimples.UseVisualStyleBackColor = false;
            this.BTNAlertasimples.Click += new System.EventHandler(this.BTNAlertasimples_Click);
            // 
            // btnAlertaRobustu
            // 
            this.btnAlertaRobustu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAlertaRobustu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlertaRobustu.FlatAppearance.BorderSize = 0;
            this.btnAlertaRobustu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAlertaRobustu.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlertaRobustu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAlertaRobustu.Location = new System.Drawing.Point(273, 177);
            this.btnAlertaRobustu.Name = "btnAlertaRobustu";
            this.btnAlertaRobustu.Size = new System.Drawing.Size(123, 47);
            this.btnAlertaRobustu.TabIndex = 2;
            this.btnAlertaRobustu.Text = "Alerta Robusto";
            this.btnAlertaRobustu.UseVisualStyleBackColor = false;
            this.btnAlertaRobustu.Click += new System.EventHandler(this.btnAlertaRobustu_Click);
            // 
            // Alertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.btnAlertaRobustu);
            this.Controls.Add(this.BTNAlertasimples);
            this.Controls.Add(this.LBLTitulo);
            this.Name = "Alertas";
            this.Text = "Alertas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLTitulo;
        private System.Windows.Forms.Button BTNAlertasimples;
        private System.Windows.Forms.Button btnAlertaRobustu;
    }
}

