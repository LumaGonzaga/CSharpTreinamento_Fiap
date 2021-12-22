namespace VetorInverso
{
    partial class Form1
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
            this.tbnIniciar = new System.Windows.Forms.Button();
            this.lstVetorB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbnIniciar
            // 
            this.tbnIniciar.Location = new System.Drawing.Point(91, 43);
            this.tbnIniciar.Name = "tbnIniciar";
            this.tbnIniciar.Size = new System.Drawing.Size(108, 47);
            this.tbnIniciar.TabIndex = 0;
            this.tbnIniciar.Text = "Iniciar";
            this.tbnIniciar.UseVisualStyleBackColor = true;
            this.tbnIniciar.Click += new System.EventHandler(this.tbnIniciar_Click);
            // 
            // lstVetorB
            // 
            this.lstVetorB.FormattingEnabled = true;
            this.lstVetorB.ItemHeight = 20;
            this.lstVetorB.Location = new System.Drawing.Point(43, 129);
            this.lstVetorB.Name = "lstVetorB";
            this.lstVetorB.Size = new System.Drawing.Size(190, 184);
            this.lstVetorB.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 356);
            this.Controls.Add(this.lstVetorB);
            this.Controls.Add(this.tbnIniciar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tbnIniciar;
        private System.Windows.Forms.ListBox lstVetorB;
    }
}

