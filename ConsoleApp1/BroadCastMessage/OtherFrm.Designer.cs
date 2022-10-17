namespace BroadCastMessage
{
    partial class OtherFrm
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
            this.btn_other = new System.Windows.Forms.Button();
            this.OtherLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_other
            // 
            this.btn_other.Location = new System.Drawing.Point(144, 143);
            this.btn_other.Name = "btn_other";
            this.btn_other.Size = new System.Drawing.Size(114, 29);
            this.btn_other.TabIndex = 0;
            this.btn_other.Text = "sendToMain";
            this.btn_other.UseVisualStyleBackColor = true;
            this.btn_other.Click += new System.EventHandler(this.btn_other_Click);
            // 
            // OtherLabel
            // 
            this.OtherLabel.AutoSize = true;
            this.OtherLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OtherLabel.Location = new System.Drawing.Point(144, 80);
            this.OtherLabel.Name = "OtherLabel";
            this.OtherLabel.Size = new System.Drawing.Size(31, 35);
            this.OtherLabel.TabIndex = 1;
            this.OtherLabel.Text = "0";
            this.OtherLabel.Click += new System.EventHandler(this.OtherLabel_Click);
            // 
            // OtherFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 246);
            this.Controls.Add(this.OtherLabel);
            this.Controls.Add(this.btn_other);
            this.Name = "OtherFrm";
            this.Text = "OtherFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_other;
        private Label OtherLabel;
    }
}