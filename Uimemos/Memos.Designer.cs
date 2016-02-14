namespace Uimemos
{
    partial class Memos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Memos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolHome = new System.Windows.Forms.ToolStripButton();
            this.toolDispositivo = new System.Windows.Forms.ToolStripButton();
            this.toolTecnico = new System.Windows.Forms.ToolStripButton();
            this.toolDepartamento = new System.Windows.Forms.ToolStripButton();
            this.toolRevision = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbfecha = new System.Windows.Forms.Label();
            this.lbmotivo = new System.Windows.Forms.Label();
            this.txtmotivo = new System.Windows.Forms.TextBox();
            this.txtdestinatario = new System.Windows.Forms.TextBox();
            this.lbDestinatario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelfechayhora = new System.Windows.Forms.Panel();
            this.hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.toolStripButton4});
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
            this.toolDispositivo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
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
            this.toolDepartamento.Click += new System.EventHandler(this.toolDepartamento_Click);
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
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(51, 56);
            this.toolStripButton4.Text = "Memos";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.lbDescripcion);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lbfecha);
            this.panel1.Controls.Add(this.lbmotivo);
            this.panel1.Controls.Add(this.txtmotivo);
            this.panel1.Controls.Add(this.txtdestinatario);
            this.panel1.Controls.Add(this.lbDestinatario);
            this.panel1.Location = new System.Drawing.Point(45, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 366);
            this.panel1.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(317, 313);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Generar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Info;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Location = new System.Drawing.Point(156, 161);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(236, 116);
            this.txtDescripcion.TabIndex = 7;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.Location = new System.Drawing.Point(67, 165);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(83, 16);
            this.lbDescripcion.TabIndex = 6;
            this.lbDescripcion.Text = "Descripción:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(156, 122);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfecha.Location = new System.Drawing.Point(67, 126);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(49, 16);
            this.lbfecha.TabIndex = 4;
            this.lbfecha.Text = "Fecha:";
            // 
            // lbmotivo
            // 
            this.lbmotivo.AutoSize = true;
            this.lbmotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmotivo.Location = new System.Drawing.Point(67, 92);
            this.lbmotivo.Name = "lbmotivo";
            this.lbmotivo.Size = new System.Drawing.Size(51, 16);
            this.lbmotivo.TabIndex = 3;
            this.lbmotivo.Text = "Motivo:";
            // 
            // txtmotivo
            // 
            this.txtmotivo.Location = new System.Drawing.Point(156, 88);
            this.txtmotivo.Name = "txtmotivo";
            this.txtmotivo.Size = new System.Drawing.Size(236, 20);
            this.txtmotivo.TabIndex = 2;
            // 
            // txtdestinatario
            // 
            this.txtdestinatario.Location = new System.Drawing.Point(156, 48);
            this.txtdestinatario.Name = "txtdestinatario";
            this.txtdestinatario.Size = new System.Drawing.Size(236, 20);
            this.txtdestinatario.TabIndex = 1;
            // 
            // lbDestinatario
            // 
            this.lbDestinatario.AutoSize = true;
            this.lbDestinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDestinatario.Location = new System.Drawing.Point(67, 52);
            this.lbDestinatario.Name = "lbDestinatario";
            this.lbDestinatario.Size = new System.Drawing.Size(83, 16);
            this.lbDestinatario.TabIndex = 0;
            this.lbDestinatario.Text = "Destinatario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registro de memorando";
            // 
            // panelfechayhora
            // 
            this.panelfechayhora.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelfechayhora.BackColor = System.Drawing.Color.Transparent;
            this.panelfechayhora.Controls.Add(this.hora);
            this.panelfechayhora.Location = new System.Drawing.Point(0, 62);
            this.panelfechayhora.Name = "panelfechayhora";
            this.panelfechayhora.Size = new System.Drawing.Size(984, 26);
            this.panelfechayhora.TabIndex = 7;
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
            // Memos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 563);
            this.Controls.Add(this.panelfechayhora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Memos";
            this.Text = "Memos";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Label lbmotivo;
        private System.Windows.Forms.TextBox txtmotivo;
        private System.Windows.Forms.TextBox txtdestinatario;
        private System.Windows.Forms.Label lbDestinatario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelfechayhora;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Timer timer1;
    }
}