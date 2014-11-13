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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calcBeamDeflectionForm));
            this.beamWidthText = new System.Windows.Forms.Label();
            this.beamSpanText = new System.Windows.Forms.Label();
            this.beamDepthText = new System.Windows.Forms.Label();
            this.beamLoadText = new System.Windows.Forms.Label();
            this.beamWidthEntry = new System.Windows.Forms.TextBox();
            this.beamSpanEntry = new System.Windows.Forms.TextBox();
            this.beamDepthEntry = new System.Windows.Forms.TextBox();
            this.beamLoadEntry = new System.Windows.Forms.TextBox();
            this.resultDisplay = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.woodName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioGreen = new System.Windows.Forms.RadioButton();
            this.radioTwelvePct = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioEdge = new System.Windows.Forms.RadioButton();
            this.radioFlat = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // beamWidthText
            // 
            this.beamWidthText.AutoSize = true;
            this.beamWidthText.Location = new System.Drawing.Point(93, 149);
            this.beamWidthText.Name = "beamWidthText";
            this.beamWidthText.Size = new System.Drawing.Size(35, 13);
            this.beamWidthText.TabIndex = 0;
            this.beamWidthText.Text = "Width";
            // 
            // beamSpanText
            // 
            this.beamSpanText.AutoSize = true;
            this.beamSpanText.Location = new System.Drawing.Point(65, 201);
            this.beamSpanText.Name = "beamSpanText";
            this.beamSpanText.Size = new System.Drawing.Size(62, 13);
            this.beamSpanText.TabIndex = 1;
            this.beamSpanText.Text = "Beam Span";
            // 
            // beamDepthText
            // 
            this.beamDepthText.AutoSize = true;
            this.beamDepthText.Location = new System.Drawing.Point(91, 175);
            this.beamDepthText.Name = "beamDepthText";
            this.beamDepthText.Size = new System.Drawing.Size(36, 13);
            this.beamDepthText.TabIndex = 2;
            this.beamDepthText.Text = "Depth";
            // 
            // beamLoadText
            // 
            this.beamLoadText.AutoSize = true;
            this.beamLoadText.Location = new System.Drawing.Point(66, 227);
            this.beamLoadText.Name = "beamLoadText";
            this.beamLoadText.Size = new System.Drawing.Size(61, 13);
            this.beamLoadText.TabIndex = 3;
            this.beamLoadText.Text = "Beam Load";
            // 
            // beamWidthEntry
            // 
            this.beamWidthEntry.Location = new System.Drawing.Point(133, 146);
            this.beamWidthEntry.Name = "beamWidthEntry";
            this.beamWidthEntry.Size = new System.Drawing.Size(46, 20);
            this.beamWidthEntry.TabIndex = 4;
            this.beamWidthEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // beamSpanEntry
            // 
            this.beamSpanEntry.Location = new System.Drawing.Point(133, 198);
            this.beamSpanEntry.Name = "beamSpanEntry";
            this.beamSpanEntry.Size = new System.Drawing.Size(46, 20);
            this.beamSpanEntry.TabIndex = 6;
            this.beamSpanEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // beamDepthEntry
            // 
            this.beamDepthEntry.Location = new System.Drawing.Point(133, 172);
            this.beamDepthEntry.Name = "beamDepthEntry";
            this.beamDepthEntry.Size = new System.Drawing.Size(46, 20);
            this.beamDepthEntry.TabIndex = 5;
            this.beamDepthEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // beamLoadEntry
            // 
            this.beamLoadEntry.Location = new System.Drawing.Point(133, 224);
            this.beamLoadEntry.Name = "beamLoadEntry";
            this.beamLoadEntry.Size = new System.Drawing.Size(46, 20);
            this.beamLoadEntry.TabIndex = 7;
            this.beamLoadEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // resultDisplay
            // 
            this.resultDisplay.AcceptsTab = true;
            this.resultDisplay.Location = new System.Drawing.Point(94, 267);
            this.resultDisplay.Name = "resultDisplay";
            this.resultDisplay.ReadOnly = true;
            this.resultDisplay.Size = new System.Drawing.Size(100, 20);
            this.resultDisplay.TabIndex = 8;
            this.resultDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(104, 293);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(83, 20);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Calculate";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Beam Dimensions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "δ =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "in.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "lb.";
            // 
            // woodName
            // 
            this.woodName.AutoSize = true;
            this.woodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.woodName.Location = new System.Drawing.Point(84, 13);
            this.woodName.Name = "woodName";
            this.woodName.Size = new System.Drawing.Size(109, 17);
            this.woodName.TabIndex = 19;
            this.woodName.Text = "woodNameHere";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "in.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(176, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "in.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WoodWorksApp.Properties.Resources.beamDeflection;
            this.pictureBox2.Location = new System.Drawing.Point(324, 227);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(233, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WoodWorksApp.Properties.Resources.indendpDirctOfWood;
            this.pictureBox1.InitialImage = global::WoodWorksApp.Properties.Resources.indendpDirctOfWood;
            this.pictureBox1.Location = new System.Drawing.Point(256, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioGreen);
            this.groupBox1.Controls.Add(this.radioTwelvePct);
            this.groupBox1.Location = new System.Drawing.Point(133, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 67);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moisture Content";
            // 
            // radioGreen
            // 
            this.radioGreen.AutoSize = true;
            this.radioGreen.Location = new System.Drawing.Point(6, 43);
            this.radioGreen.Name = "radioGreen";
            this.radioGreen.Size = new System.Drawing.Size(54, 17);
            this.radioGreen.TabIndex = 3;
            this.radioGreen.Text = "Green";
            this.radioGreen.UseVisualStyleBackColor = true;
            // 
            // radioTwelvePct
            // 
            this.radioTwelvePct.AutoSize = true;
            this.radioTwelvePct.Checked = true;
            this.radioTwelvePct.Location = new System.Drawing.Point(6, 19);
            this.radioTwelvePct.Name = "radioTwelvePct";
            this.radioTwelvePct.Size = new System.Drawing.Size(45, 17);
            this.radioTwelvePct.TabIndex = 2;
            this.radioTwelvePct.TabStop = true;
            this.radioTwelvePct.Text = "12%";
            this.radioTwelvePct.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioEdge);
            this.groupBox2.Controls.Add(this.radioFlat);
            this.groupBox2.Location = new System.Drawing.Point(39, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(88, 67);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grain Type";
            // 
            // radioEdge
            // 
            this.radioEdge.AutoSize = true;
            this.radioEdge.Location = new System.Drawing.Point(6, 44);
            this.radioEdge.Name = "radioEdge";
            this.radioEdge.Size = new System.Drawing.Size(50, 17);
            this.radioEdge.TabIndex = 1;
            this.radioEdge.Text = "Edge";
            this.radioEdge.UseVisualStyleBackColor = true;
            // 
            // radioFlat
            // 
            this.radioFlat.AutoSize = true;
            this.radioFlat.Checked = true;
            this.radioFlat.Location = new System.Drawing.Point(6, 20);
            this.radioFlat.Name = "radioFlat";
            this.radioFlat.Size = new System.Drawing.Size(42, 17);
            this.radioFlat.TabIndex = 0;
            this.radioFlat.TabStop = true;
            this.radioFlat.Text = "Flat";
            this.radioFlat.UseVisualStyleBackColor = true;
            // 
            // calcBeamDeflectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 338);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.woodName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.resultDisplay);
            this.Controls.Add(this.beamLoadEntry);
            this.Controls.Add(this.beamDepthEntry);
            this.Controls.Add(this.beamSpanEntry);
            this.Controls.Add(this.beamWidthEntry);
            this.Controls.Add(this.beamLoadText);
            this.Controls.Add(this.beamDepthText);
            this.Controls.Add(this.beamSpanText);
            this.Controls.Add(this.beamWidthText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "calcBeamDeflectionForm";
            this.Text = "Beam Deflection";
            this.Load += new System.EventHandler(this.calcBeamDeflectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.TextBox resultDisplay;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label woodName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioTwelvePct;
        private System.Windows.Forms.RadioButton radioGreen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioEdge;
        private System.Windows.Forms.RadioButton radioFlat;
    }
}