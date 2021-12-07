using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFinal2
{
    public partial class frmActividades : Form,IPasarAct
    {
        List<Alumno> alumnos;
        List<Actividad> actividades;
        List<Actividad> sortedActs;

        private DataTable dt;
        public frmActividades(List<Actividad> actividadespadre, List<Alumno> alumnospadre)
        {
            InitializeComponent();
            alumnos = alumnospadre;
            actividades = actividadespadre;
            dt = new DataTable();
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Ponderación%");
            dgvActividades.DataSource = dt;
            List<Actividad> sortedActs= actividadespadre.OrderBy(Actividad => Actividad.Nombre).ToList();
            dgvActividades.DataSource = sortedActs;

        }
        public Actividad nAct;
        
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Form IAC = new frmAgregarAct();
            AddOwnedForm(IAC);
            IAC.ShowDialog();
        }
        public void PasarAct(Actividad nAct)
        {
            actividades.Add(nAct);
            List<Actividad> sortedActs = actividades.OrderBy(Actividad => Actividad.Nombre).ToList();
            dgvActividades.DataSource = sortedActs;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Form1.actividades = actividades;
            List<string> nomb= actividades.ConvertAll(Actividad => Actividad.Nombre);
            foreach (Alumno alumno in alumnos)
            {
                foreach(Actividad act in alumno.Actividades)
                {
                    for (int i = 0; i <nomb.Count; i++)
                    {
                        act.Nombre = nomb[i];
                    }
                }
            }
            Form1.alumnos = alumnos;
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
