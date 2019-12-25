namespace PasswordGenerator
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
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.txtGeneratedPassword = new System.Windows.Forms.TextBox();
            this.numPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numSpecialCharacters = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtAllowedCharacters = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPasswordLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpecialCharacters)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Location = new System.Drawing.Point(39, 16);
            this.btnGeneratePassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(100, 57);
            this.btnGeneratePassword.TabIndex = 0;
            this.btnGeneratePassword.Text = "Generate Password";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // txtGeneratedPassword
            // 
            this.txtGeneratedPassword.Location = new System.Drawing.Point(259, 20);
            this.txtGeneratedPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGeneratedPassword.Name = "txtGeneratedPassword";
            this.txtGeneratedPassword.Size = new System.Drawing.Size(247, 22);
            this.txtGeneratedPassword.TabIndex = 1;
            // 
            // numPasswordLength
            // 
            this.numPasswordLength.Location = new System.Drawing.Point(259, 105);
            this.numPasswordLength.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numPasswordLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPasswordLength.Name = "numPasswordLength";
            this.numPasswordLength.Size = new System.Drawing.Size(160, 22);
            this.numPasswordLength.TabIndex = 2;
            this.numPasswordLength.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password Length";
            // 
            // numSpecialCharacters
            // 
            this.numSpecialCharacters.Location = new System.Drawing.Point(259, 142);
            this.numSpecialCharacters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numSpecialCharacters.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSpecialCharacters.Name = "numSpecialCharacters";
            this.numSpecialCharacters.Size = new System.Drawing.Size(160, 22);
            this.numSpecialCharacters.TabIndex = 4;
            this.numSpecialCharacters.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of Special Characters";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(39, 274);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtAllowedCharacters
            // 
            this.txtAllowedCharacters.Location = new System.Drawing.Point(259, 205);
            this.txtAllowedCharacters.Name = "txtAllowedCharacters";
            this.txtAllowedCharacters.Size = new System.Drawing.Size(228, 22);
            this.txtAllowedCharacters.TabIndex = 7;
            this.txtAllowedCharacters.Text = "@ # * ( ) + = { } / ? ~ ; , . - _";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 321);
            this.Controls.Add(this.txtAllowedCharacters);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numSpecialCharacters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numPasswordLength);
            this.Controls.Add(this.txtGeneratedPassword);
            this.Controls.Add(this.btnGeneratePassword);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.numPasswordLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpecialCharacters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.TextBox txtGeneratedPassword;
        private System.Windows.Forms.NumericUpDown numPasswordLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numSpecialCharacters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtAllowedCharacters;
    }
}

