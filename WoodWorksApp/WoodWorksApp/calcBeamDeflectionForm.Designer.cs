namespace WoodWorksApp
{
    partial class calcBeamDeflectionForm
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
            this.beamWidthText = new System.Windows.Forms.Label();
            this.beamSpanText = new System.Windows.Forms.Label();
            this.beamDepthText = new System.Windows.Forms.Label();
            this.beamLoadText = new System.Windows.Forms.Label();
            this.beamWidthEntry = new System.Windows.Forms.TextBox();
            this.beamSpanEntry = new System.Windows.Forms.TextBox();
            this.beamDepthEntry = new System.Windows.Forms.TextBox();
            this.beamLoadEntry = new System.Windows.Forms.TextBox();
            this.beamShearCalculation = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // beamWidthText
            // 
            this.beamWidthText.AutoSize = true;
            this.beamWidthText.Location = new System.Drawing.Point(60, 42);
            this.beamWidthText.Name = "beamWidthText";
            this.beamWidthText.Size = new System.Drawing.Size(65, 13);
            this.beamWidthText.TabIndex = 0;
            this.beamWidthText.Text = "Beam Width";
            // 
            // beamSpanText
            // 
            this.beamSpanText.AutoSize = true;
            this.beamSpanText.Location = new System.Drawing.Point(63, 142);
            this.beamSpanText.Name = "beamSpanText";
            this.beamSpanText.Size = new System.Drawing.Size(62, 13);
            this.beamSpanText.TabIndex = 1;
            this.beamSpanText.Text = "Beam Span";
            // 
            // beamDepthText
            // 
            this.beamDepthText.AutoSize = true;
            this.beamDepthText.Location = new System.Drawing.Point(63, 208);
            this.beamDepthText.Name = "beamDepthText";
            this.beamDepthText.Size = new System.Drawing.Size(66, 13);
            this.beamDepthText.TabIndex = 2;
            this.beamDepthText.Text = "Beam Depth";
            // 
            // beamLoadText
            // 
            this.beamLoadText.AutoSize = true;
            this.beamLoadText.Location = new System.Drawing.Point(66, 299);
            this.beamLoadText.Name = "beamLoadText";
            this.beamLoadText.Size = new System.Drawing.Size(61, 13);
            this.beamLoadText.TabIndex = 3;
            this.beamLoadText.Text = "Beam Load";
            // 
            // beamWidthEntry
            // 
            this.beamWidthEntry.Location = new System.Drawing.Point(169, 42);
            this.beamWidthEntry.Name = "beamWidthEntry";
            this.beamWidthEntry.Size = new System.Drawing.Size(100, 20);
            this.beamWidthEntry.TabIndex = 4;
            // 
            // beamSpanEntry
            // 
            this.beamSpanEntry.Location = new System.Drawing.Point(169, 142);
            this.beamSpanEntry.Name = "beamSpanEntry";
            this.beamSpanEntry.Size = new System.Drawing.Size(100, 20);
            this.beamSpanEntry.TabIndex = 5;
            // 
            // beamDepthEntry
            // 
            this.beamDepthEntry.Location = new System.Drawing.Point(160, 208);
            this.beamDepthEntry.Name = "beamDepthEntry";
            this.beamDepthEntry.Size = new System.Drawing.Size(100, 20);
            this.beamDepthEntry.TabIndex = 6;
            // 
            // beamLoadEntry
            // 
            this.beamLoadEntry.Location = new System.Drawing.Point(160, 299);
            this.beamLoadEntry.Name = "beamLoadEntry";
            this.beamLoadEntry.Size = new System.Drawing.Size(100, 20);
            this.beamLoadEntry.TabIndex = 7;
            // 
            // beamShearCalculation
            // 
            this.beamShearCalculation.Location = new System.Drawing.Point(123, 472);
            this.beamShearCalculation.Name = "beamShearCalculation";
            this.beamShearCalculation.ReadOnly = true;
            this.beamShearCalculation.Size = new System.Drawing.Size(100, 20);
            this.beamShearCalculation.TabIndex = 8;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(69, 531);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(223, 531);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // calcBeamDeflectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 575);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.beamShearCalculation);
            this.Controls.Add(this.beamLoadEntry);
            this.Controls.Add(this.beamDepthEntry);
            this.Controls.Add(this.beamSpanEntry);
            this.Controls.Add(this.beamWidthEntry);
            this.Controls.Add(this.beamLoadText);
            this.Controls.Add(this.beamDepthText);
            this.Controls.Add(this.beamSpanText);
            this.Controls.Add(this.beamWidthText);
            this.Name = "calcBeamDeflectionForm";
            this.Text = "calcBeamDeflectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label beamWidthText;
        private System.Windows.Forms.Label beamSpanText;
        private System.Windows.Forms.Label beamDepthText;
        private System.Windows.Forms.Label beamLoadText;
        private System.Windows.Forms.TextBox beamWidthEntry;
        private System.Windows.Forms.TextBox beamSpanEntry;
        private System.Windows.Forms.TextBox beamDepthEntry;
        private System.Windows.Forms.TextBox beamLoadEntry;
        private System.Windows.Forms.TextBox beamShearCalculation;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button backButton;
    }
}