namespace LaçosRepetição
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
            this.lblTabuada = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnTabuada = new System.Windows.Forms.Button();
            this.lstTabuada = new System.Windows.Forms.ListBox();
            this.btnDo = new System.Windows.Forms.Button();
            this.btnFor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTabuada
            // 
            this.lblTabuada.AutoSize = true;
            this.lblTabuada.Location = new System.Drawing.Point(12, 35);
            this.lblTabuada.Name = "lblTabuada";
            this.lblTabuada.Size = new System.Drawing.Size(161, 25);
            this.lblTabuada.TabIndex = 0;
            this.lblTabuada.Text = "Digite um número:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(179, 35);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(102, 31);
            this.txtNum.TabIndex = 1;
            // 
            // btnTabuada
            // 
            this.btnTabuada.Location = new System.Drawing.Point(116, 82);
            this.btnTabuada.Name = "btnTabuada";
            this.btnTabuada.Size = new System.Drawing.Size(187, 34);
            this.btnTabuada.TabIndex = 2;
            this.btnTabuada.Text = "Ver tabuada (While)";
            this.btnTabuada.UseVisualStyleBackColor = true;
            this.btnTabuada.Click += new System.EventHandler(this.btnTabuada_Click);
            // 
            // lstTabuada
            // 
            this.lstTabuada.FormattingEnabled = true;
            this.lstTabuada.ItemHeight = 25;
            this.lstTabuada.Location = new System.Drawing.Point(116, 235);
            this.lstTabuada.Name = "lstTabuada";
            this.lstTabuada.Size = new System.Drawing.Size(203, 179);
            this.lstTabuada.TabIndex = 3;
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(116, 127);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(187, 34);
            this.btnDo.TabIndex = 4;
            this.btnDo.Text = "Ver tabuada (Do)";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(116, 176);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(184, 34);
            this.btnFor.TabIndex = 5;
            this.btnFor.Text = "Ver tabuada (For)";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.lstTabuada);
            this.Controls.Add(this.btnTabuada);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblTabuada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTabuada;
        private TextBox txtNum;
        private Button btnTabuada;
        private ListBox lstTabuada;
        private Button btnDo;
        private Button btnFor;
    }
}