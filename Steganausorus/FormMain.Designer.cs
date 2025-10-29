namespace Steganausorus
{
    partial class FormMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.PictureBoxApplicationLogo = new System.Windows.Forms.PictureBox();
            this.StatusStripMain = new System.Windows.Forms.StatusStrip();
            this.MenuStripMain = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.PanelCenter = new System.Windows.Forms.Panel();
            this.SplitContainerCenter = new System.Windows.Forms.SplitContainer();
            this.PictureBoxOriginalImage = new System.Windows.Forms.PictureBox();
            this.PictureBoxStaganausoredImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxApplicationLogo)).BeginInit();
            this.MenuStripMain.SuspendLayout();
            this.PanelTop.SuspendLayout();
            this.PanelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerCenter)).BeginInit();
            this.SplitContainerCenter.Panel1.SuspendLayout();
            this.SplitContainerCenter.Panel2.SuspendLayout();
            this.SplitContainerCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxOriginalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStaganausoredImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxApplicationLogo
            // 
            this.PictureBoxApplicationLogo.BackgroundImage = global::Steganausorus.Properties.Resources.steganausorus;
            this.PictureBoxApplicationLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBoxApplicationLogo.Location = new System.Drawing.Point(300, 3);
            this.PictureBoxApplicationLogo.Name = "PictureBoxApplicationLogo";
            this.PictureBoxApplicationLogo.Size = new System.Drawing.Size(200, 113);
            this.PictureBoxApplicationLogo.TabIndex = 0;
            this.PictureBoxApplicationLogo.TabStop = false;
            this.PictureBoxApplicationLogo.DoubleClick += new System.EventHandler(this.PictureBoxApplicationLogo_DoubleClick);
            // 
            // StatusStripMain
            // 
            this.StatusStripMain.Location = new System.Drawing.Point(0, 539);
            this.StatusStripMain.Name = "StatusStripMain";
            this.StatusStripMain.Size = new System.Drawing.Size(784, 22);
            this.StatusStripMain.TabIndex = 1;
            this.StatusStripMain.Text = "statusStrip1";
            // 
            // MenuStripMain
            // 
            this.MenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.MenuStripMain.Location = new System.Drawing.Point(0, 0);
            this.MenuStripMain.Name = "MenuStripMain";
            this.MenuStripMain.Size = new System.Drawing.Size(784, 24);
            this.MenuStripMain.TabIndex = 2;
            this.MenuStripMain.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.QuitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // QuitToolStripMenuItem
            // 
            this.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem";
            this.QuitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.QuitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.QuitToolStripMenuItem.Text = "Quit";
            this.QuitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.PictureBoxApplicationLogo);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 24);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(784, 119);
            this.PanelTop.TabIndex = 4;
            // 
            // PanelCenter
            // 
            this.PanelCenter.Controls.Add(this.SplitContainerCenter);
            this.PanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCenter.Location = new System.Drawing.Point(0, 143);
            this.PanelCenter.Name = "PanelCenter";
            this.PanelCenter.Size = new System.Drawing.Size(784, 396);
            this.PanelCenter.TabIndex = 5;
            // 
            // SplitContainerCenter
            // 
            this.SplitContainerCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerCenter.Location = new System.Drawing.Point(0, 0);
            this.SplitContainerCenter.Name = "SplitContainerCenter";
            // 
            // SplitContainerCenter.Panel1
            // 
            this.SplitContainerCenter.Panel1.Controls.Add(this.PictureBoxOriginalImage);
            // 
            // SplitContainerCenter.Panel2
            // 
            this.SplitContainerCenter.Panel2.Controls.Add(this.PictureBoxStaganausoredImage);
            this.SplitContainerCenter.Size = new System.Drawing.Size(784, 396);
            this.SplitContainerCenter.SplitterDistance = 399;
            this.SplitContainerCenter.TabIndex = 0;
            // 
            // PictureBoxOriginalImage
            // 
            this.PictureBoxOriginalImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxOriginalImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBoxOriginalImage.Location = new System.Drawing.Point(12, 6);
            this.PictureBoxOriginalImage.Name = "PictureBoxOriginalImage";
            this.PictureBoxOriginalImage.Size = new System.Drawing.Size(384, 387);
            this.PictureBoxOriginalImage.TabIndex = 0;
            this.PictureBoxOriginalImage.TabStop = false;
            // 
            // PictureBoxStaganausoredImage
            // 
            this.PictureBoxStaganausoredImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxStaganausoredImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBoxStaganausoredImage.Location = new System.Drawing.Point(-1, 6);
            this.PictureBoxStaganausoredImage.Name = "PictureBoxStaganausoredImage";
            this.PictureBoxStaganausoredImage.Size = new System.Drawing.Size(375, 387);
            this.PictureBoxStaganausoredImage.TabIndex = 1;
            this.PictureBoxStaganausoredImage.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.PanelCenter);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.StatusStripMain);
            this.Controls.Add(this.MenuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStripMain;
            this.Name = "FormMain";
            this.Text = "Steganausorus";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxApplicationLogo)).EndInit();
            this.MenuStripMain.ResumeLayout(false);
            this.MenuStripMain.PerformLayout();
            this.PanelTop.ResumeLayout(false);
            this.PanelCenter.ResumeLayout(false);
            this.SplitContainerCenter.Panel1.ResumeLayout(false);
            this.SplitContainerCenter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerCenter)).EndInit();
            this.SplitContainerCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxOriginalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStaganausoredImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxApplicationLogo;
        private System.Windows.Forms.StatusStrip StatusStripMain;
        private System.Windows.Forms.MenuStrip MenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuitToolStripMenuItem;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Panel PanelCenter;
        private System.Windows.Forms.SplitContainer SplitContainerCenter;
        private System.Windows.Forms.PictureBox PictureBoxOriginalImage;
        private System.Windows.Forms.PictureBox PictureBoxStaganausoredImage;
    }
}

