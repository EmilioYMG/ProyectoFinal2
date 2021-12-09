using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal2
{
    public class Actividad
    {
        #region Atributos
        int id;
        string nombre;
        float calificacion;
        float ponderación;

        public string Nombre { get => nombre; set => nombre = value; }
        public float Calificacion { get => calificacion; set => calificacion = value; }
        public float Ponderación { get => ponderación; set => ponderación = value; }
        public int Id { get => id; set => id = value; }
        #endregion
    }
}
