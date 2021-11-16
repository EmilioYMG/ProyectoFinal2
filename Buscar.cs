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
    public partial class Buscar : Form
    {
        private DataTable dt;
        public Buscar()
        {
            InitializeComponent();
            rbtnBuscar.Checked = true;
            btnBuscar.Enabled = true;
            dt = new DataTable();
            dt.Columns.Add("Actividad");
            dt.Columns.Add("Calificación");
            dgvResumen.DataSource = dt;

        }
        public List<Alumno> miLista;
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Alumnos frm = new Alumnos();
            AddOwnedForm(frm);
            frm.alumnos = Form1.alumnos;
            IngresarAlumno frm2 = new IngresarAlumno();
            frm2.btnGuardar.Hide();
            foreach(Alumno alumno in frm.alumnos)
            {
                if (alumno.Nombre == txtbNombre.Text||alumno.Apellidos==txtbApe.Text||alumno.NumLista.ToString()==txtbNL.Text)
                {
                    frm2.txtbNombre.Text = alumno.Nombre;
                    frm2.txtbApellidos.Text = alumno.Apellidos;
                    frm2.txtbNL.Text = alumno.NumLista.ToString();
                    frm2.Show();
                }
            }
            


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Buscar_Load(object sender, EventArgs e)
        {
            btnBuscar.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void rbtnBuscar_CheckedChanged(object sender, EventArgs e)
        {
            btnBuscar.Enabled = true;
            btnEditar.Enabled = false;
        }

        private void rbtnEditar_CheckedChanged(object sender, EventArgs e)
        {
            btnBuscar.Enabled = false;
            btnEditar.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            IEditarAlumno PD = this.Owner as IEditarAlumno;
            Alumno eAlumno = new Alumno();
            eAlumno.Nombre = txtbNombre.Text;
            eAlumno.NumLista = int.Parse(txtbNL.Text);
            eAlumno.Apellidos = txtbApe.Text;            
            if (PD != null)
            {
                PD.EditarAlumno(eAlumno);
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Size = new Size(896, 286);
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            Size = new Size(402, 277);
        }
    }
}
