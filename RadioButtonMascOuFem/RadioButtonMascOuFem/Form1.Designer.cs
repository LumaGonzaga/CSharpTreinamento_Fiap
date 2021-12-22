namespace RadioButtonMascOuFem
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
            this.rbdFem = new System.Windows.Forms.RadioButton();
            this.rbdMasc = new System.Windows.Forms.RadioButton();
            this.lblSexo = new System.Windows.Forms.Label();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbdFem
            // 
            this.rbdFem.AutoSize = true;
            this.rbdFem.Location = new System.Drawing.Point(42, 94);
            this.rbdFem.Name = "rbdFem";
            this.rbdFem.Size = new System.Drawing.Size(110, 29);
            this.rbdFem.TabIndex = 0;
            this.rbdFem.TabStop = true;
            this.rbdFem.Text = "Feminino";
            this.rbdFem.UseVisualStyleBackColor = true;
            // 
            // rbdMasc
            // 
            this.rbdMasc.AutoSize = true;
            this.rbdMasc.Location = new System.Drawing.Point(42, 148);
            this.rbdMasc.Name = "rbdMasc";
            this.rbdMasc.Size = new System.Drawing.Size(117, 29);
            this.rbdMasc.TabIndex = 1;
            this.rbdMasc.TabStop = true;
            this.rbdMasc.Text = "Masculino";
            this.rbdMasc.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(42, 37);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(147, 25);
            this.lblSexo.TabIndex = 2;
            this.lblSexo.Text = "Selecione o sexo:";
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(42, 208);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(114, 31);
            this.btnSelecionar.TabIndex = 3;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 274);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.rbdMasc);
            this.Controls.Add(this.rbdFem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rbdFem;
        private RadioButton rbdMasc;
        private Label lblSexo;
        private Button btnSelecionar;
    }
}