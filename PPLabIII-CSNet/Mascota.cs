using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPLabIII_CSNet
{
    public class Mascota:Animal
    {
        private string _nombre;
        private eTipoDeMascota _tipoDeMascota;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public eTipoDeMascota TipoDeMascota
        {
            get { return _tipoDeMascota; }
            set { _tipoDeMascota = value; }
        }

        public Mascota():base()
        { }
        public Mascota(string nombre, eTipoDeMascota tipo, int edad)
            : base(edad)
        {
            _nombre = nombre;
            _tipoDeMascota = tipo;
        }

        public int OrdenarPorEdad(Mascota m1, Mascota m2)
        {
            return m1.Edad.CompareTo(m2.Edad);
        }
        public int OrdenarPorNombre(Mascota m1, Mascota m2)
        {
            return m1.Nombre.CompareTo(m2.Nombre);
        }
        public int OrdenarPorTipo(Mascota m1, Mascota m2)
        {
            return m1.TipoDeMascota.CompareTo(m2.TipoDeMascota);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Nombre: " + Nombre);
            sb.AppendLine("Tipo: " + TipoDeMascota);

            return sb.ToString();
        }
    }
}
