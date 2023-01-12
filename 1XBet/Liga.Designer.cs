namespace _1XBet
{
    partial class Liga
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
            this.dataGridViewLigas = new System.Windows.Forms.DataGridView();
            this.buttonAlta = new System.Windows.Forms.Button();
            this.buttonBaja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLigas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLigas
            // 
            this.dataGridViewLigas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLigas.Location = new System.Drawing.Point(12, 15);
            this.dataGridViewLigas.MultiSelect = false;
            this.dataGridViewLigas.Name = "dataGridViewLigas";
            this.dataGridViewLigas.ReadOnly = true;
            this.dataGridViewLigas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLigas.Size = new System.Drawing.Size(380, 355);
            this.dataGridViewLigas.TabIndex = 2;
            this.dataGridViewLigas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLigas_CellClick);
            // 
            // buttonAlta
            // 
            this.buttonAlta.Location = new System.Drawing.Point(116, 376);
            this.buttonAlta.Name = "buttonAlta";
            this.buttonAlta.Size = new System.Drawing.Size(75, 23);
            this.buttonAlta.TabIndex = 5;
            this.buttonAlta.Text = "Alta";
            this.buttonAlta.UseVisualStyleBackColor = true;
            this.buttonAlta.Click += new System.EventHandler(this.buttonAlta_Click);
            // 
            // buttonBaja
            // 
            this.buttonBaja.Location = new System.Drawing.Point(197, 376);
            this.buttonBaja.Name = "buttonBaja";
            this.buttonBaja.Size = new System.Drawing.Size(75, 23);
            this.buttonBaja.TabIndex = 6;
            this.buttonBaja.Text = "Baja";
            this.buttonBaja.UseVisualStyleBackColor = true;
            this.buttonBaja.Click += new System.EventHandler(this.buttonBaja_Click);
            // 
            // Liga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 407);
            this.Controls.Add(this.buttonBaja);
            this.Controls.Add(this.buttonAlta);
            this.Controls.Add(this.dataGridViewLigas);
            this.Name = "Liga";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLigas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewLigas;
        private System.Windows.Forms.Button buttonAlta;
        private System.Windows.Forms.Button buttonBaja;
    }
}

