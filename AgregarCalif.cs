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
        List<Actividad> actividades;
        List<string> nomb;
        List<Alumno> alumnos;
        public frmAgregarCalif(List<Actividad> actividadespadre, List<Alumno> alumnospadre)
        {
            InitializeComponent();
            nomb = actividadespadre.ConvertAll(Actividad => Actividad.Nombre);
            alumnos = alumnospadre;
            cmbNombAct.DataSource = nomb;
            txtbNombre.Enabled = false;
            txtbApellidos.Enabled = false;
            txtbNL.Enabled = false;
        }
        

        private void btnAcept_Click(object sender, EventArgs e)
        {
           // try
            //{
                if (rdbNombre.Checked == true)
                {
                    for(int i = 0; i < alumnos.Count; i++)
                    {
                        if (alumnos[i].Nombre == txtbNombre.Text)
                        {
                            txtbNL.Text = alumnos[i].NumLista.ToString();
                            txtbApellidos.Text = alumnos[i].Apellidos;
                        Asignar(alumnos[i]);
                        }
                    }
                }
            //}
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
        private void Asignar(Alumno al)
        {
            foreach(Actividad act in al.Actividades)
            {
                if (act.Nombre == cmbNombAct.SelectedItem.ToString())
                {
                    act.Calificacion = float.Parse(txtbCalif.Text);
                }
            }
        }

        private void frmAgregarCalif_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.alumnos = alumnos;
            Form1.actividades = actividades;
        }
    }
}
