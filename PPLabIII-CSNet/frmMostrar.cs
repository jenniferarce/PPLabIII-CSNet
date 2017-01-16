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
    public partial class frmMostrar : Form
    {
        public frmMostrar()
        {
            InitializeComponent();
        }

        private void frmMostrar_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        public void ActualizarListados(List<Mascota> _lista)
        {
            if (object.ReferenceEquals(_lista, null))
            { }

            else
            {
                lstMostrar.Items.Clear();
                foreach (Mascota item in _lista)
                {
                    lstMostrar.Items.Add(item.Nombre);
                }
            }
        }//ActualizarListado
    }
}
