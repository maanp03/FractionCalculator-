namespace FractionCalculator
{
    partial class FractionCalculator
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
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtBox3 = new System.Windows.Forms.TextBox();
            this.txtBox4 = new System.Windows.Forms.TextBox();
            this.txtBox6 = new System.Windows.Forms.TextBox();
            this.txtBox5 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.grpCalculate = new System.Windows.Forms.GroupBox();
            this.rbtnSum = new System.Windows.Forms.RadioButton();
            this.rbtnSubtract = new System.Windows.Forms.RadioButton();
            this.rbtnMultiply = new System.Windows.Forms.RadioButton();
            this.rbtnDivide = new System.Windows.Forms.RadioButton();
            this.btnPerform = new System.Windows.Forms.Button();
            this.lblEqual = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblLine2 = new System.Windows.Forms.Label();
            this.lblLine3 = new System.Windows.Forms.Label();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.grpCalculate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(134, 161);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(40, 20);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "First";
            this.lblFirst.Click += new System.EventHandler(this.lblFirst_Click);
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Location = new System.Drawing.Point(552, 161);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(64, 20);
            this.lblSecond.TabIndex = 1;
            this.lblSecond.Text = "Second";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(995, 161);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 20);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Result";
            // 
            // txtBox3
            // 
            this.txtBox3.Location = new System.Drawing.Point(556, 219);
            this.txtBox3.Name = "txtBox3";
            this.txtBox3.Size = new System.Drawing.Size(57, 26);
            this.txtBox3.TabIndex = 4;
            this.txtBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox3_KeyPress);
            // 
            // txtBox4
            // 
            this.txtBox4.Location = new System.Drawing.Point(556, 276);
            this.txtBox4.Name = "txtBox4";
            this.txtBox4.Size = new System.Drawing.Size(57, 26);
            this.txtBox4.TabIndex = 6;
            this.txtBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox4_KeyPress);
            // 
            // txtBox6
            // 
            this.txtBox6.Location = new System.Drawing.Point(999, 276);
            this.txtBox6.Name = "txtBox6";
            this.txtBox6.ReadOnly = true;
            this.txtBox6.Size = new System.Drawing.Size(57, 26);
            this.txtBox6.TabIndex = 10;
            this.txtBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox6_KeyPress);
            // 
            // txtBox5
            // 
            this.txtBox5.Location = new System.Drawing.Point(999, 219);
            this.txtBox5.Name = "txtBox5";
            this.txtBox5.ReadOnly = true;
            this.txtBox5.Size = new System.Drawing.Size(57, 26);
            this.txtBox5.TabIndex = 11;
            this.txtBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox5_KeyPress);
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(126, 276);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(57, 26);
            this.txtBox2.TabIndex = 12;
            this.txtBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox2_KeyPress);
            // 
            // grpCalculate
            // 
            this.grpCalculate.Controls.Add(this.rbtnDivide);
            this.grpCalculate.Controls.Add(this.rbtnMultiply);
            this.grpCalculate.Controls.Add(this.rbtnSubtract);
            this.grpCalculate.Controls.Add(this.rbtnSum);
            this.grpCalculate.Location = new System.Drawing.Point(265, 122);
            this.grpCalculate.Name = "grpCalculate";
            this.grpCalculate.Size = new System.Drawing.Size(200, 285);
            this.grpCalculate.TabIndex = 13;
            this.grpCalculate.TabStop = false;
            // 
            // rbtnSum
            // 
            this.rbtnSum.AutoSize = true;
            this.rbtnSum.Location = new System.Drawing.Point(7, 39);
            this.rbtnSum.Name = "rbtnSum";
            this.rbtnSum.Size = new System.Drawing.Size(43, 24);
            this.rbtnSum.TabIndex = 0;
            this.rbtnSum.TabStop = true;
            this.rbtnSum.Text = "+";
            this.rbtnSum.UseVisualStyleBackColor = true;
            // 
            // rbtnSubtract
            // 
            this.rbtnSubtract.AutoSize = true;
            this.rbtnSubtract.Location = new System.Drawing.Point(7, 97);
            this.rbtnSubtract.Name = "rbtnSubtract";
            this.rbtnSubtract.Size = new System.Drawing.Size(39, 24);
            this.rbtnSubtract.TabIndex = 1;
            this.rbtnSubtract.TabStop = true;
            this.rbtnSubtract.Text = "-";
            this.rbtnSubtract.UseVisualStyleBackColor = true;
            // 
            // rbtnMultiply
            // 
            this.rbtnMultiply.AutoSize = true;
            this.rbtnMultiply.Location = new System.Drawing.Point(7, 160);
            this.rbtnMultiply.Name = "rbtnMultiply";
            this.rbtnMultiply.Size = new System.Drawing.Size(40, 24);
            this.rbtnMultiply.TabIndex = 2;
            this.rbtnMultiply.TabStop = true;
            this.rbtnMultiply.Text = "*";
            this.rbtnMultiply.UseVisualStyleBackColor = true;
            // 
            // rbtnDivide
            // 
            this.rbtnDivide.AutoSize = true;
            this.rbtnDivide.Location = new System.Drawing.Point(7, 227);
            this.rbtnDivide.Name = "rbtnDivide";
            this.rbtnDivide.Size = new System.Drawing.Size(38, 24);
            this.rbtnDivide.TabIndex = 3;
            this.rbtnDivide.TabStop = true;
            this.rbtnDivide.Text = "/";
            this.rbtnDivide.UseVisualStyleBackColor = true;
            // 
            // btnPerform
            // 
            this.btnPerform.Location = new System.Drawing.Point(138, 438);
            this.btnPerform.Name = "btnPerform";
            this.btnPerform.Size = new System.Drawing.Size(918, 68);
            this.btnPerform.TabIndex = 14;
            this.btnPerform.Text = "Perform Operation";
            this.btnPerform.UseVisualStyleBackColor = true;
            this.btnPerform.Click += new System.EventHandler(this.btnPerform_Click);
            // 
            // lblEqual
            // 
            this.lblEqual.AutoSize = true;
            this.lblEqual.Location = new System.Drawing.Point(797, 254);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(18, 20);
            this.lblEqual.TabIndex = 15;
            this.lblEqual.Text = "=";
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine.Location = new System.Drawing.Point(102, 248);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(99, 20);
            this.lblLine.TabIndex = 16;
            this.lblLine.Text = "_________";
            // 
            // lblLine2
            // 
            this.lblLine2.AutoSize = true;
            this.lblLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine2.Location = new System.Drawing.Point(534, 248);
            this.lblLine2.Name = "lblLine2";
            this.lblLine2.Size = new System.Drawing.Size(99, 20);
            this.lblLine2.TabIndex = 17;
            this.lblLine2.Text = "_________";
            // 
            // lblLine3
            // 
            this.lblLine3.AutoSize = true;
            this.lblLine3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine3.Location = new System.Drawing.Point(980, 248);
            this.lblLine3.Name = "lblLine3";
            this.lblLine3.Size = new System.Drawing.Size(99, 20);
            this.lblLine3.TabIndex = 18;
            this.lblLine3.Text = "_________";
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(126, 208);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(57, 26);
            this.txtBox1.TabIndex = 19;
            this.txtBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox1_KeyPress);
            // 
            // FractionCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 530);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.lblLine3);
            this.Controls.Add(this.lblLine2);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblEqual);
            this.Controls.Add(this.btnPerform);
            this.Controls.Add(this.grpCalculate);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox5);
            this.Controls.Add(this.txtBox6);
            this.Controls.Add(this.txtBox4);
            this.Controls.Add(this.txtBox3);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblFirst);
            this.Name = "FractionCalculator";
            this.Text = "Fraction Calculator";
            this.grpCalculate.ResumeLayout(false);
            this.grpCalculate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtBox3;
        private System.Windows.Forms.TextBox txtBox4;
        private System.Windows.Forms.TextBox txtBox6;
        private System.Windows.Forms.TextBox txtBox5;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.GroupBox grpCalculate;
        private System.Windows.Forms.RadioButton rbtnDivide;
        private System.Windows.Forms.RadioButton rbtnMultiply;
        private System.Windows.Forms.RadioButton rbtnSubtract;
        private System.Windows.Forms.RadioButton rbtnSum;
        private System.Windows.Forms.Button btnPerform;
        private System.Windows.Forms.Label lblEqual;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblLine2;
        private System.Windows.Forms.Label lblLine3;
        private System.Windows.Forms.TextBox txtBox1;
    }
}

