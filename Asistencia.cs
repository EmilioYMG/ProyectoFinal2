using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ProyectoFinal2
{
    public partial class Asistencia : Form
    {
        public int i;
        public int tamaño;
        public List<Alumno> alumnos;
        public Asistencia(List<Alumno> alumnospadre)
        {
            InitializeComponent();
            alumnos = alumnospadre;
            tamaño = alumnos.Count;
            i = 0;
            btnAsistio.Enabled = false;
            btnFalta.Enabled = false;
            ValidarGuardar();
        }
        private void PasarAsistencia(int indice, bool bandera)
        {
            int aux = indice;
            if (bandera)
            {
                dgvAsistencia.Rows.Add(alumnos[indice].NumLista, alumnos[indice].Nombre, alumnos[indice].Apellidos, "Si");
                i = aux + 1;
            }
            else if(!bandera)
            {
                alumnos[indice].Faltas = alumnos[indice].Faltas + 1;
                dgvAsistencia.Rows.Add(alumnos[indice].NumLista, alumnos[indice].Nombre, alumnos[indice].Apellidos, "No");
                i = aux + 1;
            }
            
        }

        private void btnAsistio_Click(object sender, EventArgs e)
        {
            bool bandera = true;
            PasarAsistencia(i, bandera);
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            if (i < tamaño)
            {
                txtbNombre.Text = alumnos[i].Nombre;
                txtbApellidos.Text = alumnos[i].Apellidos;
                btnAsistio.Enabled = true;
                btnFalta.Enabled = true;
            }else if (i >= tamaño)
            {
                MessageBox.Show("Todos los alumnos registrados pasaron asistencia");
                btnAsistio.Enabled = false;
                btnFalta.Enabled = false;
                btnComenzar.Enabled = false;
                ValidarGuardar();
            }
            
        }
        private void btnFalta_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            PasarAsistencia(i, bandera);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Form1.alumnos = alumnos;
            this.Close();
        }
        //Archivos
        private void ValidarGuardar()
        {
            if (dgvAsistencia.Rows.Count == 0)
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
                    sw.WriteLine(dateTimePicker1.Value.ToString());
                    sw.WriteLine("# Lista,Nombre,Apellidos,Asistencia");
                    for(int j = 0; j < dgvAsistencia.Rows.Count; j++)
                    {
                        sw.WriteLine("{0},{1},{2},{3}", dgvAsistencia.Rows[j].Cells["ColNL"].Value, dgvAsistencia.Rows[j].Cells["ColNombre"].Value, dgvAsistencia.Rows[j].Cells["ColApellidos"].Value, dgvAsistencia.Rows[j].Cells["ColAsistencia"].Value);
                    }
                }
            }catch(IOException error)
            {
                MessageBox.Show("Error" + error);
            }
            finally
            {
                sw.Close();
            }
        }
    }
}
