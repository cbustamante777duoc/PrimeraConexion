namespace MiPrimeraConecion
{
    partial class ListaProcediemientoAlmacendo
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
            this.dgvListaProcedimiento = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProcedimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaProcedimiento
            // 
            this.dgvListaProcedimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProcedimiento.Location = new System.Drawing.Point(33, 103);
            this.dgvListaProcedimiento.Name = "dgvListaProcedimiento";
            this.dgvListaProcedimiento.Size = new System.Drawing.Size(410, 288);
            this.dgvListaProcedimiento.TabIndex = 0;
            // 
            // ListaProcediemientoAlmacendo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 437);
            this.Controls.Add(this.dgvListaProcedimiento);
            this.Name = "ListaProcediemientoAlmacendo";
            this.Text = "ListaProcediemientoAlmacendo";
            this.Load += new System.EventHandler(this.ListaProcediemientoAlmacendo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProcedimiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaProcedimiento;
    }
}