namespace PPLabIII_CSNet
{
    partial class frmMascota
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTipoDeMascota = new System.Windows.Forms.Label();
            this.cmbTipoDeMascota = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(37, 65);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(37, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // lblTipoDeMascota
            // 
            this.lblTipoDeMascota.AutoSize = true;
            this.lblTipoDeMascota.Location = new System.Drawing.Point(37, 109);
            this.lblTipoDeMascota.Name = "lblTipoDeMascota";
            this.lblTipoDeMascota.Size = new System.Drawing.Size(86, 13);
            this.lblTipoDeMascota.TabIndex = 6;
            this.lblTipoDeMascota.Text = "Tipo de mascota";
            // 
            // cmbTipoDeMascota
            // 
            this.cmbTipoDeMascota.FormattingEnabled = true;
            this.cmbTipoDeMascota.Location = new System.Drawing.Point(37, 125);
            this.cmbTipoDeMascota.Name = "cmbTipoDeMascota";
            this.cmbTipoDeMascota.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoDeMascota.TabIndex = 7;
            // 
            // frmMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cmbTipoDeMascota);
            this.Controls.Add(this.lblTipoDeMascota);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmMascota";
            this.Text = "frmMascota";
            this.Load += new System.EventHandler(this.frmMascota_Load);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.lblTipoDeMascota, 0);
            this.Controls.SetChildIndex(this.cmbTipoDeMascota, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        protected System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTipoDeMascota;
        protected System.Windows.Forms.ComboBox cmbTipoDeMascota;
    }
}