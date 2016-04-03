namespace Uimemos
{
    partial class Dispositivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dispositivo));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolhome = new System.Windows.Forms.ToolStripButton();
            this.toolDispositivo = new System.Windows.Forms.ToolStripButton();
            this.tooltecnico = new System.Windows.Forms.ToolStripButton();
            this.toolDepartamento = new System.Windows.Forms.ToolStripButton();
            this.toolrevision = new System.Windows.Forms.ToolStripButton();
            this.toolmemorando = new System.Windows.Forms.ToolStripButton();
            this.paneldispo = new System.Windows.Forms.Panel();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.txtCaracteristicas = new System.Windows.Forms.TextBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbnomdpto = new System.Windows.Forms.ComboBox();
            this.txtNomuser = new System.Windows.Forms.TextBox();
            this.txtCodigocontrol = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.carac = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelfechayhora = new System.Windows.Forms.Panel();
            this.hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.paneldispo.SuspendLayout();
            this.panelfechayhora.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolhome,
            this.toolDispositivo,
            this.tooltecnico,
            this.toolDepartamento,
            this.toolrevision,
            this.toolmemorando});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 59);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolhome
            // 
            this.toolhome.Image = ((System.Drawing.Image)(resources.GetObject("toolhome.Image")));
            this.toolhome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolhome.Name = "toolhome";
            this.toolhome.Size = new System.Drawing.Size(44, 56);
            this.toolhome.Text = "Home";
            this.toolhome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolhome.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolDispositivo
            // 
            this.toolDispositivo.Image = ((System.Drawing.Image)(resources.GetObject("toolDispositivo.Image")));
            this.toolDispositivo.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.toolDispositivo.Name = "toolDispositivo";
            this.toolDispositivo.Size = new System.Drawing.Size(69, 56);
            this.toolDispositivo.Text = "Dispositivo";
            this.toolDispositivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tooltecnico
            // 
            this.tooltecnico.Image = ((System.Drawing.Image)(resources.GetObject("tooltecnico.Image")));
            this.tooltecnico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tooltecnico.Name = "tooltecnico";
            this.tooltecnico.Size = new System.Drawing.Size(53, 56);
            this.tooltecnico.Text = "Técnico";
            this.tooltecnico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tooltecnico.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolDepartamento
            // 
            this.toolDepartamento.Image = ((System.Drawing.Image)(resources.GetObject("toolDepartamento.Image")));
            this.toolDepartamento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDepartamento.Name = "toolDepartamento";
            this.toolDepartamento.Size = new System.Drawing.Size(87, 56);
            this.toolDepartamento.Text = "Departamento";
            this.toolDepartamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolDepartamento.Click += new System.EventHandler(this.Departamento_Click);
            // 
            // toolrevision
            // 
            this.toolrevision.Image = ((System.Drawing.Image)(resources.GetObject("toolrevision.Image")));
            this.toolrevision.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolrevision.Name = "toolrevision";
            this.toolrevision.Size = new System.Drawing.Size(55, 56);
            this.toolrevision.Text = "Revisión";
            this.toolrevision.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolrevision.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolmemorando
            // 
            this.toolmemorando.Image = ((System.Drawing.Image)(resources.GetObject("toolmemorando.Image")));
            this.toolmemorando.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolmemorando.Name = "toolmemorando";
            this.toolmemorando.Size = new System.Drawing.Size(51, 56);
            this.toolmemorando.Text = "Memos";
            this.toolmemorando.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolmemorando.Click += new System.EventHandler(this.toolmemorando_Click);
            // 
            // paneldispo
            // 
            this.paneldispo.BackColor = System.Drawing.Color.Transparent;
            this.paneldispo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneldispo.Controls.Add(this.BtnGuardar);
            this.paneldispo.Controls.Add(this.txtCaracteristicas);
            this.paneldispo.Controls.Add(this.cbTipo);
            this.paneldispo.Controls.Add(this.cbnomdpto);
            this.paneldispo.Controls.Add(this.txtNomuser);
            this.paneldispo.Controls.Add(this.txtCodigocontrol);
            this.paneldispo.Controls.Add(this.label6);
            this.paneldispo.Controls.Add(this.label5);
            this.paneldispo.Controls.Add(this.label4);
            this.paneldispo.Controls.Add(this.carac);
            this.paneldispo.Controls.Add(this.label3);
            this.paneldispo.Controls.Add(this.label2);
            this.paneldispo.Location = new System.Drawing.Point(202, 157);
            this.paneldispo.Name = "paneldispo";
            this.paneldispo.Size = new System.Drawing.Size(609, 292);
            this.paneldispo.TabIndex = 1;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Location = new System.Drawing.Point(174, 252);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 11;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // txtCaracteristicas
            // 
            this.txtCaracteristicas.Location = new System.Drawing.Point(138, 128);
            this.txtCaracteristicas.Multiline = true;
            this.txtCaracteristicas.Name = "txtCaracteristicas";
            this.txtCaracteristicas.Size = new System.Drawing.Size(150, 81);
            this.txtCaracteristicas.TabIndex = 10;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(138, 90);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(150, 21);
            this.cbTipo.TabIndex = 9;
            // 
            // cbnomdpto
            // 
            this.cbnomdpto.FormattingEnabled = true;
            this.cbnomdpto.Location = new System.Drawing.Point(138, 60);
            this.cbnomdpto.Name = "cbnomdpto";
            this.cbnomdpto.Size = new System.Drawing.Size(150, 21);
            this.cbnomdpto.TabIndex = 8;
            
            // 
            // txtNomuser
            // 
            this.txtNomuser.Location = new System.Drawing.Point(138, 219);
            this.txtNomuser.Name = "txtNomuser";
            this.txtNomuser.Size = new System.Drawing.Size(150, 20);
            this.txtNomuser.TabIndex = 7;
            this.txtNomuser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomuser_KeyPress);
            // 
            // txtCodigocontrol
            // 
            this.txtCodigocontrol.Location = new System.Drawing.Point(140, 34);
            this.txtCodigocontrol.Name = "txtCodigocontrol";
            this.txtCodigocontrol.Size = new System.Drawing.Size(148, 20);
            this.txtCodigocontrol.TabIndex = 6;
            this.txtCodigocontrol.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigocontrol_KeyDown);
            this.txtCodigocontrol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigocontrol_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nombre (user):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Carácteristicas:";
            // 
            // carac
            // 
            this.carac.AutoSize = true;
            this.carac.Location = new System.Drawing.Point(36, 90);
            this.carac.Name = "carac";
            this.carac.Size = new System.Drawing.Size(0, 13);
            this.carac.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre (Dpto):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código control:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dispositivo";
            // 
            // panelfechayhora
            // 
            this.panelfechayhora.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelfechayhora.BackColor = System.Drawing.Color.Transparent;
            this.panelfechayhora.Controls.Add(this.hora);
            this.panelfechayhora.Location = new System.Drawing.Point(0, 62);
            this.panelfechayhora.Name = "panelfechayhora";
            this.panelfechayhora.Size = new System.Drawing.Size(984, 29);
            this.panelfechayhora.TabIndex = 7;
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Location = new System.Drawing.Point(433, 5);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(35, 13);
            this.hora.TabIndex = 0;
            this.hora.Text = "label6";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Dispositivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.panelfechayhora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paneldispo);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Dispositivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dispositivo";
            this.Load += new System.EventHandler(this.Dispositivo_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.paneldispo.ResumeLayout(false);
            this.paneldispo.PerformLayout();
            this.panelfechayhora.ResumeLayout(false);
            this.panelfechayhora.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolDispositivo;
        private System.Windows.Forms.ToolStripButton tooltecnico;
        private System.Windows.Forms.ToolStripButton toolrevision;
        private System.Windows.Forms.ToolStripButton toolmemorando;
        private System.Windows.Forms.Panel paneldispo;
        private System.Windows.Forms.Label carac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCaracteristicas;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.ComboBox cbnomdpto;
        private System.Windows.Forms.TextBox txtNomuser;
        private System.Windows.Forms.TextBox txtCodigocontrol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.ToolStripButton toolhome;
        private System.Windows.Forms.ToolStripButton toolDepartamento;
        private System.Windows.Forms.Panel panelfechayhora;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Timer timer1;
    }
}

