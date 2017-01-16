using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PPLabIII_CSNet
{
    public partial class frmPrincipal : Form
    {
        private List<Mascota> _listaMascotas;
        private frmMascota mascotaForm;
        public Comparison<Mascota> comparador;
        public frmMostrar Mostrar;
        public delegate void miDelegado(List<Mascota> lista);
        public miDelegado instanciaDelegado;
        
        public frmPrincipal()
        {
            InitializeComponent();

            _listaMascotas = new List<Mascota>();
            Mostrar = new frmMostrar();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CargarCombo();

            cmbOrdenamiento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrdenamiento.SelectedIndex = 0;
            lstLista.SelectedIndexChanged += AgregarManejSelectLBox;

        }

        #region **-- Botones del menu --**
        private void btnAlta_Click(object sender, EventArgs e)
        {
            mascotaForm = new frmMascota();

            if (mascotaForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _listaMascotas.Add(mascotaForm.MiMascota);
                ActualizarListBox();
                instanciaDelegado += Mostrar.ActualizarListados;
                instanciaDelegado(_listaMascotas);

            }
            btnBaja.Click -= ManejadorCentral;
            btnModificar.Click -= ManejadorCentral;
            lstLista.SelectedIndexChanged += AgregarManejSelectLBox;
        }//BOTON ALTA

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }//BOTON SALIR

        private void mostrarListadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (object.ReferenceEquals(instanciaDelegado, null) == false)
            {
                Mostrar.Show();
            }
        }//BOTON MOSTRAR LISTADO
        #endregion 

        #region *- Combo de Ordenamiento -*
        public void CargarCombo() //cargo el combo de tipos de ordenamiento
        {
            foreach (eTipoOrdenamiento tipo in Enum.GetValues(typeof(eTipoOrdenamiento)))
            {
                cmbOrdenamiento.Items.Add(tipo);
            }//recorro el enum
        }//CARGA

        private void cmbOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrdenamiento.SelectedIndex == 0)
            {
                comparador = new Comparison<Mascota>(Mascota.OrdenarPorEdad);
                _listaMascotas.Sort(comparador);
                ActualizarListBox();
            }
            else if (cmbOrdenamiento.SelectedIndex == 1)
            {
                comparador = new Comparison<Mascota>(Mascota.OrdenarPorNombre);
                _listaMascotas.Sort(comparador);
                ActualizarListBox();
            }
            else
            {
                comparador = new Comparison<Mascota>(Mascota.OrdenarPorTipo);
                _listaMascotas.Sort(comparador);
                ActualizarListBox();
            }
        }//Ordeno la lista como cambie la seleccion del combo de ordenamiento
        #endregion 

        #region ManejadorCentral - *--Baja y Modificacion--**
        private void ManejadorCentral(object sender, EventArgs e)
        {
            int indice = lstLista.SelectedIndex;

            if (sender is ToolStripItem)
            {
                if (((ToolStripItem)sender).Name == "btnBaja")
                {
                    mascotaForm = new frmMascota(_listaMascotas[indice]);
                    if (mascotaForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        _listaMascotas.RemoveAt(indice);
                        ActualizarListBox();
                        instanciaDelegado(_listaMascotas);
                    }
                }//if

                else if (((ToolStripItem)sender).Name == "btnModificar")
                {
                   mascotaForm = new frmMascota(_listaMascotas[indice]);
                    if (mascotaForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        _listaMascotas[indice] = mascotaForm.MiMascota;
                        ActualizarListBox();
                        instanciaDelegado(_listaMascotas);
                    }
                }//elseif

            }

           btnBaja.Click -= ManejadorCentral;
           btnModificar.Click -= ManejadorCentral;
            lstLista.SelectedIndexChanged += AgregarManejSelectLBox;
        }//Verifico el tipo Mod o baja
        #endregion

        #region *- ListBox -*  
        public void AgregarManejSelectLBox(object sender, EventArgs e)
        {
            btnBaja.Click += ManejadorCentral;
            btnModificar.Click += ManejadorCentral;
            lstLista.SelectedIndexChanged -= AgregarManejSelectLBox;
        }//MANEJADOR

        public void ActualizarListBox()
        {
            lstLista.Items.Clear();
            foreach (Mascota _masc in _listaMascotas)
            {
                lstLista.Items.Add(_masc);
            }
        }//Actualizo el listado 
        #endregion 

       


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            StreamWriter esc = new StreamWriter(Application.StartupPath + "Mascotas-Lista.txt", true);

            if (MessageBox.Show("Desea salir de la aplicacion?", "Cerrando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }

            foreach (Mascota item in _listaMascotas)
            {
                esc.WriteLine(item.ToString());
            }
            esc.WriteLine("*----------------------*");
            esc.Close();
        }
 
    }
}
