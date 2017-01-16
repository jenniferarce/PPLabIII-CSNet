using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PPLabIII_CSNet
{
    public partial class frmAnimal : Form
    {
        public frmAnimal()
        {
            InitializeComponent();
        }

        public virtual void AceptarManejador(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }//lo coloco como virtual para poder sobreescribirlo

        public virtual void CancelarManejador(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }//lo coloco como virtual para poder sobreescribirlo

        private void frmAnimal_Load(object sender, EventArgs e)
        {
            btnAceptar.Click += AceptarManejador;
            btnCancelar.Click += CancelarManejador;
        }



    }
}
