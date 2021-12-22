namespace ValorCrédito
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
            this.lblSaldoMedio = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.txtSaldoMedio = new System.Windows.Forms.TextBox();
            this.btnVerCredito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSaldoMedio
            // 
            this.lblSaldoMedio.AutoSize = true;
            this.lblSaldoMedio.Location = new System.Drawing.Point(24, 9);
            this.lblSaldoMedio.Name = "lblSaldoMedio";
            this.lblSaldoMedio.Size = new System.Drawing.Size(199, 25);
            this.lblSaldoMedio.TabIndex = 0;
            this.lblSaldoMedio.Text = "Digite seu saldo médio:";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(12, 159);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(59, 25);
            this.lblRes.TabIndex = 1;
            this.lblRes.Text = "label2";
            // 
            // txtSaldoMedio
            // 
            this.txtSaldoMedio.Location = new System.Drawing.Point(12, 46);
            this.txtSaldoMedio.Name = "txtSaldoMedio";
            this.txtSaldoMedio.Size = new System.Drawing.Size(211, 31);
            this.txtSaldoMedio.TabIndex = 2;
            // 
            // btnVerCredito
            // 
            this.btnVerCredito.Location = new System.Drawing.Point(48, 93);
            this.btnVerCredito.Name = "btnVerCredito";
            this.btnVerCredito.Size = new System.Drawing.Size(112, 34);
            this.btnVerCredito.TabIndex = 3;
            this.btnVerCredito.Text = "Ver crédito";
            this.btnVerCredito.UseVisualStyleBackColor = true;
            this.btnVerCredito.Click += new System.EventHandler(this.btnVerCredito_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerCredito);
            this.Controls.Add(this.txtSaldoMedio);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.lblSaldoMedio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSaldoMedio;
        private Label lblRes;
        private TextBox txtSaldoMedio;
        private Button btnVerCredito;
    }
}