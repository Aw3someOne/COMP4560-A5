namespace Assignment5
{
    partial class Gui
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.upToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scaleUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scaleDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shearRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shearLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotXInfinityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderPanel1 = new Assignment5.RenderPanel();
            this.rotYInfinityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotZInfinityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(173, 38);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(173, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(179, 38);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upToolStripMenuItem,
            this.downToolStripMenuItem,
            this.leftToolStripMenuItem,
            this.rightToolStripMenuItem,
            this.scaleUpToolStripMenuItem,
            this.scaleDownToolStripMenuItem,
            this.rotXToolStripMenuItem,
            this.rotYToolStripMenuItem,
            this.rotZToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.shearRightToolStripMenuItem,
            this.shearLeftToolStripMenuItem,
            this.rotXInfinityToolStripMenuItem,
            this.rotYInfinityToolStripMenuItem,
            this.rotZInfinityToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(784, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(190, 929);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // upToolStripMenuItem
            // 
            this.upToolStripMenuItem.Name = "upToolStripMenuItem";
            this.upToolStripMenuItem.Size = new System.Drawing.Size(177, 36);
            this.upToolStripMenuItem.Text = "↑";
            // 
            // downToolStripMenuItem
            // 
            this.downToolStripMenuItem.Name = "downToolStripMenuItem";
            this.downToolStripMenuItem.Size = new System.Drawing.Size(177, 36);
            this.downToolStripMenuItem.Text = "↓";
            // 
            // leftToolStripMenuItem
            // 
            this.leftToolStripMenuItem.Name = "leftToolStripMenuItem";
            this.leftToolStripMenuItem.Size = new System.Drawing.Size(177, 36);
            this.leftToolStripMenuItem.Text = "←";
            // 
            // rightToolStripMenuItem
            // 
            this.rightToolStripMenuItem.Name = "rightToolStripMenuItem";
            this.rightToolStripMenuItem.Size = new System.Drawing.Size(177, 36);
            this.rightToolStripMenuItem.Text = "→";
            // 
            // scaleUpToolStripMenuItem
            // 
            this.scaleUpToolStripMenuItem.Name = "scaleUpToolStripMenuItem";
            this.scaleUpToolStripMenuItem.Size = new System.Drawing.Size(177, 36);
            this.scaleUpToolStripMenuItem.Text = "+";
            // 
            // scaleDownToolStripMenuItem
            // 
            this.scaleDownToolStripMenuItem.Name = "scaleDownToolStripMenuItem";
            this.scaleDownToolStripMenuItem.Size = new System.Drawing.Size(177, 36);
            this.scaleDownToolStripMenuItem.Text = "–";
            // 
            // rotXToolStripMenuItem
            // 
            this.rotXToolStripMenuItem.Name = "rotXToolStripMenuItem";
            this.rotXToolStripMenuItem.Size = new System.Drawing.Size(177, 36);
            this.rotXToolStripMenuItem.Text = "⤺x";
            // 
            // rotYToolStripMenuItem
            // 
            this.rotYToolStripMenuItem.Name = "rotYToolStripMenuItem";
            this.rotYToolStripMenuItem.Size = new System.Drawing.Size(177, 36);
            this.rotYToolStripMenuItem.Text = "⤺y";
            // 
            // rotZToolStripMenuItem
            // 
            this.rotZToolStripMenuItem.Name = "rotZToolStripMenuItem";
            this.rotZToolStripMenuItem.Size = new System.Drawing.Size(177, 36);
            this.rotZToolStripMenuItem.Text = "⤺z";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(177, 36);
            this.resetToolStripMenuItem.Text = "Reset";
            // 
            // shearRightToolStripMenuItem
            // 
            this.shearRightToolStripMenuItem.Name = "shearRightToolStripMenuItem";
            this.shearRightToolStripMenuItem.Size = new System.Drawing.Size(177, 36);
            this.shearRightToolStripMenuItem.Text = "□→";
            // 
            // shearLeftToolStripMenuItem
            // 
            this.shearLeftToolStripMenuItem.Name = "shearLeftToolStripMenuItem";
            this.shearLeftToolStripMenuItem.Size = new System.Drawing.Size(177, 36);
            this.shearLeftToolStripMenuItem.Text = "←□";
            // 
            // rotXInfinityToolStripMenuItem
            // 
            this.rotXInfinityToolStripMenuItem.Name = "rotXInfinityToolStripMenuItem";
            this.rotXInfinityToolStripMenuItem.Size = new System.Drawing.Size(177, 36);
            this.rotXInfinityToolStripMenuItem.Text = "⤺x∞";
            // 
            // renderPanel1
            // 
            this.renderPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.renderPanel1.BackColor = System.Drawing.Color.Black;
            this.renderPanel1.Location = new System.Drawing.Point(0, 0);
            this.renderPanel1.Name = "renderPanel1";
            this.renderPanel1.ScaleFactor = 0D;
            this.renderPanel1.Size = new System.Drawing.Size(200, 100);
            this.renderPanel1.TabIndex = 2;
            this.renderPanel1.World = null;
            // 
            // yToolStripMenuItem
            // 
            this.rotYInfinityToolStripMenuItem.Name = "yToolStripMenuItem";
            this.rotYInfinityToolStripMenuItem.Size = new System.Drawing.Size(177, 36);
            this.rotYInfinityToolStripMenuItem.Text = "⤺y∞";
            // 
            // zToolStripMenuItem
            // 
            this.rotZInfinityToolStripMenuItem.Name = "zToolStripMenuItem";
            this.rotZInfinityToolStripMenuItem.Size = new System.Drawing.Size(177, 36);
            this.rotZInfinityToolStripMenuItem.Text = "⤺z∞";
            // 
            // Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 929);
            this.Controls.Add(this.renderPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Gui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMP 4560: Assignment 5";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private RenderPanel renderPanel1;
        private System.Windows.Forms.ToolStripMenuItem upToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scaleUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scaleDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shearRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shearLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotXInfinityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotYInfinityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotZInfinityToolStripMenuItem;
    }
}

