namespace EXAM_APP
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aDDBOOKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPDATESTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETESTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTSTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDBOOKToolStripMenuItem,
            this.uPDATESTUDENTToolStripMenuItem,
            this.dELETESTUDENTToolStripMenuItem,
            this.lISTSTUDENTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1263, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aDDBOOKToolStripMenuItem
            // 
            this.aDDBOOKToolStripMenuItem.Name = "aDDBOOKToolStripMenuItem";
            this.aDDBOOKToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.aDDBOOKToolStripMenuItem.Text = "ADD STUDENT";
            this.aDDBOOKToolStripMenuItem.Click += new System.EventHandler(this.aDDBOOKToolStripMenuItem_Click);
            // 
            // uPDATESTUDENTToolStripMenuItem
            // 
            this.uPDATESTUDENTToolStripMenuItem.Name = "uPDATESTUDENTToolStripMenuItem";
            this.uPDATESTUDENTToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.uPDATESTUDENTToolStripMenuItem.Text = "UPDATE STUDENT";
            this.uPDATESTUDENTToolStripMenuItem.Click += new System.EventHandler(this.uPDATESTUDENTToolStripMenuItem_Click);
            // 
            // dELETESTUDENTToolStripMenuItem
            // 
            this.dELETESTUDENTToolStripMenuItem.Name = "dELETESTUDENTToolStripMenuItem";
            this.dELETESTUDENTToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.dELETESTUDENTToolStripMenuItem.Text = "DELETE STUDENT";
            this.dELETESTUDENTToolStripMenuItem.Click += new System.EventHandler(this.dELETESTUDENTToolStripMenuItem_Click);
            // 
            // lISTSTUDENTToolStripMenuItem
            // 
            this.lISTSTUDENTToolStripMenuItem.Name = "lISTSTUDENTToolStripMenuItem";
            this.lISTSTUDENTToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.lISTSTUDENTToolStripMenuItem.Text = "LIST STUDENT";
            this.lISTSTUDENTToolStripMenuItem.Click += new System.EventHandler(this.lISTSTUDENTToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 661);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aDDBOOKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uPDATESTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETESTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lISTSTUDENTToolStripMenuItem;
    }
}

