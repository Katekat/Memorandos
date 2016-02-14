namespace Uimemos
{
    partial class departamento
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(departamento));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolHome = new System.Windows.Forms.ToolStripButton();
            this.toolDispositivo = new System.Windows.Forms.ToolStripButton();
            this.toolTecnico = new System.Windows.Forms.ToolStripButton();
            this.toolDepartamento = new System.Windows.Forms.ToolStripButton();
            this.toolRevision = new System.Windows.Forms.ToolStripButton();
            this.toolMemos = new System.Windows.Forms.ToolStripButton();
            this.panelDpto = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtEncdpto = new System.Windows.Forms.TextBox();
            this.txtNomdpto = new System.Windows.Forms.TextBox();
            this.txtCodigodpto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelfechayhora = new System.Windows.Forms.Panel();
            this.hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.panelDpto.SuspendLayout();
            this.panelfechayhora.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolHome,
            this.toolDispositivo,
            this.toolTecnico,
            this.toolDepartamento,
            this.toolRevision,
            this.toolMemos});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 59);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolHome
            // 
            this.toolHome.Image = ((System.Drawing.Image)(resources.GetObject("toolHome.Image")));
            this.toolHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolHome.Name = "toolHome";
            this.toolHome.Size = new System.Drawing.Size(44, 56);
            this.toolHome.Text = "Home";
            this.toolHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolHome.Click += new System.EventHandler(this.toolHome_Click);
            // 
            // toolDispositivo
            // 
            this.toolDispositivo.Image = ((System.Drawing.Image)(resources.GetObject("toolDispositivo.Image")));
            this.toolDispositivo.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.toolDispositivo.Name = "toolDispositivo";
            this.toolDispositivo.Size = new System.Drawing.Size(69, 56);
            this.toolDispositivo.Text = "Dispositivo";
            this.toolDispositivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolDispositivo.Click += new System.EventHandler(this.toolDispositivo_Click);
            // 
            // toolTecnico
            // 
            this.toolTecnico.Image = ((System.Drawing.Image)(resources.GetObject("toolTecnico.Image")));
            this.toolTecnico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolTecnico.Name = "toolTecnico";
            this.toolTecnico.Size = new System.Drawing.Size(53, 56);
            this.toolTecnico.Text = "Técnico";
            this.toolTecnico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTecnico.Click += new System.EventHandler(this.toolTecnico_Click);
            // 
            // toolDepartamento
            // 
            this.toolDepartamento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDepartamento.Image = ((System.Drawing.Image)(resources.GetObject("toolDepartamento.Image")));
            this.toolDepartamento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolDepartamento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDepartamento.Name = "toolDepartamento";
            this.toolDepartamento.Size = new System.Drawing.Size(60, 56);
            this.toolDepartamento.Text = "Departamento";
            this.toolDepartamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolRevision
            // 
            this.toolRevision.Image = ((System.Drawing.Image)(resources.GetObject("toolRevision.Image")));
            this.toolRevision.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRevision.Name = "toolRevision";
            this.toolRevision.Size = new System.Drawing.Size(55, 56);
            this.toolRevision.Text = "Revisión";
            this.toolRevision.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolRevision.Click += new System.EventHandler(this.toolRevision_Click);
            // 
            // toolMemos
            // 
            this.toolMemos.Image = ((System.Drawing.Image)(resources.GetObject("toolMemos.Image")));
            this.toolMemos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMemos.Name = "toolMemos";
            this.toolMemos.Size = new System.Drawing.Size(51, 56);
            this.toolMemos.Text = "Memos";
            this.toolMemos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolMemos.Click += new System.EventHandler(this.toolMemos_Click);
            // 
            // panelDpto
            // 
            this.panelDpto.BackColor = System.Drawing.Color.Transparent;
            this.panelDpto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDpto.Controls.Add(this.btnGuardar);
            this.panelDpto.Controls.Add(this.txtEncdpto);
            this.panelDpto.Controls.Add(this.txtNomdpto);
            this.panelDpto.Controls.Add(this.txtCodigodpto);
            this.panelDpto.Controls.Add(this.label4);
            this.panelDpto.Controls.Add(this.label3);
            this.panelDpto.Controls.Add(this.label2);
            this.panelDpto.Location = new System.Drawing.Point(175, 145);
            this.panelDpto.Name = "panelDpto";
            this.panelDpto.Size = new System.Drawing.Size(616, 332);
            this.panelDpto.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(267, 200);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtEncdpto
            // 
            this.txtEncdpto.Location = new System.Drawing.Point(245, 131);
            this.txtEncdpto.Name = "txtEncdpto";
            this.txtEncdpto.Size = new System.Drawing.Size(124, 20);
            this.txtEncdpto.TabIndex = 5;
            // 
            // txtNomdpto
            // 
            this.txtNomdpto.Location = new System.Drawing.Point(245, 92);
            this.txtNomdpto.Name = "txtNomdpto";
            this.txtNomdpto.Size = new System.Drawing.Size(124, 20);
            this.txtNomdpto.TabIndex = 4;
            // 
            // txtCodigodpto
            // 
            this.txtCodigodpto.Location = new System.Drawing.Point(245, 45);
            this.txtCodigodpto.Name = "txtCodigodpto";
            this.txtCodigodpto.Size = new System.Drawing.Size(124, 20);
            this.txtCodigodpto.TabIndex = 3;
            this.txtCodigodpto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigodpto_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Encargado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departamento";
            // 
            // panelfechayhora
            // 
            this.panelfechayhora.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelfechayhora.BackColor = System.Drawing.Color.Transparent;
            this.panelfechayhora.Controls.Add(this.hora);
            this.panelfechayhora.Location = new System.Drawing.Point(0, 62);
            this.panelfechayhora.Name = "panelfechayhora";
            this.panelfechayhora.Size = new System.Drawing.Size(984, 26);
            this.panelfechayhora.TabIndex = 6;
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Location = new System.Drawing.Point(429, 5);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(35, 13);
            this.hora.TabIndex = 0;
            this.hora.Text = "label6";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // departamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.panelfechayhora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelDpto);
            this.Controls.Add(this.toolStrip1);
            this.Name = "departamento";
            this.Text = "departamento";
            this.Load += new System.EventHandler(this.departamento_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelDpto.ResumeLayout(false);
            this.panelDpto.PerformLayout();
            this.panelfechayhora.ResumeLayout(false);
            this.panelfechayhora.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolHome;
        private System.Windows.Forms.ToolStripButton toolDispositivo;
        private System.Windows.Forms.ToolStripButton toolTecnico;
        private System.Windows.Forms.ToolStripButton toolDepartamento;
        private System.Windows.Forms.ToolStripButton toolRevision;
        private System.Windows.Forms.ToolStripButton toolMemos;
        private System.Windows.Forms.Panel panelDpto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtEncdpto;
        private System.Windows.Forms.TextBox txtNomdpto;
        private System.Windows.Forms.TextBox txtCodigodpto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelfechayhora;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Timer timer1;
    }
}