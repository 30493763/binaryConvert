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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblResultPrompt = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOne
            // 
            this.btnOne.Font = new System.Drawing.Font("Haettenschweiler", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(12, 127);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(162, 167);
            this.btnOne.TabIndex = 0;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            // 
            // btnZero
            // 
            this.btnZero.Font = new System.Drawing.Font("Haettenschweiler", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(180, 127);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(162, 167);
            this.btnZero.TabIndex = 1;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Haettenschweiler", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(348, 127);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(162, 167);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "del";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Haettenschweiler", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(516, 127);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(162, 167);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "chk";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(666, 29);
            this.txtInput.TabIndex = 4;
            this.txtInput.Text = "0000000000000000000000000000000000000000000000000000000000000000";
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblResultPrompt
            // 
            this.lblResultPrompt.AutoSize = true;
            this.lblResultPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultPrompt.Location = new System.Drawing.Point(12, 60);
            this.lblResultPrompt.Name = "lblResultPrompt";
            this.lblResultPrompt.Size = new System.Drawing.Size(204, 51);
            this.lblResultPrompt.TabIndex = 5;
            this.lblResultPrompt.Text = "RESULT:";
            this.lblResultPrompt.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(221, 60);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(46, 51);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 311);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblResultPrompt);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblResultPrompt;
        private System.Windows.Forms.Label lblResult;
    }
}

