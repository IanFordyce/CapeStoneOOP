namespace Fordce.MoneyToWords
{
    partial class MoneyConvertion
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
            this.txtInputBox = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblConvertedDisplay = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInputBox
            // 
            this.txtInputBox.AccessibleName = "lblConvertedDisplay";
            this.txtInputBox.Location = new System.Drawing.Point(194, 100);
            this.txtInputBox.Name = "txtInputBox";
            this.txtInputBox.PlaceholderText = "Input Number";
            this.txtInputBox.Size = new System.Drawing.Size(361, 27);
            this.txtInputBox.TabIndex = 0;
            this.txtInputBox.TextChanged += new System.EventHandler(this.txtInputBox_TextChanged);
            this.txtInputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInputBox_KeyPress);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(122, 231);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(506, 231);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(94, 29);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblConvertedDisplay
            // 
            this.lblConvertedDisplay.AccessibleName = "";
            this.lblConvertedDisplay.BackColor = System.Drawing.Color.White;
            this.lblConvertedDisplay.Location = new System.Drawing.Point(194, 166);
            this.lblConvertedDisplay.Name = "lblConvertedDisplay";
            this.lblConvertedDisplay.Size = new System.Drawing.Size(361, 43);
            this.lblConvertedDisplay.TabIndex = 3;
            this.lblConvertedDisplay.Text = "Number Display ";
            this.lblConvertedDisplay.Click += new System.EventHandler(this.lblConvertedDisplay_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(322, 231);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 29);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MoneyConvertion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblConvertedDisplay);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtInputBox);
            this.Name = "MoneyConvertion";
            this.Text = "Money Converter";
            this.Load += new System.EventHandler(this.MoneyConvertion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputBox;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblConvertedDisplay;
        private System.Windows.Forms.Button btnClear;
    }
}
