using System;
using System.Windows.Forms;

namespace ProyectoFinal2
{
    public partial class IngresarAlumno : Form
    {
        public IngresarAlumno()
        {
            InitializeComponent();
        }
        bool banderaNom=false;
        bool banderaApe = false;
        bool banderaNL = false;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();


                if(txtbNombre.Text == "")
                {
                    banderaNom = true;
                    string error = "Agregue un nombre";
                    throw new ApplicationException(error);
                }else if (txtbNL.Text == "")
                {
                    banderaNL = true;
                    string error = "Agregue un número de lista";
                    throw new ApplicationException(error);
                }
                else if (txtbApellidos.Text == "")
                {
                    banderaApe = true;
                    string error = "Agregue el apellido del alumno a registrar";
                    throw new ApplicationException(error);
                }
                IPasardatos PD = this.Owner as IPasardatos;
                Alumno AlumnoN = new Alumno();
                AlumnoN.Nombre = txtbNombre.Text;
                AlumnoN.Apellidos = txtbApellidos.Text;
                AlumnoN.NumLista = int.Parse(txtbNL.Text);
                AlumnoN.Actividades = Form1.actividades;
                float aux = 0;
                foreach(Actividad act in AlumnoN.Actividades)
                {
                    aux = aux + (act.Calificacion*act.Ponderación)/10;
                }
                AlumnoN.Promedio = aux/10;


                if (PD != null)
                    PD.Pasaralumno(AlumnoN);
                this.Close();
            }
            catch(ApplicationException error)
            {
                if (banderaNom)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtbNombre, error.Message);
                }
                if (banderaNL)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtbNL, error.Message);
                }
                if (banderaApe)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtbApellidos, error.Message);
                }
            }
        }
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (Alumno alumno in Form1.alumnos)
            {
                if (txtbNL.Text == alumno.NumLista.ToString())
                {

                    Form1.alumnos.Remove(alumno);
                    MessageBox.Show("Alumno eliminado con éxito");
                    break;
                }
                else
                {
                    MessageBox.Show("Alumno no encontrado");
                }
            }
            this.Close();
        }
    }
}
