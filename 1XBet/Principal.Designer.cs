namespace _1XBet
{
    partial class Principal
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
            this.datosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ligasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalPartidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosToolStripMenuItem,
            this.informesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datosToolStripMenuItem
            // 
            this.datosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ligasToolStripMenuItem,
            this.equiposToolStripMenuItem,
            this.partidosToolStripMenuItem});
            this.datosToolStripMenuItem.Name = "datosToolStripMenuItem";
            this.datosToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.datosToolStripMenuItem.Text = "Datos";
            // 
            // ligasToolStripMenuItem
            // 
            this.ligasToolStripMenuItem.Name = "ligasToolStripMenuItem";
            this.ligasToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.ligasToolStripMenuItem.Text = "Ligas";
            this.ligasToolStripMenuItem.Click += new System.EventHandler(this.ligasToolStripMenuItem_Click);
            // 
            // equiposToolStripMenuItem
            // 
            this.equiposToolStripMenuItem.Name = "equiposToolStripMenuItem";
            this.equiposToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.equiposToolStripMenuItem.Text = "Equipos";
            this.equiposToolStripMenuItem.Click += new System.EventHandler(this.equiposToolStripMenuItem_Click);
            // 
            // partidosToolStripMenuItem
            // 
            this.partidosToolStripMenuItem.Name = "partidosToolStripMenuItem";
            this.partidosToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.partidosToolStripMenuItem.Text = "Partidos";
            this.partidosToolStripMenuItem.Click += new System.EventHandler(this.partidosToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalPartidosToolStripMenuItem,
            this.vSToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // totalPartidosToolStripMenuItem
            // 
            this.totalPartidosToolStripMenuItem.Name = "totalPartidosToolStripMenuItem";
            this.totalPartidosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.totalPartidosToolStripMenuItem.Text = "Informes";
            this.totalPartidosToolStripMenuItem.Click += new System.EventHandler(this.totalPartidosToolStripMenuItem_Click);
            // 
            // vSToolStripMenuItem
            // 
            this.vSToolStripMenuItem.Name = "vSToolStripMenuItem";
            this.vSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vSToolStripMenuItem.Text = "VS";
            this.vSToolStripMenuItem.Click += new System.EventHandler(this.vSToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ligasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalPartidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vSToolStripMenuItem;
    }
}