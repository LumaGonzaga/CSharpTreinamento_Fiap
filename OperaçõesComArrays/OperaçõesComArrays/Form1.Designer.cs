namespace OperaçõesComArrays
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
            this.bntTamanho = new System.Windows.Forms.Button();
            this.bntOrdenar = new System.Windows.Forms.Button();
            this.bntInverter = new System.Windows.Forms.Button();
            this.bntBuscaBinaria = new System.Windows.Forms.Button();
            this.bntIndice = new System.Windows.Forms.Button();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bntTamanho
            // 
            this.bntTamanho.Location = new System.Drawing.Point(12, 12);
            this.bntTamanho.Name = "bntTamanho";
            this.bntTamanho.Size = new System.Drawing.Size(487, 35);
            this.bntTamanho.TabIndex = 0;
            this.bntTamanho.Text = "Tamanho do array";
            this.bntTamanho.UseVisualStyleBackColor = true;
            this.bntTamanho.Click += new System.EventHandler(this.bntTamanho_Click);
            // 
            // bntOrdenar
            // 
            this.bntOrdenar.Location = new System.Drawing.Point(12, 53);
            this.bntOrdenar.Name = "bntOrdenar";
            this.bntOrdenar.Size = new System.Drawing.Size(487, 35);
            this.bntOrdenar.TabIndex = 1;
            this.bntOrdenar.Text = "Ordenar o Array";
            this.bntOrdenar.UseVisualStyleBackColor = true;
            this.bntOrdenar.Click += new System.EventHandler(this.bntOrdenar_Click);
            // 
            // bntInverter
            // 
            this.bntInverter.Location = new System.Drawing.Point(12, 94);
            this.bntInverter.Name = "bntInverter";
            this.bntInverter.Size = new System.Drawing.Size(487, 35);
            this.bntInverter.TabIndex = 2;
            this.bntInverter.Text = "Inverter o array";
            this.bntInverter.UseVisualStyleBackColor = true;
            this.bntInverter.Click += new System.EventHandler(this.bntInverter_Click);
            // 
            // bntBuscaBinaria
            // 
            this.bntBuscaBinaria.Location = new System.Drawing.Point(12, 135);
            this.bntBuscaBinaria.Name = "bntBuscaBinaria";
            this.bntBuscaBinaria.Size = new System.Drawing.Size(487, 35);
            this.bntBuscaBinaria.TabIndex = 3;
            this.bntBuscaBinaria.Text = "Busca binária";
            this.bntBuscaBinaria.UseVisualStyleBackColor = true;
            this.bntBuscaBinaria.Click += new System.EventHandler(this.bntBuscaBinaria_Click);
            // 
            // bntIndice
            // 
            this.bntIndice.Location = new System.Drawing.Point(12, 176);
            this.bntIndice.Name = "bntIndice";
            this.bntIndice.Size = new System.Drawing.Size(487, 35);
            this.bntIndice.TabIndex = 4;
            this.bntIndice.Text = "Buscar Indice";
            this.bntIndice.UseVisualStyleBackColor = true;
            this.bntIndice.Click += new System.EventHandler(this.bntIndice_Click);
            // 
            // lstResultado
            // 
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.ItemHeight = 20;
            this.lstResultado.Location = new System.Drawing.Point(12, 217);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(487, 224);
            this.lstResultado.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 450);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.bntIndice);
            this.Controls.Add(this.bntBuscaBinaria);
            this.Controls.Add(this.bntInverter);
            this.Controls.Add(this.bntOrdenar);
            this.Controls.Add(this.bntTamanho);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntTamanho;
        private System.Windows.Forms.Button bntOrdenar;
        private System.Windows.Forms.Button bntInverter;
        private System.Windows.Forms.Button bntBuscaBinaria;
        private System.Windows.Forms.Button bntIndice;
        private System.Windows.Forms.ListBox lstResultado;
    }
}

