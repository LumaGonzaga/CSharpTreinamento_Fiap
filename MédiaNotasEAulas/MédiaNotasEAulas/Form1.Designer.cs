namespace MédiaNotasEAulas
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
            this.lblNotas = new System.Windows.Forms.Label();
            this.lblQAulas = new System.Windows.Forms.Label();
            this.lblAulasAssistidas = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtQG = new System.Windows.Forms.TextBox();
            this.txtQA = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Location = new System.Drawing.Point(12, 36);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(134, 25);
            this.lblNotas.TabIndex = 0;
            this.lblNotas.Text = "Digite as notas:";
            // 
            // lblQAulas
            // 
            this.lblQAulas.AutoSize = true;
            this.lblQAulas.Location = new System.Drawing.Point(12, 98);
            this.lblQAulas.Name = "lblQAulas";
            this.lblQAulas.Size = new System.Drawing.Size(179, 25);
            this.lblQAulas.TabIndex = 1;
            this.lblQAulas.Text = "Quantidade de aulas:";
            // 
            // lblAulasAssistidas
            // 
            this.lblAulasAssistidas.AutoSize = true;
            this.lblAulasAssistidas.Location = new System.Drawing.Point(12, 158);
            this.lblAulasAssistidas.Name = "lblAulasAssistidas";
            this.lblAulasAssistidas.Size = new System.Drawing.Size(139, 25);
            this.lblAulasAssistidas.TabIndex = 2;
            this.lblAulasAssistidas.Text = "Aulas assistidas:";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(157, 33);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(69, 31);
            this.txtNum1.TabIndex = 3;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(256, 33);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(69, 31);
            this.txtNum2.TabIndex = 4;
            // 
            // txtQG
            // 
            this.txtQG.Location = new System.Drawing.Point(197, 92);
            this.txtQG.Name = "txtQG";
            this.txtQG.Size = new System.Drawing.Size(81, 31);
            this.txtQG.TabIndex = 5;
            // 
            // txtQA
            // 
            this.txtQA.Location = new System.Drawing.Point(157, 152);
            this.txtQA.Name = "txtQA";
            this.txtQA.Size = new System.Drawing.Size(78, 31);
            this.txtQA.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(114, 232);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(112, 34);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 350);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtQA);
            this.Controls.Add(this.txtQG);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblAulasAssistidas);
            this.Controls.Add(this.lblQAulas);
            this.Controls.Add(this.lblNotas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNotas;
        private Label lblQAulas;
        private Label lblAulasAssistidas;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtQG;
        private TextBox txtQA;
        private Button btnCalcular;
    }
}