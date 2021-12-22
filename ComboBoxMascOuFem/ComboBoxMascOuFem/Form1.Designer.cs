namespace ComboBoxMascOuFem
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
            this.lblSexo = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.btnSelecione = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(43, 29);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(147, 25);
            this.lblSexo.TabIndex = 0;
            this.lblSexo.Text = "Selecione o sexo:";
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.cmbSexo.Location = new System.Drawing.Point(43, 74);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(182, 33);
            this.cmbSexo.TabIndex = 1;
            // 
            // btnSelecione
            // 
            this.btnSelecione.Location = new System.Drawing.Point(43, 131);
            this.btnSelecione.Name = "btnSelecione";
            this.btnSelecione.Size = new System.Drawing.Size(112, 34);
            this.btnSelecione.TabIndex = 2;
            this.btnSelecione.Text = "Selecione";
            this.btnSelecione.UseVisualStyleBackColor = true;
            this.btnSelecione.Click += new System.EventHandler(this.btnSelecione_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 450);
            this.Controls.Add(this.btnSelecione);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.lblSexo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSexo;
        private ComboBox cmbSexo;
        private Button btnSelecione;
    }
}