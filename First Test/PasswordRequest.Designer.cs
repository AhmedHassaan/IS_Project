namespace First_Test
{
    partial class PasswordRequest
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
            this.label1 = new System.Windows.Forms.Label();
            this.passText = new System.Windows.Forms.TextBox();
            this.getPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            // 
            // passText
            // 
            this.passText.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passText.Location = new System.Drawing.Point(211, 59);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(491, 31);
            this.passText.TabIndex = 1;
            // 
            // getPass
            // 
            this.getPass.Location = new System.Drawing.Point(344, 178);
            this.getPass.Name = "getPass";
            this.getPass.Size = new System.Drawing.Size(190, 69);
            this.getPass.TabIndex = 2;
            this.getPass.Text = "Done";
            this.getPass.UseVisualStyleBackColor = true;
            this.getPass.Click += new System.EventHandler(this.getPass_Click);
            // 
            // PasswordRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(811, 310);
            this.Controls.Add(this.getPass);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.label1);
            this.Name = "PasswordRequest";
            this.Text = "Please Enter the Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.Button getPass;
    }
}