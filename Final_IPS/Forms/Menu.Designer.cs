namespace Final_IPS
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.opcMedicos = new System.Windows.Forms.ToolStripMenuItem();
            this.opcCitas = new System.Windows.Forms.ToolStripMenuItem();
            this.opcSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(470, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcPacientes,
            this.opcMedicos,
            this.opcCitas,
            this.opcSalir});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // opcPacientes
            // 
            this.opcPacientes.Name = "opcPacientes";
            this.opcPacientes.Size = new System.Drawing.Size(124, 22);
            this.opcPacientes.Text = "Pacientes";
            this.opcPacientes.Click += new System.EventHandler(this.opcPacientes_Click);
            // 
            // opcMedicos
            // 
            this.opcMedicos.Name = "opcMedicos";
            this.opcMedicos.Size = new System.Drawing.Size(124, 22);
            this.opcMedicos.Text = "Medicos";
            this.opcMedicos.Click += new System.EventHandler(this.opcMedicos_Click);
            // 
            // opcCitas
            // 
            this.opcCitas.Name = "opcCitas";
            this.opcCitas.Size = new System.Drawing.Size(124, 22);
            this.opcCitas.Text = "Citas";
            this.opcCitas.Click += new System.EventHandler(this.opcCitas_Click);
            // 
            // opcSalir
            // 
            this.opcSalir.Name = "opcSalir";
            this.opcSalir.Size = new System.Drawing.Size(124, 22);
            this.opcSalir.Text = "Salir";
            this.opcSalir.Click += new System.EventHandler(this.opcSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "IPS MEJORA TU SALUD";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(470, 379);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcPacientes;
        private System.Windows.Forms.ToolStripMenuItem opcMedicos;
        private System.Windows.Forms.ToolStripMenuItem opcCitas;
        private System.Windows.Forms.ToolStripMenuItem opcSalir;
        private System.Windows.Forms.Label label1;
    }
}