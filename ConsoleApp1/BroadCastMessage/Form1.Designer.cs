namespace BroadCastMessage
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
            this.CreateMainFrm = new System.Windows.Forms.Button();
            this.CreateOtherFrm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateMainFrm
            // 
            this.CreateMainFrm.Location = new System.Drawing.Point(135, 250);
            this.CreateMainFrm.Name = "CreateMainFrm";
            this.CreateMainFrm.Size = new System.Drawing.Size(121, 29);
            this.CreateMainFrm.TabIndex = 0;
            this.CreateMainFrm.Text = "addMainFrm";
            this.CreateMainFrm.UseVisualStyleBackColor = true;
            this.CreateMainFrm.Click += new System.EventHandler(this.CreateMainFrm_Click);
            // 
            // CreateOtherFrm
            // 
            this.CreateOtherFrm.Location = new System.Drawing.Point(293, 250);
            this.CreateOtherFrm.Name = "CreateOtherFrm";
            this.CreateOtherFrm.Size = new System.Drawing.Size(125, 29);
            this.CreateOtherFrm.TabIndex = 1;
            this.CreateOtherFrm.Text = "addOtherFrm";
            this.CreateOtherFrm.UseVisualStyleBackColor = true;
            this.CreateOtherFrm.Click += new System.EventHandler(this.CreateOtherFrm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateOtherFrm);
            this.Controls.Add(this.CreateMainFrm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button CreateMainFrm;
        private Button CreateOtherFrm;
    }
}