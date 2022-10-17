namespace BroadCastMessage
{
    partial class MainFrm
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
            this.MainLabel = new System.Windows.Forms.Label();
            this.btn_main = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainLabel.Location = new System.Drawing.Point(128, 65);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(31, 35);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "0";
            // 
            // btn_main
            // 
            this.btn_main.Location = new System.Drawing.Point(128, 135);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(117, 29);
            this.btn_main.TabIndex = 1;
            this.btn_main.Text = "sendToOther";
            this.btn_main.UseVisualStyleBackColor = true;
            this.btn_main.Click += new System.EventHandler(this.btn_main_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 219);
            this.Controls.Add(this.btn_main);
            this.Controls.Add(this.MainLabel);
            this.Name = "MainFrm";
            this.Text = "MainFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label MainLabel;
        private Button btn_main;
    }
}