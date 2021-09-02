namespace WAFDoubleFrame
{
    partial class FormDashboard
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
            this.labelds = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelds
            // 
            this.labelds.AutoSize = true;
            this.labelds.Location = new System.Drawing.Point(199, 76);
            this.labelds.Name = "labelds";
            this.labelds.Size = new System.Drawing.Size(66, 17);
            this.labelds.TabIndex = 0;
            this.labelds.Text = "Welcome";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.labelds);
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDashboard_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelds;
    }
}