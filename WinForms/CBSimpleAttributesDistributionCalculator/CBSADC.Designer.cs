namespace CBSimpleAttributesDistributionCalculator
{
    partial class CBSLDC
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
            strengthNumericUpDown = new BetterNumericUpDown(false);
            agilityNumericUpDown = new BetterNumericUpDown(false);
            armourNumericUpDown = new BetterNumericUpDown(false);
            thoughnessNumericUpDown = new BetterNumericUpDown(false);
            pointsProgressNumericUpDown = new BetterNumericUpDown(true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CBSLDC));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.strengthLabel = new System.Windows.Forms.Label();
            this.agilityLabel = new System.Windows.Forms.Label();
            this.armourLabel = new System.Windows.Forms.Label();
            this.thoughnessLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.autoAdjustButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.strengthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agilityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armourNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoughnessNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsProgressNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // strengthNumericUpDown
            // 
            this.strengthNumericUpDown.Location = new System.Drawing.Point(155, 33);
            this.strengthNumericUpDown.Name = "strengthNumericUpDown";
            this.strengthNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.strengthNumericUpDown.TabIndex = 2;
            this.strengthNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.strengthNumericUpDown.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.strengthNumericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDownAll_ValueChanged);
            // 
            // agilityNumericUpDown
            // 
            this.agilityNumericUpDown.Location = new System.Drawing.Point(155, 59);
            this.agilityNumericUpDown.Name = "agilityNumericUpDown";
            this.agilityNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.agilityNumericUpDown.TabIndex = 3;
            this.agilityNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.agilityNumericUpDown.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.agilityNumericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDownAll_ValueChanged);
            // 
            // armourNumericUpDown
            // 
            this.armourNumericUpDown.Location = new System.Drawing.Point(155, 85);
            this.armourNumericUpDown.Name = "armourNumericUpDown";
            this.armourNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.armourNumericUpDown.TabIndex = 4;
            this.armourNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.armourNumericUpDown.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.armourNumericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDownAll_ValueChanged);
            // 
            // thoughnessNumericUpDown
            // 
            this.thoughnessNumericUpDown.Location = new System.Drawing.Point(155, 111);
            this.thoughnessNumericUpDown.Name = "thoughnessNumericUpDown";
            this.thoughnessNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.thoughnessNumericUpDown.TabIndex = 5;
            this.thoughnessNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.thoughnessNumericUpDown.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.thoughnessNumericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDownAll_ValueChanged);
            // 
            // pointsProgressNumericUpDown
            // 
            this.pointsProgressNumericUpDown.Location = new System.Drawing.Point(155, 196);
            this.pointsProgressNumericUpDown.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.pointsProgressNumericUpDown.Minimum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.pointsProgressNumericUpDown.Name = "pointsProgressNumericUpDown";
            this.pointsProgressNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.pointsProgressNumericUpDown.TabIndex = 12;
            this.pointsProgressNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pointsProgressNumericUpDown.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.pointsProgressNumericUpDown.ValueChanged += new System.EventHandler(this.LevelNumericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(46, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Strength";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(46, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Agility";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(46, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Armour";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(46, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Thoughness";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(46, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Points Progress";
            // 
            // strengthLabel
            // 
            this.strengthLabel.AutoSize = true;
            this.strengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strengthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.strengthLabel.Location = new System.Drawing.Point(230, 33);
            this.strengthLabel.Name = "strengthLabel";
            this.strengthLabel.Size = new System.Drawing.Size(29, 20);
            this.strengthLabel.TabIndex = 13;
            this.strengthLabel.Text = "17";
            // 
            // agilityLabel
            // 
            this.agilityLabel.AutoSize = true;
            this.agilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agilityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.agilityLabel.Location = new System.Drawing.Point(230, 59);
            this.agilityLabel.Name = "agilityLabel";
            this.agilityLabel.Size = new System.Drawing.Size(29, 20);
            this.agilityLabel.TabIndex = 14;
            this.agilityLabel.Text = "17";
            // 
            // armourLabel
            // 
            this.armourLabel.AutoSize = true;
            this.armourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.armourLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.armourLabel.Location = new System.Drawing.Point(230, 85);
            this.armourLabel.Name = "armourLabel";
            this.armourLabel.Size = new System.Drawing.Size(29, 20);
            this.armourLabel.TabIndex = 15;
            this.armourLabel.Text = "17";
            // 
            // thoughnessLabel
            // 
            this.thoughnessLabel.AutoSize = true;
            this.thoughnessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoughnessLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.thoughnessLabel.Location = new System.Drawing.Point(230, 111);
            this.thoughnessLabel.Name = "thoughnessLabel";
            this.thoughnessLabel.Size = new System.Drawing.Size(29, 20);
            this.thoughnessLabel.TabIndex = 16;
            this.thoughnessLabel.Text = "17";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(151, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Mywk - TechCoders.Net © 2019";
            this.label11.Click += new System.EventHandler(this.Label11_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.infoLabel.Location = new System.Drawing.Point(28, 157);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(16, 13);
            this.infoLabel.TabIndex = 18;
            this.infoLabel.Text = "...";
            // 
            // autoAdjustButton
            // 
            this.autoAdjustButton.Location = new System.Drawing.Point(217, 152);
            this.autoAdjustButton.Name = "autoAdjustButton";
            this.autoAdjustButton.Size = new System.Drawing.Size(75, 23);
            this.autoAdjustButton.TabIndex = 19;
            this.autoAdjustButton.Text = "Auto Adjust";
            this.autoAdjustButton.UseVisualStyleBackColor = true;
            this.autoAdjustButton.Visible = false;
            this.autoAdjustButton.Click += new System.EventHandler(this.AutoAdjustButton_Click);
            // 
            // CBSLDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 259);
            this.Controls.Add(this.autoAdjustButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.thoughnessLabel);
            this.Controls.Add(this.armourLabel);
            this.Controls.Add(this.agilityLabel);
            this.Controls.Add(this.strengthLabel);
            this.Controls.Add(this.pointsProgressNumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thoughnessNumericUpDown);
            this.Controls.Add(this.armourNumericUpDown);
            this.Controls.Add(this.agilityNumericUpDown);
            this.Controls.Add(this.strengthNumericUpDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CBSLDC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CB - Simple Attributes Distribution Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.strengthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agilityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armourNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoughnessNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsProgressNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private BetterNumericUpDown strengthNumericUpDown;
        private BetterNumericUpDown agilityNumericUpDown;
        private BetterNumericUpDown armourNumericUpDown;
        private BetterNumericUpDown thoughnessNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label strengthLabel;
        private System.Windows.Forms.Label agilityLabel;
        private System.Windows.Forms.Label armourLabel;
        private System.Windows.Forms.Label thoughnessLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button autoAdjustButton;
        private BetterNumericUpDown pointsProgressNumericUpDown;
    }
}

