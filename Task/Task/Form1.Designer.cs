
namespace Task
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.txtSplitNumber = new System.Windows.Forms.TextBox();
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSecondNumber);
            this.groupBox1.Controls.Add(this.txtFirstNumber);
            this.groupBox1.Controls.Add(this.txtSplitNumber);
            this.groupBox1.Controls.Add(this.btnSplit);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(53, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSub);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtResult);
            this.groupBox2.Controls.Add(this.btnMul);
            this.groupBox2.Controls.Add(this.btnDiv);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(53, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 95);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btnSplit
            // 
            this.btnSplit.Font = new System.Drawing.Font("Arial", 13.8F);
            this.btnSplit.Location = new System.Drawing.Point(29, 40);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(217, 34);
            this.btnSplit.TabIndex = 0;
            this.btnSplit.Text = "Split Numbers";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // txtSplitNumber
            // 
            this.txtSplitNumber.Font = new System.Drawing.Font("Arial", 13.8F);
            this.txtSplitNumber.Location = new System.Drawing.Point(252, 40);
            this.txtSplitNumber.Name = "txtSplitNumber";
            this.txtSplitNumber.Size = new System.Drawing.Size(254, 34);
            this.txtSplitNumber.TabIndex = 1;
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.Enabled = false;
            this.txtFirstNumber.Font = new System.Drawing.Font("Arial", 13.8F);
            this.txtFirstNumber.Location = new System.Drawing.Point(252, 80);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(254, 34);
            this.txtFirstNumber.TabIndex = 1;
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.Enabled = false;
            this.txtSecondNumber.Font = new System.Drawing.Font("Arial", 13.8F);
            this.txtSecondNumber.Location = new System.Drawing.Point(252, 120);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(254, 34);
            this.txtSecondNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F);
            this.label1.Location = new System.Drawing.Point(94, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F);
            this.label2.Location = new System.Drawing.Point(59, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Second Number";
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Arial", 13.8F);
            this.btnDiv.Location = new System.Drawing.Point(56, 36);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(43, 34);
            this.btnDiv.TabIndex = 0;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMul
            // 
            this.btnMul.Font = new System.Drawing.Font("Arial", 13.8F);
            this.btnMul.Location = new System.Drawing.Point(105, 36);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(43, 34);
            this.btnMul.TabIndex = 0;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 13.8F);
            this.btnAdd.Location = new System.Drawing.Point(154, 36);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(43, 34);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Arial", 13.8F);
            this.btnSub.Location = new System.Drawing.Point(203, 36);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(43, 34);
            this.btnSub.TabIndex = 0;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(258, 36);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(248, 34);
            this.txtResult.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 358);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task 01";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSecondNumber;
        private System.Windows.Forms.TextBox txtFirstNumber;
        private System.Windows.Forms.TextBox txtSplitNumber;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
    }
}

