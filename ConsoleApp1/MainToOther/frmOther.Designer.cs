namespace MainToOther
{
    partial class frmOther
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
            this.message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.message.Location = new System.Drawing.Point(154, 102);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(118, 45);
            this.message.TabIndex = 0;
            this.message.Text = "label1";
            this.message.Click += new System.EventHandler(this.message_Click);
            // 
            // frmOther
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.message);
            this.Name = "frmOther";
            this.Text = "frmOther";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label message;
    }
}