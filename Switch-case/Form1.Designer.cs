namespace Switch_case
{
    partial class FRMSwitch
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtCodigoInserido = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.BTNEnviar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.BTNEnviar);
            this.panel1.Controls.Add(this.lblDescricao);
            this.panel1.Controls.Add(this.txtCodigoInserido);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Moccasin;
            this.lblTitulo.Location = new System.Drawing.Point(262, 57);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(263, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Insira o código de 1 a 6";
            // 
            // txtCodigoInserido
            // 
            this.txtCodigoInserido.BackColor = System.Drawing.Color.Moccasin;
            this.txtCodigoInserido.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoInserido.Location = new System.Drawing.Point(304, 109);
            this.txtCodigoInserido.Name = "txtCodigoInserido";
            this.txtCodigoInserido.Size = new System.Drawing.Size(152, 33);
            this.txtCodigoInserido.TabIndex = 1;
            this.txtCodigoInserido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDescricao
            // 
            this.lblDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescricao.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(304, 159);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(152, 35);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTNEnviar
            // 
            this.BTNEnviar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BTNEnviar.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.BTNEnviar.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEnviar.ForeColor = System.Drawing.Color.Moccasin;
            this.BTNEnviar.Location = new System.Drawing.Point(331, 220);
            this.BTNEnviar.Name = "BTNEnviar";
            this.BTNEnviar.Size = new System.Drawing.Size(98, 35);
            this.BTNEnviar.TabIndex = 3;
            this.BTNEnviar.Text = "Enviar";
            this.BTNEnviar.UseVisualStyleBackColor = false;
            this.BTNEnviar.Click += new System.EventHandler(this.BTNEnviar_Click);
            // 
            // FRMSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FRMSwitch";
            this.Text = "Condicional Switch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtCodigoInserido;
        private System.Windows.Forms.Button BTNEnviar;
    }
}

