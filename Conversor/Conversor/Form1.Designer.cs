namespace Conversor
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.btnConverter = new System.Windows.Forms.Button();
            this.lblDolares = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(4, 37);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(158, 31);
            this.txtNum1.TabIndex = 0;
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Location = new System.Drawing.Point(12, 9);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(145, 25);
            this.lblDolar.TabIndex = 1;
            this.lblDolar.Text = "Valor da doação:";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(153, 157);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(59, 25);
            this.lblRes.TabIndex = 4;
            this.lblRes.Text = "label3";
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(75, 84);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(217, 34);
            this.btnConverter.TabIndex = 5;
            this.btnConverter.Text = "Converter para R$";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // lblDolares
            // 
            this.lblDolares.AutoSize = true;
            this.lblDolares.Location = new System.Drawing.Point(230, 9);
            this.lblDolares.Name = "lblDolares";
            this.lblDolares.Size = new System.Drawing.Size(104, 25);
            this.lblDolares.TabIndex = 6;
            this.lblDolares.Text = "Valor Dólar:";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(206, 37);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(160, 31);
            this.txtNum2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 289);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.lblDolares);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form1";
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNum1;
        private Label lblDolar;
        private Label lblRes;
        private Button btnConverter;
        private Label lblDolares;
        private TextBox txtNum2;
    }
}