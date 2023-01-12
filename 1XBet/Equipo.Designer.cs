namespace _1XBet
{
    partial class Equipo
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
            this.comboBoxLigas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewEquipos = new System.Windows.Forms.DataGridView();
            this.buttonAlta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxLigas
            // 
            this.comboBoxLigas.FormattingEnabled = true;
            this.comboBoxLigas.Location = new System.Drawing.Point(45, 6);
            this.comboBoxLigas.Name = "comboBoxLigas";
            this.comboBoxLigas.Size = new System.Drawing.Size(231, 21);
            this.comboBoxLigas.TabIndex = 0;
            this.comboBoxLigas.SelectedIndexChanged += new System.EventHandler(this.comboBoxLigas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liga";
            // 
            // dataGridViewEquipos
            // 
            this.dataGridViewEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEquipos.Location = new System.Drawing.Point(12, 33);
            this.dataGridViewEquipos.MultiSelect = false;
            this.dataGridViewEquipos.Name = "dataGridViewEquipos";
            this.dataGridViewEquipos.ReadOnly = true;
            this.dataGridViewEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEquipos.Size = new System.Drawing.Size(264, 355);
            this.dataGridViewEquipos.TabIndex = 3;
            this.dataGridViewEquipos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEquipos_CellClick);
            // 
            // buttonAlta
            // 
            this.buttonAlta.Location = new System.Drawing.Point(201, 394);
            this.buttonAlta.Name = "buttonAlta";
            this.buttonAlta.Size = new System.Drawing.Size(75, 23);
            this.buttonAlta.TabIndex = 4;
            this.buttonAlta.Text = "Alta";
            this.buttonAlta.UseVisualStyleBackColor = true;
            this.buttonAlta.Click += new System.EventHandler(this.buttonAlta_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Baja";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Equipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAlta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewEquipos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxLigas);
            this.Name = "Equipo";
            this.Text = "Equipo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLigas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewEquipos;
        private System.Windows.Forms.Button buttonAlta;
        private System.Windows.Forms.Button button1;
    }
}