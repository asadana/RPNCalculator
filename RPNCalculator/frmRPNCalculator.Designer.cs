namespace RPNCalculator
{
    partial class frmRPNCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRPNCalculator));
            this.lblFirstNum = new System.Windows.Forms.Label();
            this.lblSecondNum = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtFirstNum = new System.Windows.Forms.TextBox();
            this.txtSecondNum = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnRem = new System.Windows.Forms.Button();
            this.btnWholeNeg = new System.Windows.Forms.Button();
            this.btnWholePos = new System.Windows.Forms.Button();
            this.btnInvSum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstNum
            // 
            this.lblFirstNum.AutoSize = true;
            this.lblFirstNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNum.Location = new System.Drawing.Point(12, 37);
            this.lblFirstNum.Name = "lblFirstNum";
            this.lblFirstNum.Size = new System.Drawing.Size(162, 18);
            this.lblFirstNum.TabIndex = 0;
            this.lblFirstNum.Text = "Enter First Number ( x )";
            // 
            // lblSecondNum
            // 
            this.lblSecondNum.AutoSize = true;
            this.lblSecondNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondNum.Location = new System.Drawing.Point(12, 75);
            this.lblSecondNum.Name = "lblSecondNum";
            this.lblSecondNum.Size = new System.Drawing.Size(184, 18);
            this.lblSecondNum.TabIndex = 1;
            this.lblSecondNum.Text = "Enter Second Number ( y )";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(12, 242);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(57, 18);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "Answer";
            // 
            // txtFirstNum
            // 
            this.txtFirstNum.Location = new System.Drawing.Point(226, 36);
            this.txtFirstNum.Name = "txtFirstNum";
            this.txtFirstNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFirstNum.Size = new System.Drawing.Size(338, 22);
            this.txtFirstNum.TabIndex = 3;
            this.txtFirstNum.Leave += new System.EventHandler(this.txtFirstNum_Leave);
            this.txtFirstNum.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtFirstNum_MouseDown);
            // 
            // txtSecondNum
            // 
            this.txtSecondNum.Location = new System.Drawing.Point(226, 74);
            this.txtSecondNum.Name = "txtSecondNum";
            this.txtSecondNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSecondNum.Size = new System.Drawing.Size(338, 22);
            this.txtSecondNum.TabIndex = 4;
            this.txtSecondNum.Leave += new System.EventHandler(this.txtSecondNum_Leave);
            this.txtSecondNum.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtSecondNum_MouseDown);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(226, 239);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAnswer.Size = new System.Drawing.Size(338, 22);
            this.txtAnswer.TabIndex = 5;
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.BackColor = System.Drawing.SystemColors.Control;
            this.btnQuit.Location = new System.Drawing.Point(439, 271);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(125, 50);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(226, 271);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 50);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(226, 113);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 50);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "x + y";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(312, 113);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(80, 50);
            this.btnSubtract.TabIndex = 10;
            this.btnSubtract.Text = "x - y";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(226, 169);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(80, 50);
            this.btnMultiply.TabIndex = 11;
            this.btnMultiply.Text = "x * y";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(312, 169);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(80, 50);
            this.btnDivide.TabIndex = 12;
            this.btnDivide.Text = "x / y";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnRem
            // 
            this.btnRem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRem.Location = new System.Drawing.Point(398, 113);
            this.btnRem.Name = "btnRem";
            this.btnRem.Size = new System.Drawing.Size(80, 50);
            this.btnRem.TabIndex = 14;
            this.btnRem.Text = "x % y";
            this.btnRem.UseVisualStyleBackColor = true;
            this.btnRem.Click += new System.EventHandler(this.btnRem_Click);
            // 
            // btnWholeNeg
            // 
            this.btnWholeNeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWholeNeg.Location = new System.Drawing.Point(484, 169);
            this.btnWholeNeg.Name = "btnWholeNeg";
            this.btnWholeNeg.Size = new System.Drawing.Size(80, 50);
            this.btnWholeNeg.TabIndex = 15;
            this.btnWholeNeg.Text = "(x - y)^2";
            this.btnWholeNeg.UseVisualStyleBackColor = true;
            this.btnWholeNeg.Click += new System.EventHandler(this.btnWholeNeg_Click);
            // 
            // btnWholePos
            // 
            this.btnWholePos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWholePos.Location = new System.Drawing.Point(484, 113);
            this.btnWholePos.Name = "btnWholePos";
            this.btnWholePos.Size = new System.Drawing.Size(80, 50);
            this.btnWholePos.TabIndex = 16;
            this.btnWholePos.Text = "(x + y)^2";
            this.btnWholePos.UseVisualStyleBackColor = true;
            this.btnWholePos.Click += new System.EventHandler(this.btnWholePos_Click);
            // 
            // btnInvSum
            // 
            this.btnInvSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvSum.Location = new System.Drawing.Point(398, 169);
            this.btnInvSum.Name = "btnInvSum";
            this.btnInvSum.Size = new System.Drawing.Size(80, 50);
            this.btnInvSum.TabIndex = 17;
            this.btnInvSum.Text = "1/x + 1/y";
            this.btnInvSum.UseVisualStyleBackColor = true;
            this.btnInvSum.Click += new System.EventHandler(this.btnInvSum_Click);
            // 
            // frmRPNCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(572, 333);
            this.Controls.Add(this.btnInvSum);
            this.Controls.Add(this.btnWholePos);
            this.Controls.Add(this.btnWholeNeg);
            this.Controls.Add(this.btnRem);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtSecondNum);
            this.Controls.Add(this.txtFirstNum);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblSecondNum);
            this.Controls.Add(this.lblFirstNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRPNCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPN Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRPNCalculator_FormClosing);
            this.Load += new System.EventHandler(this.frmRPNCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstNum;
        private System.Windows.Forms.Label lblSecondNum;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtFirstNum;
        private System.Windows.Forms.TextBox txtSecondNum;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnRem;
        private System.Windows.Forms.Button btnWholeNeg;
        private System.Windows.Forms.Button btnWholePos;
        private System.Windows.Forms.Button btnInvSum;
    }
}

