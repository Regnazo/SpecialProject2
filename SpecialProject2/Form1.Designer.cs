namespace SpecialProject2
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
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ColorButton = new System.Windows.Forms.Button();
            this.XCord = new System.Windows.Forms.Label();
            this.YCord = new System.Windows.Forms.Label();
            this.ShapeWidth = new System.Windows.Forms.Label();
            this.ShapeHeight = new System.Windows.Forms.Label();
            this.XText = new System.Windows.Forms.TextBox();
            this.YText = new System.Windows.Forms.TextBox();
            this.WidthText = new System.Windows.Forms.TextBox();
            this.HeightText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DrawingPanel.Location = new System.Drawing.Point(128, 0);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(660, 438);
            this.DrawingPanel.TabIndex = 4;
            this.DrawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPanel_Paint);
            this.DrawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseDown);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(1, 67);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(121, 44);
            this.ColorButton.TabIndex = 6;
            this.ColorButton.Text = "Color";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // XCord
            // 
            this.XCord.AutoSize = true;
            this.XCord.Location = new System.Drawing.Point(19, 121);
            this.XCord.Name = "XCord";
            this.XCord.Size = new System.Drawing.Size(15, 16);
            this.XCord.TabIndex = 7;
            this.XCord.Text = "X";
            // 
            // YCord
            // 
            this.YCord.AutoSize = true;
            this.YCord.Location = new System.Drawing.Point(69, 121);
            this.YCord.Name = "YCord";
            this.YCord.Size = new System.Drawing.Size(16, 16);
            this.YCord.TabIndex = 8;
            this.YCord.Text = "Y";
            // 
            // ShapeWidth
            // 
            this.ShapeWidth.AutoSize = true;
            this.ShapeWidth.Location = new System.Drawing.Point(10, 165);
            this.ShapeWidth.Name = "ShapeWidth";
            this.ShapeWidth.Size = new System.Drawing.Size(41, 16);
            this.ShapeWidth.TabIndex = 9;
            this.ShapeWidth.Text = "Width";
            // 
            // ShapeHeight
            // 
            this.ShapeHeight.AutoSize = true;
            this.ShapeHeight.Location = new System.Drawing.Point(66, 165);
            this.ShapeHeight.Name = "ShapeHeight";
            this.ShapeHeight.Size = new System.Drawing.Size(46, 16);
            this.ShapeHeight.TabIndex = 10;
            this.ShapeHeight.Text = "Height";
            // 
            // XText
            // 
            this.XText.Location = new System.Drawing.Point(2, 140);
            this.XText.Name = "XText";
            this.XText.Size = new System.Drawing.Size(52, 22);
            this.XText.TabIndex = 12;
            // 
            // YText
            // 
            this.YText.Location = new System.Drawing.Point(60, 140);
            this.YText.Name = "YText";
            this.YText.Size = new System.Drawing.Size(52, 22);
            this.YText.TabIndex = 13;
            // 
            // WidthText
            // 
            this.WidthText.Location = new System.Drawing.Point(2, 184);
            this.WidthText.Name = "WidthText";
            this.WidthText.Size = new System.Drawing.Size(52, 22);
            this.WidthText.TabIndex = 14;
            // 
            // HeightText
            // 
            this.HeightText.Location = new System.Drawing.Point(57, 184);
            this.HeightText.Name = "HeightText";
            this.HeightText.Size = new System.Drawing.Size(55, 22);
            this.HeightText.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HeightText);
            this.Controls.Add(this.WidthText);
            this.Controls.Add(this.YText);
            this.Controls.Add(this.XText);
            this.Controls.Add(this.ShapeHeight);
            this.Controls.Add(this.ShapeWidth);
            this.Controls.Add(this.YCord);
            this.Controls.Add(this.XCord);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DrawingPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Label XCord;
        private System.Windows.Forms.Label YCord;
        private System.Windows.Forms.Label ShapeWidth;
        private System.Windows.Forms.Label ShapeHeight;
        private System.Windows.Forms.TextBox XText;
        private System.Windows.Forms.TextBox YText;
        private System.Windows.Forms.TextBox WidthText;
        private System.Windows.Forms.TextBox HeightText;
    }
}

