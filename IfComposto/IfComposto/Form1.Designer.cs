namespace IfComposto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDoação = new System.Windows.Forms.Label();
            this.txtDoacao = new System.Windows.Forms.TextBox();
            this.btnInvestimento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDoação
            // 
            this.lblDoação.AutoSize = true;
            this.lblDoação.Location = new System.Drawing.Point(0, 25);
            this.lblDoação.Name = "lblDoação";
            this.lblDoação.Size = new System.Drawing.Size(145, 25);
            this.lblDoação.TabIndex = 0;
            this.lblDoação.Text = "Valor da doação:";
            // 
            // txtDoacao
            // 
            this.txtDoacao.Location = new System.Drawing.Point(147, 25);
            this.txtDoacao.Name = "txtDoacao";
            this.txtDoacao.Size = new System.Drawing.Size(150, 31);
            this.txtDoacao.TabIndex = 1;
            // 
            // btnInvestimento
            // 
            this.btnInvestimento.Location = new System.Drawing.Point(53, 78);
            this.btnInvestimento.Name = "btnInvestimento";
            this.btnInvestimento.Size = new System.Drawing.Size(223, 34);
            this.btnInvestimento.TabIndex = 2;
            this.btnInvestimento.Text = "Calcular Investimento";
            this.btnInvestimento.UseVisualStyleBackColor = true;
            this.btnInvestimento.Click += new System.EventHandler(this.btnInvestimento_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInvestimento);
            this.Controls.Add(this.txtDoacao);
            this.Controls.Add(this.lblDoação);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDoação;
        private TextBox txtDoacao;
        private Button btnInvestimento;
    }
}