namespace opLógicoOu
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
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtCupom = new System.Windows.Forms.TextBox();
            this.lblCupom = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.Location = new System.Drawing.Point(50, 42);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(122, 25);
            this.lblTotalCompra.TabIndex = 0;
            this.lblTotalCompra.Text = "Total Compra:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(178, 42);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(159, 31);
            this.txtTotal.TabIndex = 1;
            // 
            // txtCupom
            // 
            this.txtCupom.Location = new System.Drawing.Point(178, 89);
            this.txtCupom.Name = "txtCupom";
            this.txtCupom.Size = new System.Drawing.Size(159, 31);
            this.txtCupom.TabIndex = 3;
            // 
            // lblCupom
            // 
            this.lblCupom.AutoSize = true;
            this.lblCupom.Location = new System.Drawing.Point(50, 92);
            this.lblCupom.Name = "lblCupom";
            this.lblCupom.Size = new System.Drawing.Size(75, 25);
            this.lblCupom.TabIndex = 2;
            this.lblCupom.Text = "Cupom:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(199, 138);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 40);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCupom);
            this.Controls.Add(this.lblCupom);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotalCompra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTotalCompra;
        private TextBox txtTotal;
        private TextBox txtCupom;
        private Label lblCupom;
        private Button btnCalcular;
    }
}