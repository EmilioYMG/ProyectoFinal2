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
            this.Close();
        }
    }
}
