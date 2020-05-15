namespace ImageEditor
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
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.CropButton = new System.Windows.Forms.Button();
            this.MakeSelectionButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.UpDownBrightness = new System.Windows.Forms.DomainUpDown();
            this.TrackBarBrightness = new System.Windows.Forms.TrackBar();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ModifiedSizeLabel = new System.Windows.Forms.TextBox();
            this.DomainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.OriginalSizeLabel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBrightness)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(47, 68);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(429, 360);
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown_1);
            this.PictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove_1);
            this.PictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp_1);
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tabPage3);
            this.TabControl1.Controls.Add(this.tabPage2);
            this.TabControl1.Controls.Add(this.tabPage1);
            this.TabControl1.Location = new System.Drawing.Point(566, 243);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(413, 185);
            this.TabControl1.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.CropButton);
            this.tabPage3.Controls.Add(this.MakeSelectionButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(405, 159);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Crop";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // CropButton
            // 
            this.CropButton.Enabled = false;
            this.CropButton.Location = new System.Drawing.Point(183, 62);
            this.CropButton.Name = "CropButton";
            this.CropButton.Size = new System.Drawing.Size(115, 23);
            this.CropButton.TabIndex = 1;
            this.CropButton.Text = "Crop";
            this.CropButton.UseVisualStyleBackColor = true;
            this.CropButton.Click += new System.EventHandler(this.CropButton_Click);
            // 
            // MakeSelectionButton
            // 
            this.MakeSelectionButton.Location = new System.Drawing.Point(36, 62);
            this.MakeSelectionButton.Name = "MakeSelectionButton";
            this.MakeSelectionButton.Size = new System.Drawing.Size(115, 23);
            this.MakeSelectionButton.TabIndex = 0;
            this.MakeSelectionButton.Text = "Make selection";
            this.MakeSelectionButton.UseVisualStyleBackColor = true;
            this.MakeSelectionButton.Click += new System.EventHandler(this.MakeSelectionButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.UpDownBrightness);
            this.tabPage2.Controls.Add(this.TrackBarBrightness);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(405, 159);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Brightness";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // UpDownBrightness
            // 
            this.UpDownBrightness.Location = new System.Drawing.Point(160, 57);
            this.UpDownBrightness.Name = "UpDownBrightness";
            this.UpDownBrightness.Size = new System.Drawing.Size(120, 20);
            this.UpDownBrightness.TabIndex = 1;
            this.UpDownBrightness.Text = "domainUpDown2";
            // 
            // TrackBarBrightness
            // 
            this.TrackBarBrightness.Location = new System.Drawing.Point(32, 46);
            this.TrackBarBrightness.Maximum = 100;
            this.TrackBarBrightness.Minimum = -100;
            this.TrackBarBrightness.Name = "TrackBarBrightness";
            this.TrackBarBrightness.Size = new System.Drawing.Size(104, 45);
            this.TrackBarBrightness.TabIndex = 0;
            this.TrackBarBrightness.Scroll += new System.EventHandler(this.TrackBarBrightness_Scroll);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.ModifiedSizeLabel);
            this.tabPage1.Controls.Add(this.DomainUpDown1);
            this.tabPage1.Controls.Add(this.OriginalSizeLabel);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(405, 159);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Resize";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Resize";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(105, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(15, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Percnentage of original height and width";
            // 
            // ModifiedSizeLabel
            // 
            this.ModifiedSizeLabel.Location = new System.Drawing.Point(116, 108);
            this.ModifiedSizeLabel.Name = "ModifiedSizeLabel";
            this.ModifiedSizeLabel.Size = new System.Drawing.Size(164, 20);
            this.ModifiedSizeLabel.TabIndex = 3;
            // 
            // DomainUpDown1
            // 
            this.DomainUpDown1.Location = new System.Drawing.Point(14, 42);
            this.DomainUpDown1.Name = "DomainUpDown1";
            this.DomainUpDown1.Size = new System.Drawing.Size(85, 20);
            this.DomainUpDown1.TabIndex = 2;
            this.DomainUpDown1.Text = "DomainUpDown1";
            this.DomainUpDown1.SelectedItemChanged += new System.EventHandler(this.DomainUpDown1_SelectedItemChanged_1);
            // 
            // OriginalSizeLabel
            // 
            this.OriginalSizeLabel.Location = new System.Drawing.Point(116, 77);
            this.OriginalSizeLabel.Name = "OriginalSizeLabel";
            this.OriginalSizeLabel.Size = new System.Drawing.Size(164, 20);
            this.OriginalSizeLabel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modified size:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Original size:";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(13, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.openToolStripMenuItem.Text = "open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click_1);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.saveToolStripMenuItem.Text = "save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.exitToolStripMenuItem.Text = "exit";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1147, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(566, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(413, 143);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(828, 464);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 56);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Not able to detect";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(570, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 56);
            this.button2.TabIndex = 7;
            this.button2.Text = "Run Image Recognition";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 592);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBrightness)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ModifiedSizeLabel;
        private System.Windows.Forms.DomainUpDown DomainUpDown1;
        private System.Windows.Forms.TextBox OriginalSizeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DomainUpDown UpDownBrightness;
        private System.Windows.Forms.TrackBar TrackBarBrightness;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button CropButton;
        private System.Windows.Forms.Button MakeSelectionButton;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}

