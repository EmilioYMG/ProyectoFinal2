 using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace ProyectoFinal2
{
    public partial class Alumnos : Form,IPasardatos,IEditarAlumno
    {
        private DataTable dt;
        public Alumnos(List<Alumno> alumnospadre,List<Actividad> actividadespadre)
        {
            InitializeComponent();
            alumnos = alumnospadre;
            actividades = actividadespadre;
            dt = new DataTable();
            dt.Columns.Add("Número de lista");
            dt.Columns.Add("Apellidos");
            dt.Columns.Add("Nombre(s)");
            dt.Columns.Add("Promedio");
            dt.Columns.Add("Faltas");
            dgvAlumnos.DataSource = dt;
            List<Alumno> sortedList = alumnos.OrderBy(Alumno => Alumno.NumLista).ToList();
            dgvAlumnos.DataSource = sortedList;
            ValidarGuardar();
        }
        public List<Alumno> sortedlist;
        public List<Alumno> alumnos;
        public List<Actividad> actividades;
        public Alumno NAlumno;
        public bool banderaBE=false;
        public void Pasaralumno(Alumno NAlumno)
        {
            alumnos.Add(NAlumno);
            List<Alumno> sortedList= alumnos.OrderBy(Alumno => Alumno.NumLista).ToList();
            dgvAlumnos.DataSource = sortedList;
            ValidarGuardar();
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

            banderaBE = true;
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
            if (banderaBE == true)
            {
                Buscar frm = Owner as Buscar;
                AddOwnedForm(frm);
            }
            else
            {
                IngresarAlumno frm = Owner as IngresarAlumno;
                AddOwnedForm(frm);
            }
            
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
            AddOwnedForm(frm);
            if (dgvAlumnos.SelectedRows.Count > 0)
            {
                frm.txtbNL.Text = dgvAlumnos.CurrentRow.Cells[0].Value.ToString();
                frm.txtbApellidos.Text = dgvAlumnos.CurrentRow.Cells[1].Value.ToString();
                frm.txtbNombre.Text = dgvAlumnos.CurrentRow.Cells[2].Value.ToString();
                //utilizando NAlumno para la comparación
                frm.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Se debe seleccionar una fila");
            }
        }

        private void Alumnos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.alumnos = alumnos;
        }
        #region Archivos
        private void ValidarGuardar()
        {
            if (dgvAlumnos.Rows.Count == 0)
            {
                guardarToolStripMenuItem.Enabled = false;
            }
            else
            {
                guardarToolStripMenuItem.Enabled = true;
            }
        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivos de texto | *.txt| Archivo delimitado por ','*.csv| *csv| Todos los archivos(*,*)| *.* ";
            sfd.DefaultExt = "+.csv";
            StreamWriter sw = null;
            try
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    sw = new StreamWriter(sfd.FileName);
                    sw.WriteLine("# Lista,Apellidos,Nombre,Promedio,Faltas");
                    foreach(Alumno alumno in alumnos)
                    {
                        sw.WriteLine("{0},{1},{2},{3},{4}", alumno.NumLista, alumno.Apellidos, alumno.Nombre, alumno.Promedio, alumno.Faltas);
                    }
                }
            }
            catch (IOException error)
            {
                MessageBox.Show("Error", error.Message);
            }
            finally
            {
                sw.Close();
            }

        }
    }   
        #endregion
}
