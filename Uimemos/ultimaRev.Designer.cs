namespace Uimemos
{
    partial class ultimaRev
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
            this.DGVRevision = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRevision)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVRevision
            // 
            this.DGVRevision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRevision.Location = new System.Drawing.Point(2, 1);
            this.DGVRevision.Name = "DGVRevision";
            this.DGVRevision.Size = new System.Drawing.Size(970, 515);
            this.DGVRevision.TabIndex = 1;
            // 
            // ultimaRev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.DGVRevision);
            this.Name = "ultimaRev";
            this.Text = "ultimaRev";
            this.Load += new System.EventHandler(this.ultimaRev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRevision)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVRevision;
    }
}