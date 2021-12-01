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
    public partial class frmAgregarCalif : Form
    {
        List<Actividad> actividades = Form1.actividades;
        List<string> nomb = Form1.actividades.ConvertAll(Actividad => Actividad.Nombre); 
        public frmAgregarCalif()
        {
            InitializeComponent();
            cmbNombAct.DataSource = nomb;
            txtbNombre.Enabled = false;
            txtbApellidos.Enabled = false;
            txtbNL.Enabled = false;
        }
        

        private void btnAcept_Click(object sender, EventArgs e)
        {
           // try
            {
                if (rdbNombre.Checked == true)
                {
                    foreach (Alumno alumno in Form1.alumnos)
                    {
                        if (alumno.Nombre == txtbNombre.Text)
                        {
                            txtbApellidos.Text = alumno.Apellidos;
                            txtbNL.Text = alumno.NumLista.ToString();
                            foreach (Actividad act in alumno.Actividades)
                            {
                                if (act.Nombre == cmbNombAct.SelectedItem.ToString())
                                {
                                    txtbCalif.Text = act.Calificacion.ToString(); 
                                    act.Calificacion = float.Parse(txtbCalif.Text);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Alumno no encontrado\nRevise la ortografía porfavor");
                        }
                    }
                }
            }
        }

        private void rdbNombre_CheckedChanged(object sender, EventArgs e)
        {
            txtbNombre.Enabled = true;
            txtbApellidos.Enabled = false;
            txtbNL.Enabled = false;
        }

        private void rdbApe_CheckedChanged(object sender, EventArgs e)
        {
            txtbApellidos.Enabled = true;
            txtbNombre.Enabled = false;
            txtbNL.Enabled = false;
        }

        private void rdbNL_CheckedChanged(object sender, EventArgs e)
        {
            txtbNL.Enabled = true;
            txtbNombre.Enabled = false;
            txtbApellidos.Enabled = false;
        }
    }
}
