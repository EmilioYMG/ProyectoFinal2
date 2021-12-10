using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFinal2
{
    public partial class frmActividades : Form,IPasarAct,IEditarAct
    {
        List<Alumno> alumnos;
        List<Actividad> actividades;
        List<Actividad> sortedActs;
        public bool bandEditDel; //si es true edita, false elimina
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
            ValidarLista();
            sortedActs= actividadespadre.OrderBy(Actividad => Actividad.Id).ToList();
            dgvActividades.DataSource = sortedActs;

        }
        public Actividad nAct;

        private void ValidarLista()
        {
            if (actividades == null)
            {
                actividades = new List<Actividad>();
                sortedActs = new List<Actividad>();
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmAgregarAct IAC = new frmAgregarAct();
            AddOwnedForm(IAC);
            IAC.btnEditar.Hide();
            IAC.btnEliminar.Hide();
            IAC.ShowDialog();
        }
        #region Interfaces usadas
        public void PasarAct(Actividad nAct)
        {
            actividades.Add(nAct);
            List<Actividad> sortedActs = actividades.OrderBy(Actividad => Actividad.Id).ToList();
            dgvActividades.DataSource = sortedActs;
        }
        public void EditarAct(Actividad edAct)
        {
            edAct.Id = int.Parse(dgvActividades.CurrentRow.Cells[3].Value.ToString());
            foreach(Actividad act in actividades)
            {
                if(edAct.Id==act.Id)
                {
                    act.Nombre = edAct.Nombre;
                    act.Ponderación = edAct.Ponderación;
                }
            }
        }
        #endregion
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            List<string> nomb= actividades.ConvertAll(Actividad => Actividad.Nombre);
           foreach(Alumno alumno in alumnos)
            {
                alumno.Actividades = actividades;
            }
            Form1.alumnos = alumnos;
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            bandEditDel = true;
            frmAgregarAct edAct = new frmAgregarAct();
            edAct.btnAceptar.Hide();
            edAct.btnEliminar.Hide();
            AddOwnedForm(edAct);
            if (dgvActividades.SelectedRows.Count > 0)
            {
                edAct.txtbNombre.Text = dgvActividades.CurrentRow.Cells[0].Value.ToString();
                edAct.txtbPond.Text = dgvActividades.CurrentRow.Cells[2].Value.ToString();
                edAct.ShowDialog();
            }
            else
            {
                MessageBox.Show("Se debe seleccionar una fila");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmAgregarAct delAct = new frmAgregarAct();
            delAct.btnAceptar.Hide();
            delAct.btnEditar.Hide();
            AddOwnedForm(delAct);
            if (dgvActividades.SelectedRows.Count > 0)
            {
                delAct.txtbNombre.Text = dgvActividades.CurrentRow.Cells[0].Value.ToString();
                delAct.txtbPond.Text= dgvActividades.CurrentRow.Cells[2].Value.ToString();
                delAct.ShowDialog();
            }
            else
            {
                MessageBox.Show("Se debe seleccionar una fila");
            }
        }

        private void dgvActividades_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bandEditDel == true)
            {
                frmAgregarAct edAct = Owner as frmAgregarAct;
                AddOwnedForm(edAct);
            }
            else
            {
                frmAgregarAct delAct = Owner as frmAgregarAct;
                AddOwnedForm(delAct);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            List<Actividad> sorted = actividades.OrderBy(Actividad => Actividad.Id).ToList();
            dgvActividades.DataSource = sorted;
        }
    }
}
