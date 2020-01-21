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
            this.btnGeneratePassword.Location = new System.Drawing.Point(58, 25);
            this.btnGeneratePassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(150, 89);
            this.btnGeneratePassword.TabIndex = 0;
            this.btnGeneratePassword.Text = "Generate Password";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // txtGeneratedPassword
            // 
            this.txtGeneratedPassword.Location = new System.Drawing.Point(388, 31);
            this.txtGeneratedPassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtGeneratedPassword.Name = "txtGeneratedPassword";
            this.txtGeneratedPassword.Size = new System.Drawing.Size(368, 31);
            this.txtGeneratedPassword.TabIndex = 1;
            // 
            // numPasswordLength
            // 
            this.numPasswordLength.Location = new System.Drawing.Point(388, 164);
            this.numPasswordLength.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numPasswordLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPasswordLength.Name = "numPasswordLength";
            this.numPasswordLength.Size = new System.Drawing.Size(240, 31);
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
            this.label1.Location = new System.Drawing.Point(58, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password Length";
            // 
            // numSpecialCharacters
            // 
            this.numSpecialCharacters.Location = new System.Drawing.Point(388, 222);
            this.numSpecialCharacters.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numSpecialCharacters.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSpecialCharacters.Name = "numSpecialCharacters";
            this.numSpecialCharacters.Size = new System.Drawing.Size(240, 31);
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
            this.label2.Location = new System.Drawing.Point(58, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of Special Characters";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(58, 428);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 44);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtAllowedCharacters
            // 
            this.txtAllowedCharacters.Location = new System.Drawing.Point(388, 320);
            this.txtAllowedCharacters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAllowedCharacters.Name = "txtAllowedCharacters";
            this.txtAllowedCharacters.Size = new System.Drawing.Size(340, 31);
            this.txtAllowedCharacters.TabIndex = 7;
            this.txtAllowedCharacters.Text = "@ # * ( ) + = { } / ? ~ ; , . - _";
            this.txtAllowedCharacters.TextChanged += new System.EventHandler(this.txtAllowedCharacters_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 502);
            this.Controls.Add(this.txtAllowedCharacters);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numSpecialCharacters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numPasswordLength);
            this.Controls.Add(this.txtGeneratedPassword);
            this.Controls.Add(this.btnGeneratePassword);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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

