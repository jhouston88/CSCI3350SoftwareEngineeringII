/**********************************************************************
 * This class represents the database connection class.
 * 
 * It passes the connections string of the database,
 * returns the categories, and returns the catagories 
 * species. 
 * 
 * Authors: Josh Houston, Nick McMahon, Eric Blumenstock, 
 * and Tianran Hao
 * 
 * Email: zjah82@goldmail.etsu.edu, mcmahonn@goldmail.etsu.edu,
 * blumenstock@goldmail.etsu.edu, haot01@goldmail.etsu.edu
 * 
**********************************************************************/

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
            this.densityLabel = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.GreenradioButton = new System.Windows.Forms.RadioButton();
            this.TwelveradioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.valueM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equationPicture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // valueM
            // 
            this.valueM.Location = new System.Drawing.Point(121, 51);
            this.valueM.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.valueM.Name = "valueM";
            this.valueM.Size = new System.Drawing.Size(44, 20);
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "%";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // equationPicture
            // 
            this.equationPicture.Image = global::WoodWorksApp.Properties.Resources.densityCalc;
            this.equationPicture.Location = new System.Drawing.Point(32, 154);
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
            // densityLabel
            // 
            this.densityLabel.AutoSize = true;
            this.densityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.densityLabel.Location = new System.Drawing.Point(56, 223);
            this.densityLabel.Name = "densityLabel";
            this.densityLabel.Size = new System.Drawing.Size(26, 16);
            this.densityLabel.TabIndex = 21;
            this.densityLabel.Text = "ρ =";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(92, 222);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(99, 20);
            this.result.TabIndex = 4;
            this.result.Size = new System.Drawing.Size(99, 21);
            this.result.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(100, 248);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 25);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Moisture:";
            // 
            // GreenradioButton
            // 
            this.GreenradioButton.AutoSize = true;
            this.GreenradioButton.Location = new System.Drawing.Point(11, 41);
            this.GreenradioButton.Name = "GreenradioButton";

            this.GreenradioButton.Size = new System.Drawing.Size(54, 17);
            this.GreenradioButton.TabIndex = 3;

            this.GreenradioButton.Size = new System.Drawing.Size(53, 16);
            this.GreenradioButton.TabIndex = 2;

            this.GreenradioButton.Text = "Green";
            this.GreenradioButton.UseVisualStyleBackColor = true;
            // 
            // TwelveradioButton
            // 
            this.TwelveradioButton.AutoSize = true;
            this.TwelveradioButton.Checked = true;
            this.TwelveradioButton.Location = new System.Drawing.Point(11, 17);
            this.TwelveradioButton.Name = "TwelveradioButton";

            this.TwelveradioButton.Size = new System.Drawing.Size(45, 17);
            this.TwelveradioButton.TabIndex = 2;

            this.TwelveradioButton.Size = new System.Drawing.Size(41, 16);
            this.TwelveradioButton.TabIndex = 1;
            this.TwelveradioButton.TabStop = true;

            this.TwelveradioButton.Text = "12%";
            this.TwelveradioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TwelveradioButton);
            this.groupBox1.Controls.Add(this.GreenradioButton);
            this.groupBox1.Location = new System.Drawing.Point(24, 80);
            this.groupBox1.Name = "groupBox1";

            this.groupBox1.Size = new System.Drawing.Size(131, 67);

            this.groupBox1.Size = new System.Drawing.Size(131, 62);

            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moisture Content";
            // 
            // DensityAtMositureContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 306);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.result);
            this.Controls.Add(this.densityLabel);
            this.Controls.Add(this.woodName);
            this.Controls.Add(this.equationPicture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valueM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DensityAtMositureContent";
            this.Text = "Density at Specific Gravity";
            this.Load += new System.EventHandler(this.DensityAtMositureContent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.valueM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equationPicture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown valueM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox equationPicture;
        private System.Windows.Forms.Label woodName;
        private System.Windows.Forms.Label densityLabel;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton GreenradioButton;
        private System.Windows.Forms.RadioButton TwelveradioButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}