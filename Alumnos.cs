using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFinal2
{
    public partial class Alumnos : Form,IPasardatos,IEditarAlumno
    {
        private DataTable dt;
        public Alumnos()
        {
            InitializeComponent();
            
            dt = new DataTable();
            dt.Columns.Add("Número de lista");
            dt.Columns.Add("Apellidos");
            dt.Columns.Add("Nombre(s)");
            dt.Columns.Add("Promedio");
            dt.Columns.Add("Faltas");
            dgvAlumnos.DataSource = dt;
            List<Alumno> sortedList = alumnos.OrderBy(Alumno => Alumno.NumLista).ToList();
            dgvAlumnos.DataSource = sortedList;
        }
        public List<Alumno> sortedlist;
        public List<Alumno> alumnos = Form1.alumnos;
        public Alumno NAlumno;
        public void Pasaralumno(Alumno NAlumno)
        {
            alumnos.Add(NAlumno);
            List<Alumno> sortedList= alumnos.OrderBy(Alumno => Alumno.NumLista).ToList();
            dgvAlumnos.DataSource = sortedList;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            IngresarAlumno IA = new IngresarAlumno();
            IA.btnEliminar.Hide();
            AddOwnedForm(IA); 
            IA.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Form1.alumnos = alumnos;
            this.Close();
        }

        public void EditarAlumno(Alumno MAlumno)
        {
            int nl = MAlumno.NumLista;
            foreach(Alumno alumno in alumnos)
            {
                if (alumno.NumLista == nl)
                {
                    alumno.Nombre = MAlumno.Nombre;
                    alumno.Apellidos = MAlumno.Apellidos;
                }
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            Buscar frm = new Buscar();
            frm.rbtnBuscar.Enabled = false;
            frm.rbtnEditar.Enabled = true;
            frm.rbtnEditar.Checked = true;
            AddOwnedForm(frm);
            
            if (dgvAlumnos.SelectedRows.Count > 0)
            {
                frm.txtbNombre.Text = dgvAlumnos.CurrentRow.Cells[1].Value.ToString();
                frm.txtbNL.Text = dgvAlumnos.CurrentRow.Cells[0].Value.ToString();
                frm.txtbApe.Text = dgvAlumnos.CurrentRow.Cells[2].Value.ToString();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Se debe seleccionar una fila");
            }
        }

        private void dgvAlumnos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Buscar frm = Owner as Buscar;
            AddOwnedForm(frm); 
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            foreach(Alumno alumno in Form1.alumnos)
            {
                
            }
            List<Alumno> sortedList = alumnos.OrderBy(Alumno => Alumno.NumLista).ToList();
            dgvAlumnos.DataSource = sortedList;
            MessageBox.Show("Actualización exitosa");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            IngresarAlumno frm = new IngresarAlumno();
            frm.btnGuardar.Hide();
            frm.ShowDialog();
            foreach (Alumno alumno in Form1.alumnos)
            {
                if(alumno.Nombre == frm.txtbNombre.Text || alumno.Apellidos == frm.txtbApellidos.Text || alumno.NumLista.ToString() == frm.txtbNL.Text)
                {
                    frm.txtbNombre.Text = alumno.Nombre;
                    frm.txtbApellidos.Text = alumno.Apellidos;
                    frm.txtbNL.Text = alumno.NumLista.ToString();
                    Form1.alumnos.Remove(alumno);
                    MessageBox.Show("Alumno eliminado con éxito");
                    break;
                }
            }
        }

        private void Alumnos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.alumnos = alumnos;
        }
    }
}
