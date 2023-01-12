namespace _1XBet
{
    partial class ProximosPartidos
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
            this.dataGridViewFixture = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFixture)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFixture
            // 
            this.dataGridViewFixture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFixture.Location = new System.Drawing.Point(12, 57);
            this.dataGridViewFixture.Name = "dataGridViewFixture";
            this.dataGridViewFixture.Size = new System.Drawing.Size(776, 381);
            this.dataGridViewFixture.TabIndex = 0;
            // 
            // ProximosPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewFixture);
            this.Name = "ProximosPartidos";
            this.Text = "ProximosPartidos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFixture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFixture;
    }
}