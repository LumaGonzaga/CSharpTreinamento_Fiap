namespace ElogioSwitch
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
            this.lblElogio = new System.Windows.Forms.Label();
            this.txtElogio = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblElogio
            // 
            this.lblElogio.AutoSize = true;
            this.lblElogio.Location = new System.Drawing.Point(98, 34);
            this.lblElogio.Name = "lblElogio";
            this.lblElogio.Size = new System.Drawing.Size(157, 25);
            this.lblElogio.TabIndex = 0;
            this.lblElogio.Text = "Código do elogio:";
            // 
            // txtElogio
            // 
            this.txtElogio.Location = new System.Drawing.Point(261, 34);
            this.txtElogio.Name = "txtElogio";
            this.txtElogio.Size = new System.Drawing.Size(150, 31);
            this.txtElogio.TabIndex = 1;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(271, 96);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(112, 34);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 190);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtElogio);
            this.Controls.Add(this.lblElogio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblElogio;
        private TextBox txtElogio;
        private Button btnVerificar;
    }
}