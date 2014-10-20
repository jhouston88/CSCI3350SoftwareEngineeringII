namespace WoodWorks
{
    partial class Form1
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
            this.catListBox = new System.Windows.Forms.ListBox();
            this.descripListBox = new System.Windows.Forms.ListBox();
            this.catLabel = new System.Windows.Forms.Label();
            this.speciesLabel = new System.Windows.Forms.Label();
            this.descripLabel = new System.Windows.Forms.Label();
            this.speciesListBox = new System.Windows.Forms.ListBox();
            this.selectCalculationBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // catListBox
            // 
            this.catListBox.FormattingEnabled = true;
            this.catListBox.Location = new System.Drawing.Point(12, 50);
            this.catListBox.Name = "catListBox";
            this.catListBox.Size = new System.Drawing.Size(170, 238);
            this.catListBox.TabIndex = 0;
            this.catListBox.SelectedIndexChanged += new System.EventHandler(this.catListBox_SelectedIndexChanged);
            // 
            // descripListBox
            // 
            this.descripListBox.FormattingEnabled = true;
            this.descripListBox.Location = new System.Drawing.Point(377, 50);
            this.descripListBox.Name = "descripListBox";
            this.descripListBox.Size = new System.Drawing.Size(162, 238);
            this.descripListBox.TabIndex = 2;
            // 
            // catLabel
            // 
            this.catLabel.AutoSize = true;
            this.catLabel.Location = new System.Drawing.Point(12, 30);
            this.catLabel.Name = "catLabel";
            this.catLabel.Size = new System.Drawing.Size(49, 13);
            this.catLabel.TabIndex = 3;
            this.catLabel.Text = "Category";
            // 
            // speciesLabel
            // 
            this.speciesLabel.AutoSize = true;
            this.speciesLabel.Location = new System.Drawing.Point(198, 30);
            this.speciesLabel.Name = "speciesLabel";
            this.speciesLabel.Size = new System.Drawing.Size(45, 13);
            this.speciesLabel.TabIndex = 4;
            this.speciesLabel.Text = "Species";
            // 
            // descripLabel
            // 
            this.descripLabel.AutoSize = true;
            this.descripLabel.Location = new System.Drawing.Point(374, 30);
            this.descripLabel.Name = "descripLabel";
            this.descripLabel.Size = new System.Drawing.Size(60, 13);
            this.descripLabel.TabIndex = 5;
            this.descripLabel.Text = "Description";
            // 
            // speciesListBox
            // 
            this.speciesListBox.FormattingEnabled = true;
            this.speciesListBox.Location = new System.Drawing.Point(201, 50);
            this.speciesListBox.Name = "speciesListBox";
            this.speciesListBox.Size = new System.Drawing.Size(156, 238);
            this.speciesListBox.TabIndex = 6;
            this.speciesListBox.SelectedIndexChanged += new System.EventHandler(this.speciesListBox_SelectedIndexChanged);
            // 
            // selectCalculationBox
            // 
            this.selectCalculationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCalculationBox.FormattingEnabled = true;
            this.selectCalculationBox.Items.AddRange(new object[] {
            "Beam Deflection",
            "Dimensional Change",
            "Density"});
            this.selectCalculationBox.Location = new System.Drawing.Point(192, 333);
            this.selectCalculationBox.Name = "selectCalculationBox";
            this.selectCalculationBox.Size = new System.Drawing.Size(121, 21);
            this.selectCalculationBox.TabIndex = 7;
            this.selectCalculationBox.Text = "Select Calculation";
            this.selectCalculationBox.SelectedIndexChanged += new System.EventHandler(this.selectCalculationBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(594, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 238);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Calculation:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(594, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Image";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 383);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectCalculationBox);
            this.Controls.Add(this.speciesListBox);
            this.Controls.Add(this.descripLabel);
            this.Controls.Add(this.speciesLabel);
            this.Controls.Add(this.catLabel);
            this.Controls.Add(this.descripListBox);
            this.Controls.Add(this.catListBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "WoodWorks";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox catListBox;
        private System.Windows.Forms.ListBox descripListBox;
        private System.Windows.Forms.Label catLabel;
        private System.Windows.Forms.Label speciesLabel;
        private System.Windows.Forms.Label descripLabel;
        private System.Windows.Forms.ListBox speciesListBox;
        private System.Windows.Forms.ComboBox selectCalculationBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    }
}

