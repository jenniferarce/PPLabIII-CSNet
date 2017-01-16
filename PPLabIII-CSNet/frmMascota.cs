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
    public partial class frmMascota : frmAnimal
    {
        private Mascota _miMascota;

        public frmMascota():base()
        {
            InitializeComponent();
        }
        public frmMascota(Mascota unaMascota)
            : this()
        {
            txtEdad.Text = unaMascota.Edad.ToString();
            txtNombre.Text = unaMascota.Nombre;

            cmbTipoDeMascota.SelectedItem = unaMascota.TipoDeMascota;
        }//Para modificacion y baja

        private void frmMascota_Load(object sender, EventArgs e)
        {
            CargarCombo();
            cmbTipoDeMascota.DropDownStyle = ComboBoxStyle.DropDownList;//evita que se pueda escribir en el combo
            cmbTipoDeMascota.SelectedIndex = 0;//se ve por defecto la primer opcion

            this.btnAceptar.Click += AceptarManejador;
            this.btnCancelar.Click += CancelarManejador;
        }

        public Mascota MiMascota
        {
            get { return _miMascota; }
        }

        public void CargarCombo() //cargo el combo de tipos de mascotas
        {
            foreach (eTipoDeMascota tipo in Enum.GetValues(typeof(eTipoDeMascota)))
            {
                cmbTipoDeMascota.Items.Add(tipo);//ingreso los items
            }//recorro el enum
        }//cargarcombo

        public override void AceptarManejador(object sender, EventArgs e)
        {
            _miMascota = new Mascota(txtNombre.Text, (eTipoDeMascota)cmbTipoDeMascota.SelectedItem, int.Parse(txtEdad.Text));//inicializo la mascota
            base.AceptarManejador(sender, e);
        }
        public override void CancelarManejador(object sender, EventArgs e)
        {
            base.CancelarManejador(sender, e);
            this.Close();
        }
    }
}
