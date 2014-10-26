namespace WoodWorksApp
{
    partial class DimensionalChangeForm
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
            this.woodLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // woodLabel
            // 
            this.woodLabel.AutoSize = true;
            this.woodLabel.Location = new System.Drawing.Point(12, 9);
            this.woodLabel.Name = "woodLabel";
            this.woodLabel.Size = new System.Drawing.Size(59, 13);
            this.woodLabel.TabIndex = 0;
            this.woodLabel.Text = "woodLabel";
            // 
            // DimensionalChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.woodLabel);
            this.Name = "DimensionalChangeForm";
            this.Text = "DimensionalChangeForm";
            this.Load += new System.EventHandler(this.DimensionalChangeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label woodLabel;
    }
}