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
            this.panelmemo = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbfecha = new System.Windows.Forms.Label();
            this.lbmotivo = new System.Windows.Forms.Label();
            this.txtmotivo = new System.Windows.Forms.TextBox();
            this.txtdestinatario = new System.Windows.Forms.TextBox();
            this.lbDestinatario = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelfechayhora = new System.Windows.Forms.Panel();
            this.hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.panelmemo.SuspendLayout();
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
            this.toolHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolHome.Image = ((System.Drawing.Image)(resources.GetObject("toolHome.Image")));
            this.toolHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolHome.Name = "toolHome";
            this.toolHome.Size = new System.Drawing.Size(56, 56);
            this.toolHome.Text = "Home";
            this.toolHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolHome.Click += new System.EventHandler(this.toolHome_Click);
            // 
            // toolDispositivo
            // 
            this.toolDispositivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolDispositivo.Image = ((System.Drawing.Image)(resources.GetObject("toolDispositivo.Image")));
            this.toolDispositivo.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.toolDispositivo.Name = "toolDispositivo";
            this.toolDispositivo.Size = new System.Drawing.Size(91, 56);
            this.toolDispositivo.Text = "Dispositivo";
            this.toolDispositivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolDispositivo.Click += new System.EventHandler(this.toolDispositivo_Click);
            // 
            // toolTecnico
            // 
            this.toolTecnico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTecnico.Image = ((System.Drawing.Image)(resources.GetObject("toolTecnico.Image")));
            this.toolTecnico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolTecnico.Name = "toolTecnico";
            this.toolTecnico.Size = new System.Drawing.Size(66, 56);
            this.toolTecnico.Text = "Técnico";
            this.toolTecnico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTecnico.Click += new System.EventHandler(this.toolTecnico_Click);
            // 
            // toolDepartamento
            // 
            this.toolDepartamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolDepartamento.Image = ((System.Drawing.Image)(resources.GetObject("toolDepartamento.Image")));
            this.toolDepartamento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDepartamento.Name = "toolDepartamento";
            this.toolDepartamento.Size = new System.Drawing.Size(114, 56);
            this.toolDepartamento.Text = "Departamento";
            this.toolDepartamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolDepartamento.Click += new System.EventHandler(this.toolDepartamento_Click);
            // 
            // toolRevision
            // 
            this.toolRevision.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolRevision.Image = ((System.Drawing.Image)(resources.GetObject("toolRevision.Image")));
            this.toolRevision.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRevision.Name = "toolRevision";
            this.toolRevision.Size = new System.Drawing.Size(73, 56);
            this.toolRevision.Text = "Revisión";
            this.toolRevision.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolRevision.Click += new System.EventHandler(this.toolRevision_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(66, 56);
            this.toolStripButton4.Text = "Memos";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // panelmemo
            // 
            this.panelmemo.BackColor = System.Drawing.Color.Transparent;
            this.panelmemo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelmemo.Controls.Add(this.label4);
            this.panelmemo.Controls.Add(this.label3);
            this.panelmemo.Controls.Add(this.btnGuardar);
            this.panelmemo.Controls.Add(this.txtDescripcion);
            this.panelmemo.Controls.Add(this.lbDescripcion);
            this.panelmemo.Controls.Add(this.dateTimePicker1);
            this.panelmemo.Controls.Add(this.lbfecha);
            this.panelmemo.Controls.Add(this.lbmotivo);
            this.panelmemo.Controls.Add(this.txtmotivo);
            this.panelmemo.Controls.Add(this.txtdestinatario);
            this.panelmemo.Controls.Add(this.lbDestinatario);
            this.panelmemo.Location = new System.Drawing.Point(45, 172);
            this.panelmemo.Name = "panelmemo";
            this.panelmemo.Size = new System.Drawing.Size(883, 408);
            this.panelmemo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(350, 364);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 30);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Generar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Info;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(172, 203);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(416, 116);
            this.txtDescripcion.TabIndex = 7;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.Location = new System.Drawing.Point(67, 203);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(96, 20);
            this.lbDescripcion.TabIndex = 6;
            this.lbDescripcion.Text = "Descripción:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.GradientActiveCaption;
            this.dateTimePicker1.Location = new System.Drawing.Point(172, 151);
            this.dateTimePicker1.MaxDate = new System.DateTime(2035, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2016, 4, 14, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2016, 4, 14, 0, 0, 0, 0);
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfecha.Location = new System.Drawing.Point(68, 152);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(58, 20);
            this.lbfecha.TabIndex = 4;
            this.lbfecha.Text = "Fecha:";
            // 
            // lbmotivo
            // 
            this.lbmotivo.AutoSize = true;
            this.lbmotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmotivo.Location = new System.Drawing.Point(68, 103);
            this.lbmotivo.Name = "lbmotivo";
            this.lbmotivo.Size = new System.Drawing.Size(59, 20);
            this.lbmotivo.TabIndex = 3;
            this.lbmotivo.Text = "Motivo:";
            // 
            // txtmotivo
            // 
            this.txtmotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmotivo.Location = new System.Drawing.Point(169, 103);
            this.txtmotivo.Name = "txtmotivo";
            this.txtmotivo.Size = new System.Drawing.Size(416, 24);
            this.txtmotivo.TabIndex = 2;
            this.txtmotivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmotivo_KeyPress);
            // 
            // txtdestinatario
            // 
            this.txtdestinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdestinatario.Location = new System.Drawing.Point(169, 49);
            this.txtdestinatario.Multiline = true;
            this.txtdestinatario.Name = "txtdestinatario";
            this.txtdestinatario.Size = new System.Drawing.Size(416, 34);
            this.txtdestinatario.TabIndex = 1;
            this.txtdestinatario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdestinatario_KeyPress);
            // 
            // lbDestinatario
            // 
            this.lbDestinatario.AutoSize = true;
            this.lbDestinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDestinatario.Location = new System.Drawing.Point(64, 49);
            this.lbDestinatario.Name = "lbDestinatario";
            this.lbDestinatario.Size = new System.Drawing.Size(99, 20);
            this.lbDestinatario.TabIndex = 0;
            this.lbDestinatario.Text = "Destinatario:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoEllipsis = true;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(515, 111);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(53, 39);
            this.btnBuscar.TabIndex = 35;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Número:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(432, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 157);
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
            this.ClientSize = new System.Drawing.Size(984, 609);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panelfechayhora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panelmemo);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Memos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memos";
            this.Load += new System.EventHandler(this.Memos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelmemo.ResumeLayout(false);
            this.panelmemo.PerformLayout();
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
        private System.Windows.Forms.Panel panelmemo;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}