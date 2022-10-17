namespace MainToOther
{
    partial class Form1
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
            this.userInput = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(112, 92);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(600, 27);
            this.userInput.TabIndex = 0;
            this.userInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(220, 208);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(259, 57);
            this.btn_send.TabIndex = 1;
            this.btn_send.Text = "button1";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.userInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox userInput;
        private Button btn_send;
    }
}