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
            this.label1 = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.radialRadioButton = new System.Windows.Forms.RadioButton();
            this.tangentialradioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Width:";
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(57, 36);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 20);
            this.widthTextBox.TabIndex = 0;
            this.widthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "△D:";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(59, 138);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(100, 20);
            this.resultTextBox.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(58, 162);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // radialRadioButton
            // 
            this.radialRadioButton.AutoSize = true;
            this.radialRadioButton.Checked = true;
            this.radialRadioButton.Location = new System.Drawing.Point(6, 19);
            this.radialRadioButton.Name = "radialRadioButton";
            this.radialRadioButton.Size = new System.Drawing.Size(55, 17);
            this.radialRadioButton.TabIndex = 5;
            this.radialRadioButton.TabStop = true;
            this.radialRadioButton.Text = "Radial";
            this.radialRadioButton.UseVisualStyleBackColor = true;
            // 
            // tangentialradioButton
            // 
            this.tangentialradioButton.AutoSize = true;
            this.tangentialradioButton.Location = new System.Drawing.Point(6, 42);
            this.tangentialradioButton.Name = "tangentialradioButton";
            this.tangentialradioButton.Size = new System.Drawing.Size(75, 17);
            this.tangentialradioButton.TabIndex = 6;
            this.tangentialradioButton.Text = "Tangential";
            this.tangentialradioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radialRadioButton);
            this.groupBox1.Controls.Add(this.tangentialradioButton);
            this.groupBox1.Location = new System.Drawing.Point(16, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 70);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grain Direction";
            // 
            // DimensionalChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 192);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.woodLabel);
            this.Name = "DimensionalChangeForm";
            this.Text = "DimensionalChangeForm";
            this.Load += new System.EventHandler(this.DimensionalChangeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label woodLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.RadioButton radialRadioButton;
        private System.Windows.Forms.RadioButton tangentialradioButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}