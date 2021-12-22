namespace ExemplosComboBox
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
            this.cmbEscolha = new System.Windows.Forms.ComboBox();
            this.btnEscolha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbEscolha
            // 
            this.cmbEscolha.FormattingEnabled = true;
            this.cmbEscolha.Items.AddRange(new object[] {
            "Ferrari",
            "Mercedes",
            "Redbull",
            "McLaren"});
            this.cmbEscolha.Location = new System.Drawing.Point(91, 42);
            this.cmbEscolha.Name = "cmbEscolha";
            this.cmbEscolha.Size = new System.Drawing.Size(308, 33);
            this.cmbEscolha.TabIndex = 0;
            // 
            // btnEscolha
            // 
            this.btnEscolha.Location = new System.Drawing.Point(148, 81);
            this.btnEscolha.Name = "btnEscolha";
            this.btnEscolha.Size = new System.Drawing.Size(209, 44);
            this.btnEscolha.TabIndex = 1;
            this.btnEscolha.Text = "Confirmar escolha";
            this.btnEscolha.UseVisualStyleBackColor = true;
            this.btnEscolha.Click += new System.EventHandler(this.btnEscolha_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 214);
            this.Controls.Add(this.btnEscolha);
            this.Controls.Add(this.cmbEscolha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cmbEscolha;
        private Button btnEscolha;
    }
}