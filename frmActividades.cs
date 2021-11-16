using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal2
{
    public partial class frmActividades : Form,IPasarAct
    {
        private DataTable dt;
        public frmActividades()
        {
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Ponderación %");
            dgvActividades.DataSource = dt;
            List<Actividad> sortedActs= actividades.OrderBy(Actividad => Actividad.Nombre).ToList();
            dgvActividades.DataSource = sortedActs;

        }
        public List<Actividad> actividades = new List<Actividad>();
        public List<Actividad> sortedActs;
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
            foreach(Alumno alumno in Form1.alumnos)
            {
                alumno.Actividades = sortedActs;
            }
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
