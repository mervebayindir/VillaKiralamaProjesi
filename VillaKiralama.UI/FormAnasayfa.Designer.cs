
namespace VillaKiralama.UI
{
    partial class FormAnasayfa
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
            this.villalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.villaDetaylarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiralamlarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.musterilerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.villalarToolStripMenuItem,
            this.villaDetaylarToolStripMenuItem,
            this.kategorilerToolStripMenuItem,
            this.kiralamlarToolStripMenuItem1,
            this.musterilerToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // villalarToolStripMenuItem
            // 
            this.villalarToolStripMenuItem.Name = "villalarToolStripMenuItem";
            this.villalarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.villalarToolStripMenuItem.Text = "Villalar";
            this.villalarToolStripMenuItem.Click += new System.EventHandler(this.villalarToolStripMenuItem_Click);
            // 
            // villaDetaylarToolStripMenuItem
            // 
            this.villaDetaylarToolStripMenuItem.Name = "villaDetaylarToolStripMenuItem";
            this.villaDetaylarToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.villaDetaylarToolStripMenuItem.Text = "VillaDetaylar";
            this.villaDetaylarToolStripMenuItem.Click += new System.EventHandler(this.villaDetaylarToolStripMenuItem_Click);
            // 
            // kategorilerToolStripMenuItem
            // 
            this.kategorilerToolStripMenuItem.Name = "kategorilerToolStripMenuItem";
            this.kategorilerToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.kategorilerToolStripMenuItem.Text = "Kategoriler";
            this.kategorilerToolStripMenuItem.Click += new System.EventHandler(this.kategorilerToolStripMenuItem_Click);
            // 
            // kiralamlarToolStripMenuItem1
            // 
            this.kiralamlarToolStripMenuItem1.Name = "kiralamlarToolStripMenuItem1";
            this.kiralamlarToolStripMenuItem1.Size = new System.Drawing.Size(78, 20);
            this.kiralamlarToolStripMenuItem1.Text = "Kiralamalar";
            this.kiralamlarToolStripMenuItem1.Click += new System.EventHandler(this.kiralamlarToolStripMenuItem1_Click);
            // 
            // musterilerToolStripMenuItem2
            // 
            this.musterilerToolStripMenuItem2.Name = "musterilerToolStripMenuItem2";
            this.musterilerToolStripMenuItem2.Size = new System.Drawing.Size(72, 20);
            this.musterilerToolStripMenuItem2.Text = "Müsteriler";
            this.musterilerToolStripMenuItem2.Click += new System.EventHandler(this.musterilerToolStripMenuItem2_Click);
            // 
            // FormAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(854, 521);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAnasayfa";
            this.Text = "Anasayfa";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem villalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem villaDetaylarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiralamlarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem musterilerToolStripMenuItem2;
    }
}

