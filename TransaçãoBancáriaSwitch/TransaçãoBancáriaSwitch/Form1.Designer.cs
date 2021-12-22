namespace TransaçãoBancáriaSwitch
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
            this.lblopcao = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.cmbEscolha = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.bntConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblopcao
            // 
            this.lblopcao.AutoSize = true;
            this.lblopcao.Location = new System.Drawing.Point(79, 34);
            this.lblopcao.Name = "lblopcao";
            this.lblopcao.Size = new System.Drawing.Size(170, 25);
            this.lblopcao.TabIndex = 0;
            this.lblopcao.Text = "Escolha uma opção:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(12, 113);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(304, 25);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Digite o valor do depósito ou saque:";
            // 
            // cmbEscolha
            // 
            this.cmbEscolha.FormattingEnabled = true;
            this.cmbEscolha.Items.AddRange(new object[] {
            "Depositar",
            "Saque",
            "Saldo"});
            this.cmbEscolha.Location = new System.Drawing.Point(322, 31);
            this.cmbEscolha.Name = "cmbEscolha";
            this.cmbEscolha.Size = new System.Drawing.Size(207, 33);
            this.cmbEscolha.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(322, 110);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(223, 31);
            this.txtValor.TabIndex = 3;
            // 
            // bntConfirmar
            // 
            this.bntConfirmar.Location = new System.Drawing.Point(268, 175);
            this.bntConfirmar.Name = "bntConfirmar";
            this.bntConfirmar.Size = new System.Drawing.Size(123, 46);
            this.bntConfirmar.TabIndex = 4;
            this.bntConfirmar.Text = "Confirmar";
            this.bntConfirmar.UseVisualStyleBackColor = true;
            this.bntConfirmar.Click += new System.EventHandler(this.bntConfirmar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntConfirmar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.cmbEscolha);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblopcao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblopcao;
        private Label lblValor;
        private ComboBox cmbEscolha;
        private TextBox txtValor;
        private Button bntConfirmar;
    }
}