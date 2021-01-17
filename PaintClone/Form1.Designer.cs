
namespace PaintClone
{
    partial class PaintClone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintClone));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorStrip = new System.Windows.Forms.ToolStrip();
            this.RedButton = new System.Windows.Forms.ToolStripButton();
            this.GreenButton = new System.Windows.Forms.ToolStripButton();
            this.BlueButton = new System.Windows.Forms.ToolStripButton();
            this.YellowButton = new System.Windows.Forms.ToolStripButton();
            this.BlackButton = new System.Windows.Forms.ToolStripButton();
            this.WhiteButton = new System.Windows.Forms.ToolStripButton();
            this.canvasBox = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            this.colorStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip.Font = new System.Drawing.Font("Eurostile Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 26);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.saveImageAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // saveImageAsToolStripMenuItem
            // 
            this.saveImageAsToolStripMenuItem.Name = "saveImageAsToolStripMenuItem";
            this.saveImageAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveImageAsToolStripMenuItem.Text = "Exit";
            this.saveImageAsToolStripMenuItem.Click += new System.EventHandler(this.saveImageAsToolStripMenuItem_Click);
            // 
            // colorStrip
            // 
            this.colorStrip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.colorStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RedButton,
            this.GreenButton,
            this.BlueButton,
            this.YellowButton,
            this.BlackButton,
            this.WhiteButton});
            this.colorStrip.Location = new System.Drawing.Point(0, 26);
            this.colorStrip.Name = "colorStrip";
            this.colorStrip.Size = new System.Drawing.Size(800, 25);
            this.colorStrip.TabIndex = 1;
            this.colorStrip.Text = "toolStrip1";
            // 
            // RedButton
            // 
            this.RedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RedButton.Font = new System.Drawing.Font("Eurostile Extended", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedButton.ForeColor = System.Drawing.Color.Red;
            this.RedButton.Image = ((System.Drawing.Image)(resources.GetObject("RedButton.Image")));
            this.RedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(43, 22);
            this.RedButton.Text = "Red";
            this.RedButton.Click += new System.EventHandler(this.RedButton_Click);
            // 
            // GreenButton
            // 
            this.GreenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.GreenButton.Font = new System.Drawing.Font("Eurostile Extended", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenButton.ForeColor = System.Drawing.Color.Green;
            this.GreenButton.Image = ((System.Drawing.Image)(resources.GetObject("GreenButton.Image")));
            this.GreenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(61, 22);
            this.GreenButton.Text = "Green";
            this.GreenButton.Click += new System.EventHandler(this.GreenButton_Click);
            // 
            // BlueButton
            // 
            this.BlueButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BlueButton.Font = new System.Drawing.Font("Eurostile Extended", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueButton.ForeColor = System.Drawing.Color.Blue;
            this.BlueButton.Image = ((System.Drawing.Image)(resources.GetObject("BlueButton.Image")));
            this.BlueButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.Size = new System.Drawing.Size(45, 22);
            this.BlueButton.Text = "Blue";
            this.BlueButton.Click += new System.EventHandler(this.BlueButton_Click);
            // 
            // YellowButton
            // 
            this.YellowButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.YellowButton.Font = new System.Drawing.Font("Eurostile Extended", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YellowButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.YellowButton.Image = ((System.Drawing.Image)(resources.GetObject("YellowButton.Image")));
            this.YellowButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.YellowButton.Name = "YellowButton";
            this.YellowButton.Size = new System.Drawing.Size(60, 22);
            this.YellowButton.Text = "Yellow";
            this.YellowButton.Click += new System.EventHandler(this.YellowButton_Click);
            // 
            // BlackButton
            // 
            this.BlackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BlackButton.Font = new System.Drawing.Font("Eurostile Extended", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlackButton.ForeColor = System.Drawing.Color.Black;
            this.BlackButton.Image = ((System.Drawing.Image)(resources.GetObject("BlackButton.Image")));
            this.BlackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BlackButton.Name = "BlackButton";
            this.BlackButton.Size = new System.Drawing.Size(52, 22);
            this.BlackButton.Text = "Black";
            this.BlackButton.ToolTipText = "Black";
            this.BlackButton.Click += new System.EventHandler(this.BlackButton_Click);
            // 
            // WhiteButton
            // 
            this.WhiteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.WhiteButton.Font = new System.Drawing.Font("Eurostile Extended", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhiteButton.ForeColor = System.Drawing.Color.Gray;
            this.WhiteButton.Image = ((System.Drawing.Image)(resources.GetObject("WhiteButton.Image")));
            this.WhiteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.WhiteButton.Name = "WhiteButton";
            this.WhiteButton.Size = new System.Drawing.Size(59, 22);
            this.WhiteButton.Text = "White";
            this.WhiteButton.Click += new System.EventHandler(this.WhiteButton_Click);
            // 
            // canvasBox
            // 
            this.canvasBox.BackColor = System.Drawing.Color.Azure;
            this.canvasBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasBox.Location = new System.Drawing.Point(0, 51);
            this.canvasBox.Name = "canvasBox";
            this.canvasBox.Size = new System.Drawing.Size(800, 399);
            this.canvasBox.TabIndex = 2;
            this.canvasBox.TabStop = false;
            this.canvasBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CanvasBox_MouseDown);
            this.canvasBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CanvasBox_MouseMove);
            this.canvasBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CanvasBox_MouseDown);
            // 
            // PaintClone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.canvasBox);
            this.Controls.Add(this.colorStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "PaintClone";
            this.Text = "PaintClone";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.colorStrip.ResumeLayout(false);
            this.colorStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageAsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip colorStrip;
        private System.Windows.Forms.ToolStripButton RedButton;
        private System.Windows.Forms.ToolStripButton GreenButton;
        private System.Windows.Forms.ToolStripButton BlueButton;
        private System.Windows.Forms.ToolStripButton YellowButton;
        private System.Windows.Forms.ToolStripButton BlackButton;
        private System.Windows.Forms.ToolStripButton WhiteButton;
        private System.Windows.Forms.PictureBox canvasBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

