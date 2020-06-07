namespace ExtractCode
{
    partial class FormGetPasscode
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonGetCode = new System.Windows.Forms.Button();
            this.labelPasscodes = new System.Windows.Forms.Label();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.textBoxPasscode = new System.Windows.Forms.TextBox();
            this.listBoxPasscode = new System.Windows.Forms.ListBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1346, 873);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(126, 43);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonGetCode
            // 
            this.buttonGetCode.Location = new System.Drawing.Point(61, 873);
            this.buttonGetCode.Name = "buttonGetCode";
            this.buttonGetCode.Size = new System.Drawing.Size(126, 43);
            this.buttonGetCode.TabIndex = 1;
            this.buttonGetCode.Text = "Get Code";
            this.buttonGetCode.UseVisualStyleBackColor = true;
            this.buttonGetCode.Click += new System.EventHandler(this.buttonGetCode_Click);
            // 
            // labelPasscodes
            // 
            this.labelPasscodes.AutoSize = true;
            this.labelPasscodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasscodes.Location = new System.Drawing.Point(54, 26);
            this.labelPasscodes.Name = "labelPasscodes";
            this.labelPasscodes.Size = new System.Drawing.Size(213, 42);
            this.labelPasscodes.TabIndex = 2;
            this.labelPasscodes.Text = "Passcodes:";
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "OpenFile";
            // 
            // textBoxPasscode
            // 
            this.textBoxPasscode.Location = new System.Drawing.Point(61, 85);
            this.textBoxPasscode.Multiline = true;
            this.textBoxPasscode.Name = "textBoxPasscode";
            this.textBoxPasscode.Size = new System.Drawing.Size(1387, 314);
            this.textBoxPasscode.TabIndex = 4;
            // 
            // listBoxPasscode
            // 
            this.listBoxPasscode.FormattingEnabled = true;
            this.listBoxPasscode.ItemHeight = 25;
            this.listBoxPasscode.Location = new System.Drawing.Point(61, 443);
            this.listBoxPasscode.Name = "listBoxPasscode";
            this.listBoxPasscode.Size = new System.Drawing.Size(1387, 354);
            this.listBoxPasscode.TabIndex = 5;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(692, 873);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(126, 43);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // FormGetPasscode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 934);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.listBoxPasscode);
            this.Controls.Add(this.textBoxPasscode);
            this.Controls.Add(this.labelPasscodes);
            this.Controls.Add(this.buttonGetCode);
            this.Controls.Add(this.buttonExit);
            this.Name = "FormGetPasscode";
            this.Text = "Get Passcode";
            this.Load += new System.EventHandler(this.FormGetPasscode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonGetCode;
        private System.Windows.Forms.Label labelPasscodes;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.TextBox textBoxPasscode;
        private System.Windows.Forms.ListBox listBoxPasscode;
        private System.Windows.Forms.Button buttonClear;
    }
}

