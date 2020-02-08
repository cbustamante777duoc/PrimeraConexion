namespace MiPrimeraConecion
{
    partial class lstPorConsultaSql
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
            this.dgvListaPorSexo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPorSexo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaPorSexo
            // 
            this.dgvListaPorSexo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPorSexo.Location = new System.Drawing.Point(30, 66);
            this.dgvListaPorSexo.Name = "dgvListaPorSexo";
            this.dgvListaPorSexo.Size = new System.Drawing.Size(406, 334);
            this.dgvListaPorSexo.TabIndex = 0;
            // 
            // lstPorSexo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 467);
            this.Controls.Add(this.dgvListaPorSexo);
            this.Name = "lstPorSexo";
            this.Text = "lstPorSexo";
            this.Load += new System.EventHandler(this.lstPorSexo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPorSexo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaPorSexo;
    }
}