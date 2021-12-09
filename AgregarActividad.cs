using System;
using System.Windows.Forms;

namespace ProyectoFinal2
{
    public partial class frmAgregarAct : Form
    {
        public frmAgregarAct()
        {
            InitializeComponent();
        }
        bool bandNomb=false;
        bool bandPond=false;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
           try
            { 
                errorProvider1.Clear();

                if(txtbNombre.Text== "")
                {
                    bandNomb = true;
                    string error = "Agregue el nombre de la actividad";
                    throw new ApplicationException(error);
                }else if (txtbPond.Text == "")
                {
                    bandPond = true;
                    string error = ("Agregue la ponderación de ");
                    throw new ApplicationException(error);
                }
                IPasarAct PD = this.Owner as IPasarAct;
                Actividad actividadN = new Actividad();
                actividadN.Nombre = txtbNombre.Text;
                actividadN.Ponderación = float.Parse(txtbPond.Text);
                actividadN.Calificacion = 0;
                if (Form1.actividades.Count == 0)
                {
                    actividadN.Id = 1;
                }
                else
                {
                    actividadN.Id = Form1.actividades.Count + 1;
                }
                if (PD != null)
                {
                    PD.PasarAct(actividadN);
                    this.Close();
                }
            }
            catch(ApplicationException error)
            {
                if (bandNomb)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtbNombre, error.Message);
                } 
                if (bandPond)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtbPond, error.Message);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            IEditarAct EA = this.Owner as IEditarAct;
            Actividad edAct = new Actividad();
            edAct.Nombre = txtbNombre.Text;
            edAct.Ponderación = float.Parse(txtbPond.Text);
            if (EA != null)
            {
                EA.EditarAct(edAct);
                this.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach(Actividad act in Form1.actividades)
            {
                if (txtbNombre.Text == act.Nombre)
                {
                    Form1.actividades.Remove(act);
                    MessageBox.Show("Actividad eliminada conéxito");
                    foreach(Alumno alumno in Form1.alumnos)
                    {
                        alumno.Actividades.Remove(act);
                    }
                    break;
                }
                else
                {
                    MessageBox.Show("Actividad no encontrada");
                }
            }
            this.Close();
        }
    }
}
