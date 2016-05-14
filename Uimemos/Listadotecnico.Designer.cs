namespace Uimemos
{
    partial class Listadotecnico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listadotecnico));
            this.listadotec = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listadotec)).BeginInit();
            this.SuspendLayout();
            // 
            // listadotec
            // 
            this.listadotec.AllowUserToAddRows = false;
            this.listadotec.AllowUserToDeleteRows = false;
            this.listadotec.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.listadotec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadotec.Location = new System.Drawing.Point(79, 49);
            this.listadotec.Name = "listadotec";
            this.listadotec.ReadOnly = true;
            this.listadotec.Size = new System.Drawing.Size(448, 299);
            this.listadotec.TabIndex = 0;
            // 
            // Listadotecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(607, 399);
            this.Controls.Add(this.listadotec);
            this.Name = "Listadotecnico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.Listadotecnico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listadotec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listadotec;
    }
}