namespace MiPrimeraConecion
{
    partial class FrConsultaMedicamentoPorFarmaceutica
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxFarmaceutica = new System.Windows.Forms.ComboBox();
            this.dgvMedicamento = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ingrese farmaceutica";
            // 
            // cbxFarmaceutica
            // 
            this.cbxFarmaceutica.FormattingEnabled = true;
            this.cbxFarmaceutica.Location = new System.Drawing.Point(203, 37);
            this.cbxFarmaceutica.Name = "cbxFarmaceutica";
            this.cbxFarmaceutica.Size = new System.Drawing.Size(121, 21);
            this.cbxFarmaceutica.TabIndex = 1;
            this.cbxFarmaceutica.SelectionChangeCommitted += new System.EventHandler(this.FILTRAR);
            // 
            // dgvMedicamento
            // 
            this.dgvMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamento.Location = new System.Drawing.Point(12, 102);
            this.dgvMedicamento.Name = "dgvMedicamento";
            this.dgvMedicamento.Size = new System.Drawing.Size(504, 240);
            this.dgvMedicamento.TabIndex = 2;
            // 
            // FrConsultaMedicamentoPorFarmaceutica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 425);
            this.Controls.Add(this.dgvMedicamento);
            this.Controls.Add(this.cbxFarmaceutica);
            this.Controls.Add(this.label1);
            this.Name = "FrConsultaMedicamentoPorFarmaceutica";
            this.Text = "FrConsultaMedicamentoPorFarmaceutica";
            this.Load += new System.EventHandler(this.FrConsultaMedicamentoPorFarmaceutica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxFarmaceutica;
        private System.Windows.Forms.DataGridView dgvMedicamento;
    }
}