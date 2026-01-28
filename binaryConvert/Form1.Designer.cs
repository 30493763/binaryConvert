namespace binaryConvert
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
            this.btnOne = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblResultPrompt = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.lblBitLength = new System.Windows.Forms.Label();
            this.lblBitLengthResult = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblMax = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOne
            // 
            this.btnOne.Font = new System.Drawing.Font("Digital-7 Italic", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(29, 247);
            this.btnOne.Margin = new System.Windows.Forms.Padding(4);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(216, 206);
            this.btnOne.TabIndex = 0;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // btnZero
            // 
            this.btnZero.Font = new System.Drawing.Font("Digital-7 Italic", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(253, 247);
            this.btnZero.Margin = new System.Windows.Forms.Padding(4);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(216, 206);
            this.btnZero.TabIndex = 1;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDel.Font = new System.Drawing.Font("Digital-7 Italic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDel.Location = new System.Drawing.Point(477, 247);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(216, 100);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.IndianRed;
            this.btnCheck.Font = new System.Drawing.Font("Digital-7 Italic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCheck.Location = new System.Drawing.Point(701, 247);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(216, 206);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "CHECK";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblResultPrompt
            // 
            this.lblResultPrompt.AutoSize = true;
            this.lblResultPrompt.Font = new System.Drawing.Font("Digital-7 Italic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultPrompt.ForeColor = System.Drawing.SystemColors.Control;
            this.lblResultPrompt.Location = new System.Drawing.Point(34, 115);
            this.lblResultPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultPrompt.Name = "lblResultPrompt";
            this.lblResultPrompt.Size = new System.Drawing.Size(137, 42);
            this.lblResultPrompt.TabIndex = 5;
            this.lblResultPrompt.Text = "RESULT:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Digital-7 Italic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.Control;
            this.lblResult.Location = new System.Drawing.Point(223, 115);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 42);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "0";
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.lblDisplay.Font = new System.Drawing.Font("Digital-7 Italic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(36, 26);
            this.lblDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(881, 49);
            this.lblDisplay.TabIndex = 7;
            this.lblDisplay.Text = "--";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBitLength
            // 
            this.lblBitLength.AutoSize = true;
            this.lblBitLength.Font = new System.Drawing.Font("Digital-7 Italic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBitLength.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBitLength.Location = new System.Drawing.Point(29, 167);
            this.lblBitLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBitLength.Name = "lblBitLength";
            this.lblBitLength.Size = new System.Drawing.Size(186, 42);
            this.lblBitLength.TabIndex = 8;
            this.lblBitLength.Text = "BIT LENGTH";
            // 
            // lblBitLengthResult
            // 
            this.lblBitLengthResult.AutoSize = true;
            this.lblBitLengthResult.Font = new System.Drawing.Font("Digital-7 Italic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBitLengthResult.Location = new System.Drawing.Point(496, 166);
            this.lblBitLengthResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBitLengthResult.Name = "lblBitLengthResult";
            this.lblBitLengthResult.Size = new System.Drawing.Size(37, 42);
            this.lblBitLengthResult.TabIndex = 9;
            this.lblBitLengthResult.Text = "0";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Digital-7 Italic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(701, 151);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(216, 74);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnReset.Font = new System.Drawing.Font("Digital-7 Italic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReset.Location = new System.Drawing.Point(477, 357);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(216, 100);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Digital-7 Italic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.ForeColor = System.Drawing.Color.IndianRed;
            this.lblMax.Location = new System.Drawing.Point(223, 167);
            this.lblMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(150, 42);
            this.lblMax.TabIndex = 12;
            this.lblMax.Text = "MAX (64)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(947, 475);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblBitLengthResult);
            this.Controls.Add(this.lblBitLength);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblResultPrompt);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnOne);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Binary to Decimal Converter ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblResultPrompt;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label lblBitLength;
        private System.Windows.Forms.Label lblBitLengthResult;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblMax;
    }
}

