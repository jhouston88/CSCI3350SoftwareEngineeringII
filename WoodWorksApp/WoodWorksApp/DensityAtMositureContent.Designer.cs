namespace WoodWorksApp
{
    partial class DensityAtMositureContent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DensityAtMositureContent));
            this.mLabel = new System.Windows.Forms.Label();
            this.valueM = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.equationPicture = new System.Windows.Forms.PictureBox();
            this.woodName = new System.Windows.Forms.Label();
            this.moistureContentLabel = new System.Windows.Forms.Label();
            this.moistureContent = new System.Windows.Forms.ComboBox();
            this.densityLabel = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.valueM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equationPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabel.Location = new System.Drawing.Point(102, 72);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(11, 12);
            this.mLabel.TabIndex = 0;
            this.mLabel.Text = "M";
            // 
            // valueM
            // 
            this.valueM.Location = new System.Drawing.Point(119, 70);
            this.valueM.Name = "valueM";
            this.valueM.Size = new System.Drawing.Size(70, 21);
            this.valueM.TabIndex = 1;
            this.valueM.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "%";
            // 
            // equationPicture
            // 
            this.equationPicture.Image = global::WoodWorksApp.Properties.Resources.densityCalc;
            this.equationPicture.Location = new System.Drawing.Point(14, 145);
            this.equationPicture.Name = "equationPicture";
            this.equationPicture.Size = new System.Drawing.Size(211, 57);
            this.equationPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.equationPicture.TabIndex = 3;
            this.equationPicture.TabStop = false;
            // 
            // woodName
            // 
            this.woodName.AutoSize = true;
            this.woodName.Location = new System.Drawing.Point(12, 9);
            this.woodName.Name = "woodName";
            this.woodName.Size = new System.Drawing.Size(53, 12);
            this.woodName.TabIndex = 4;
            this.woodName.Text = "woodName";
            // 
            // moistureContentLabel
            // 
            this.moistureContentLabel.AutoSize = true;
            this.moistureContentLabel.Location = new System.Drawing.Point(12, 102);
            this.moistureContentLabel.Name = "moistureContentLabel";
            this.moistureContentLabel.Size = new System.Drawing.Size(101, 12);
            this.moistureContentLabel.TabIndex = 6;
            this.moistureContentLabel.Text = "Moisture Content";
            // 
            // moistureContent
            // 
            this.moistureContent.AllowDrop = true;
            this.moistureContent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.moistureContent.FormattingEnabled = true;
            this.moistureContent.Items.AddRange(new object[] {
            "12%",
            "Green"});
            this.moistureContent.Location = new System.Drawing.Point(118, 99);
            this.moistureContent.MaxDropDownItems = 2;
            this.moistureContent.Name = "moistureContent";
            this.moistureContent.Size = new System.Drawing.Size(71, 20);
            this.moistureContent.TabIndex = 19;
            // 
            // densityLabel
            // 
            this.densityLabel.AutoSize = true;
            this.densityLabel.Location = new System.Drawing.Point(90, 226);
            this.densityLabel.Name = "densityLabel";
            this.densityLabel.Size = new System.Drawing.Size(23, 12);
            this.densityLabel.TabIndex = 21;
            this.densityLabel.Text = "ρ=";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(117, 221);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(99, 21);
            this.result.TabIndex = 22;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(84, 272);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 23;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // DensityAtMositureContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 307);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.result);
            this.Controls.Add(this.densityLabel);
            this.Controls.Add(this.moistureContent);
            this.Controls.Add(this.moistureContentLabel);
            this.Controls.Add(this.woodName);
            this.Controls.Add(this.equationPicture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valueM);
            this.Controls.Add(this.mLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DensityAtMositureContent";
            this.Text = "Density";
            this.Load += new System.EventHandler(this.DensityAtMositureContent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.valueM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equationPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.NumericUpDown valueM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox equationPicture;
        private System.Windows.Forms.Label woodName;
        private System.Windows.Forms.Label moistureContentLabel;
        private System.Windows.Forms.ComboBox moistureContent;
        private System.Windows.Forms.Label densityLabel;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button calculateButton;
    }
}