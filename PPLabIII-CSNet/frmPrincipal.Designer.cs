namespace PPLabIII_CSNet
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBaja = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbOrdenamiento = new System.Windows.Forms.ToolStripComboBox();
            this.mostrarListadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAlta,
            this.btnBaja,
            this.btnModificar,
            this.btnSalir,
            this.cmbOrdenamiento,
            this.mostrarListadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(439, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAlta
            // 
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(40, 23);
            this.btnAlta.Text = "Alta";
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(41, 23);
            this.btnBaja.Text = "Baja";
            // 
            // btnModificar
            // 
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(70, 23);
            this.btnModificar.Text = "Modificar";
            // 
            // btnSalir
            // 
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(41, 23);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cmbOrdenamiento
            // 
            this.cmbOrdenamiento.Name = "cmbOrdenamiento";
            this.cmbOrdenamiento.Size = new System.Drawing.Size(121, 23);
            this.cmbOrdenamiento.SelectedIndexChanged += new System.EventHandler(this.cmbOrdenamiento_SelectedIndexChanged);
            // 
            // mostrarListadoToolStripMenuItem
            // 
            this.mostrarListadoToolStripMenuItem.Name = "mostrarListadoToolStripMenuItem";
            this.mostrarListadoToolStripMenuItem.Size = new System.Drawing.Size(98, 23);
            this.mostrarListadoToolStripMenuItem.Text = "MostrarListado";
            this.mostrarListadoToolStripMenuItem.Click += new System.EventHandler(this.mostrarListadoToolStripMenuItem_Click);
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.Location = new System.Drawing.Point(25, 44);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(369, 186);
            this.lstLista.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 262);
            this.Controls.Add(this.lstLista);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "ABM Mascotas";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnAlta;
        private System.Windows.Forms.ToolStripMenuItem btnBaja;
        private System.Windows.Forms.ToolStripMenuItem btnModificar;
        private System.Windows.Forms.ToolStripMenuItem btnSalir;
        private System.Windows.Forms.ToolStripComboBox cmbOrdenamiento;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.ToolStripMenuItem mostrarListadoToolStripMenuItem;

        public System.EventHandler cmbOrdenamiento_Click { get; set; }
    }
}