﻿namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            n7 = new Button();
            n8 = new Button();
            n9 = new Button();
            ndivide = new Button();
            nce = new Button();
            n4 = new Button();
            n5 = new Button();
            n6 = new Button();
            nmultiply = new Button();
            nc = new Button();
            n1 = new Button();
            n2 = new Button();
            n3 = new Button();
            nminus = new Button();
            n0 = new Button();
            ndot = new Button();
            nplus = new Button();
            nequal = new Button();
            textBoxResult = new TextBox();
            lcurrentOp = new Label();
            SuspendLayout();
            // 
            // n7
            // 
            n7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            n7.Location = new Point(16, 102);
            n7.Name = "n7";
            n7.Size = new Size(45, 45);
            n7.TabIndex = 0;
            n7.Text = "7";
            n7.UseVisualStyleBackColor = true;
            n7.Click += n_click;
            // 
            // n8
            // 
            n8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            n8.Location = new Point(63, 102);
            n8.Name = "n8";
            n8.Size = new Size(45, 45);
            n8.TabIndex = 0;
            n8.Text = "8";
            n8.UseVisualStyleBackColor = true;
            n8.Click += n_click;
            // 
            // n9
            // 
            n9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            n9.Location = new Point(110, 102);
            n9.Name = "n9";
            n9.Size = new Size(45, 45);
            n9.TabIndex = 0;
            n9.Text = "9";
            n9.UseVisualStyleBackColor = true;
            n9.Click += n_click;
            // 
            // ndivide
            // 
            ndivide.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ndivide.Location = new Point(157, 102);
            ndivide.Name = "ndivide";
            ndivide.Size = new Size(45, 45);
            ndivide.TabIndex = 0;
            ndivide.Text = "/";
            ndivide.UseVisualStyleBackColor = true;
            ndivide.Click += op_click;
            // 
            // nce
            // 
            nce.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nce.Location = new Point(204, 102);
            nce.Name = "nce";
            nce.Size = new Size(45, 45);
            nce.TabIndex = 0;
            nce.Text = "CE";
            nce.UseVisualStyleBackColor = true;
            nce.Click += nce_Click;
            // 
            // n4
            // 
            n4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            n4.Location = new Point(16, 149);
            n4.Name = "n4";
            n4.Size = new Size(45, 45);
            n4.TabIndex = 0;
            n4.Text = "4";
            n4.UseVisualStyleBackColor = true;
            n4.Click += n_click;
            // 
            // n5
            // 
            n5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            n5.Location = new Point(63, 149);
            n5.Name = "n5";
            n5.Size = new Size(45, 45);
            n5.TabIndex = 0;
            n5.Text = "5";
            n5.UseVisualStyleBackColor = true;
            n5.Click += n_click;
            // 
            // n6
            // 
            n6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            n6.Location = new Point(110, 149);
            n6.Name = "n6";
            n6.Size = new Size(45, 45);
            n6.TabIndex = 0;
            n6.Text = "6";
            n6.UseVisualStyleBackColor = true;
            n6.Click += n_click;
            // 
            // nmultiply
            // 
            nmultiply.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nmultiply.Location = new Point(157, 149);
            nmultiply.Name = "nmultiply";
            nmultiply.Size = new Size(45, 45);
            nmultiply.TabIndex = 0;
            nmultiply.Text = "*";
            nmultiply.UseVisualStyleBackColor = true;
            nmultiply.Click += op_click;
            // 
            // nc
            // 
            nc.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nc.Location = new Point(204, 149);
            nc.Name = "nc";
            nc.Size = new Size(45, 45);
            nc.TabIndex = 0;
            nc.Text = "C";
            nc.UseVisualStyleBackColor = true;
            nc.Click += nc_Click;
            // 
            // n1
            // 
            n1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            n1.Location = new Point(16, 196);
            n1.Name = "n1";
            n1.Size = new Size(45, 45);
            n1.TabIndex = 0;
            n1.Text = "1";
            n1.UseVisualStyleBackColor = true;
            n1.Click += n_click;
            // 
            // n2
            // 
            n2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            n2.Location = new Point(63, 196);
            n2.Name = "n2";
            n2.Size = new Size(45, 45);
            n2.TabIndex = 0;
            n2.Text = "2";
            n2.UseVisualStyleBackColor = true;
            n2.Click += n_click;
            // 
            // n3
            // 
            n3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            n3.Location = new Point(110, 196);
            n3.Name = "n3";
            n3.Size = new Size(45, 45);
            n3.TabIndex = 0;
            n3.Text = "3";
            n3.UseVisualStyleBackColor = true;
            n3.Click += n_click;
            // 
            // nminus
            // 
            nminus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nminus.Location = new Point(157, 196);
            nminus.Name = "nminus";
            nminus.Size = new Size(45, 45);
            nminus.TabIndex = 0;
            nminus.Text = "-";
            nminus.UseVisualStyleBackColor = true;
            nminus.Click += op_click;
            // 
            // n0
            // 
            n0.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            n0.Location = new Point(16, 243);
            n0.Name = "n0";
            n0.Size = new Size(92, 45);
            n0.TabIndex = 0;
            n0.Text = "0";
            n0.UseVisualStyleBackColor = true;
            n0.Click += n_click;
            // 
            // ndot
            // 
            ndot.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ndot.Location = new Point(110, 243);
            ndot.Name = "ndot";
            ndot.Size = new Size(45, 45);
            ndot.TabIndex = 0;
            ndot.Text = ".";
            ndot.UseVisualStyleBackColor = true;
            ndot.Click += n_click;
            // 
            // nplus
            // 
            nplus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nplus.Location = new Point(157, 243);
            nplus.Name = "nplus";
            nplus.Size = new Size(45, 45);
            nplus.TabIndex = 0;
            nplus.Text = "+";
            nplus.UseVisualStyleBackColor = true;
            nplus.Click += op_click;
            // 
            // nequal
            // 
            nequal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nequal.Location = new Point(204, 196);
            nequal.Name = "nequal";
            nequal.Size = new Size(47, 92);
            nequal.TabIndex = 0;
            nequal.Text = "=";
            nequal.UseVisualStyleBackColor = true;
            nequal.Click += nequal_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.Window;
            textBoxResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxResult.Location = new Point(16, 61);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(235, 33);
            textBoxResult.TabIndex = 1;
            textBoxResult.Text = "0";
            textBoxResult.TextAlign = HorizontalAlignment.Right;
            // 
            // lcurrentOp
            // 
            lcurrentOp.AutoSize = true;
            lcurrentOp.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lcurrentOp.ForeColor = SystemColors.GrayText;
            lcurrentOp.Location = new Point(12, 21);
            lcurrentOp.Name = "lcurrentOp";
            lcurrentOp.Size = new Size(0, 25);
            lcurrentOp.TabIndex = 2;
            lcurrentOp.Click += op_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 299);
            Controls.Add(lcurrentOp);
            Controls.Add(textBoxResult);
            Controls.Add(nequal);
            Controls.Add(nc);
            Controls.Add(nce);
            Controls.Add(nplus);
            Controls.Add(ndot);
            Controls.Add(nminus);
            Controls.Add(n3);
            Controls.Add(nmultiply);
            Controls.Add(n6);
            Controls.Add(n2);
            Controls.Add(ndivide);
            Controls.Add(n0);
            Controls.Add(n5);
            Controls.Add(n1);
            Controls.Add(n9);
            Controls.Add(n4);
            Controls.Add(n8);
            Controls.Add(n7);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button n7;
        private Button n8;
        private Button n9;
        private Button ndivide;
        private Button nce;
        private Button n4;
        private Button n5;
        private Button n6;
        private Button nmultiply;
        private Button nc;
        private Button n1;
        private Button n2;
        private Button n3;
        private Button nminus;
        private Button n0;
        private Button ndot;
        private Button nplus;
        private Button nequal;
        private TextBox textBoxResult;
        private Label lcurrentOp;
    }
}
