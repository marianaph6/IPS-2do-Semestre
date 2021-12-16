namespace Final_IPS
{
    partial class Citas
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
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAsistencia = new System.Windows.Forms.ComboBox();
            this.txtmed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblmedico = new System.Windows.Forms.Label();
            this.fechcita = new System.Windows.Forms.DateTimePicker();
            this.txtIdpac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnIncumplidas = new System.Windows.Forms.Button();
            this.btnTodas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCitas
            // 
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Location = new System.Drawing.Point(12, 12);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.Size = new System.Drawing.Size(659, 210);
            this.dgvCitas.TabIndex = 1;
            this.dgvCitas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCitas_RowEnter_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbAsistencia);
            this.groupBox1.Controls.Add(this.txtmed);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblmedico);
            this.groupBox1.Controls.Add(this.fechcita);
            this.groupBox1.Controls.Add(this.txtIdpac);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Citas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Asistencia:";
            // 
            // cmbAsistencia
            // 
            this.cmbAsistencia.FormattingEnabled = true;
            this.cmbAsistencia.Location = new System.Drawing.Point(304, 60);
            this.cmbAsistencia.Name = "cmbAsistencia";
            this.cmbAsistencia.Size = new System.Drawing.Size(121, 21);
            this.cmbAsistencia.TabIndex = 18;
            // 
            // txtmed
            // 
            this.txtmed.Location = new System.Drawing.Point(304, 25);
            this.txtmed.Name = "txtmed";
            this.txtmed.Size = new System.Drawing.Size(121, 20);
            this.txtmed.TabIndex = 17;
            this.txtmed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmed_KeyPress);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(22, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha cita";
            // 
            // lblmedico
            // 
            this.lblmedico.Location = new System.Drawing.Point(229, 34);
            this.lblmedico.Name = "lblmedico";
            this.lblmedico.Size = new System.Drawing.Size(60, 13);
            this.lblmedico.TabIndex = 0;
            this.lblmedico.Text = "Id medico:";
            // 
            // fechcita
            // 
            this.fechcita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechcita.Location = new System.Drawing.Point(91, 61);
            this.fechcita.Margin = new System.Windows.Forms.Padding(2);
            this.fechcita.Name = "fechcita";
            this.fechcita.Size = new System.Drawing.Size(125, 20);
            this.fechcita.TabIndex = 15;
            this.fechcita.Value = new System.DateTime(2015, 12, 5, 0, 0, 0, 0);
            // 
            // txtIdpac
            // 
            this.txtIdpac.Location = new System.Drawing.Point(91, 27);
            this.txtIdpac.Name = "txtIdpac";
            this.txtIdpac.Size = new System.Drawing.Size(125, 20);
            this.txtIdpac.TabIndex = 1;
            this.txtIdpac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdpac_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id paciente:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAsistencia);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Location = new System.Drawing.Point(12, 366);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 46);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones";
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.Location = new System.Drawing.Point(182, 17);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(75, 23);
            this.btnAsistencia.TabIndex = 18;
            this.btnAsistencia.Text = "Asistencia";
            this.btnAsistencia.UseVisualStyleBackColor = true;
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(368, 17);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(274, 17);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(91, 17);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(10, 17);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnIncumplidas);
            this.groupBox3.Controls.Add(this.btnTodas);
            this.groupBox3.Location = new System.Drawing.Point(471, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 60);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Citas";
            // 
            // btnIncumplidas
            // 
            this.btnIncumplidas.Location = new System.Drawing.Point(105, 25);
            this.btnIncumplidas.Name = "btnIncumplidas";
            this.btnIncumplidas.Size = new System.Drawing.Size(75, 23);
            this.btnIncumplidas.TabIndex = 1;
            this.btnIncumplidas.Text = "Incumplidas";
            this.btnIncumplidas.UseVisualStyleBackColor = true;
            this.btnIncumplidas.Click += new System.EventHandler(this.btnIncumplidas_Click_1);
            // 
            // btnTodas
            // 
            this.btnTodas.Location = new System.Drawing.Point(6, 25);
            this.btnTodas.Name = "btnTodas";
            this.btnTodas.Size = new System.Drawing.Size(75, 23);
            this.btnTodas.TabIndex = 0;
            this.btnTodas.Text = "Todas";
            this.btnTodas.UseVisualStyleBackColor = true;
            this.btnTodas.Click += new System.EventHandler(this.btnTodas_Click_1);
            // 
            // Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 436);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCitas);
            this.Name = "Citas";
            this.Text = "Citas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAsistencia;
        private System.Windows.Forms.TextBox txtmed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblmedico;
        private System.Windows.Forms.DateTimePicker fechcita;
        private System.Windows.Forms.TextBox txtIdpac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnIncumplidas;
        private System.Windows.Forms.Button btnTodas;
    }
}