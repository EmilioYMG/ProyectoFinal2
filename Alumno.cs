using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal2
{
    public class Alumno
    {
        #region Atributos
        int numLista;
        string nombre;
        string apellidos;
        float promedio;
        int faltas;
        List<Actividad> actividades;
        #endregion
        #region Constructor


        public int NumLista { get => numLista; set => numLista = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public float Promedio { get => promedio; set => promedio = value; }
        public int Faltas { get => faltas; set => faltas = value; }
        public List<Actividad> Actividades { get => actividades; set => actividades = value; }

        #endregion
    }
}
