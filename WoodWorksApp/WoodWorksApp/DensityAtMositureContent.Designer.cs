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
            this.valueM = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.equationPicture = new System.Windows.Forms.PictureBox();
            this.woodName = new System.Windows.Forms.Label();
            this.moistureContentLabel = new System.Windows.Forms.Label();
            this.moistureContent = new System.Windows.Forms.ComboBox();
            this.densityLabel = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.valueM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equationPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // valueM
            // 
            this.valueM.Location = new System.Drawing.Point(119, 76);
            this.valueM.Name = "valueM";
            this.valueM.Size = new System.Drawing.Size(70, 20);
            this.valueM.TabIndex = 0;
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
            this.label2.Location = new System.Drawing.Point(187, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "%";
            // 
            // equationPicture
            // 
            this.equationPicture.Image = global::WoodWorksApp.Properties.Resources.densityCalc;
            this.equationPicture.Location = new System.Drawing.Point(14, 157);
            this.equationPicture.Name = "equationPicture";
            this.equationPicture.Size = new System.Drawing.Size(211, 62);
            this.equationPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.equationPicture.TabIndex = 3;
            this.equationPicture.TabStop = false;
            // 
            // woodName
            // 
            this.woodName.AutoSize = true;
            this.woodName.Location = new System.Drawing.Point(12, 10);
            this.woodName.Name = "woodName";
            this.woodName.Size = new System.Drawing.Size(61, 13);
            this.woodName.TabIndex = 4;
            this.woodName.Text = "woodName";
            // 
            // moistureContentLabel
            // 
            this.moistureContentLabel.AutoSize = true;
            this.moistureContentLabel.Location = new System.Drawing.Point(12, 111);
            this.moistureContentLabel.Name = "moistureContentLabel";
            this.moistureContentLabel.Size = new System.Drawing.Size(87, 13);
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
            this.moistureContent.Location = new System.Drawing.Point(118, 107);
            this.moistureContent.MaxDropDownItems = 2;
            this.moistureContent.Name = "moistureContent";
            this.moistureContent.Size = new System.Drawing.Size(71, 21);
            this.moistureContent.TabIndex = 1;
            // 
            // densityLabel
            // 
            this.densityLabel.AutoSize = true;
            this.densityLabel.Location = new System.Drawing.Point(90, 245);
            this.densityLabel.Name = "densityLabel";
            this.densityLabel.Size = new System.Drawing.Size(19, 13);
            this.densityLabel.TabIndex = 21;
            this.densityLabel.Text = "ρ=";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(117, 239);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(99, 20);
            this.result.TabIndex = 2;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(84, 295);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 25);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Moisture (M)";
            // 
            // DensityAtMositureContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 338);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.result);
            this.Controls.Add(this.densityLabel);
            this.Controls.Add(this.moistureContent);
            this.Controls.Add(this.moistureContentLabel);
            this.Controls.Add(this.woodName);
            this.Controls.Add(this.equationPicture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valueM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DensityAtMositureContent";
            this.Text = "Density";
            this.Load += new System.EventHandler(this.DensityAtMositureContent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.valueM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equationPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown valueM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox equationPicture;
        private System.Windows.Forms.Label woodName;
        private System.Windows.Forms.Label moistureContentLabel;
        private System.Windows.Forms.ComboBox moistureContent;
        private System.Windows.Forms.Label densityLabel;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label1;
    }
}