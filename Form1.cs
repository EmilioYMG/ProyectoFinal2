using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProyectoFinal2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        //Funciones para poder arrastrar la ventana.
        public static List<Alumno> alumnos = new List<Alumno>();
        public static List<Actividad> actividades = new List<Actividad>();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL",EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,int wparam,int lparam);

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
                MenuVertical.Width = 250;
        }

        private void IconoCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IconoMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IconoMaximizar.Visible = false;
            IconoRestaurar.Visible = true;
        }

        private void IconoRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            IconoMaximizar.Visible = true;
            IconoRestaurar.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void IconoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
            }
            Form fh=Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Alumnos(alumnos,actividades));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Buscar());
        }

        private void btnActs_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmActividades(actividades, alumnos));
        }

        private void btnAddAct_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmAgregarCalif(actividades,alumnos));
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Asistencia(alumnos));
        }
    }
}
