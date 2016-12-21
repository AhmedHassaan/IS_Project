namespace First_Test
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
            this.emp = new System.Windows.Forms.Button();
            this.acc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emp
            // 
            this.emp.Location = new System.Drawing.Point(468, 86);
            this.emp.Name = "emp";
            this.emp.Size = new System.Drawing.Size(311, 85);
            this.emp.TabIndex = 0;
            this.emp.Text = "Empolyee";
            this.emp.UseVisualStyleBackColor = true;
            this.emp.Click += new System.EventHandler(this.emp_Click);
            // 
            // acc
            // 
            this.acc.Location = new System.Drawing.Point(468, 313);
            this.acc.Name = "acc";
            this.acc.Size = new System.Drawing.Size(311, 85);
            this.acc.TabIndex = 1;
            this.acc.Text = "Accountant";
            this.acc.UseVisualStyleBackColor = true;
            this.acc.Click += new System.EventHandler(this.acc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 496);
            this.Controls.Add(this.acc);
            this.Controls.Add(this.emp);
            this.Name = "Form1";
            this.Text = "Welcome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button emp;
        private System.Windows.Forms.Button acc;
    }
}

