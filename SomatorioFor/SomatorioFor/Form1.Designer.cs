﻿namespace SomatorioFor
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.btnRes = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite 2 números:";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(238, 43);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(132, 31);
            this.txtNum1.TabIndex = 1;
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(299, 103);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(184, 34);
            this.btnRes.TabIndex = 2;
            this.btnRes.Text = "Calcular somatório";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(350, 178);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(59, 25);
            this.lblRes.TabIndex = 3;
            this.lblRes.Text = "label2";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(408, 43);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(132, 31);
            this.txtNum2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 230);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNum1;
        private Button btnRes;
        private Label lblRes;
        private TextBox txtNum2;
    }
}