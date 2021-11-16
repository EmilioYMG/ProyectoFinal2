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
    public partial class frmAgregarAct : Form
    {
        public frmAgregarAct()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           // try
            {

                IPasarAct PD = this.Owner as IPasarAct;
                Actividad actividadN = new Actividad();
                actividadN.Nombre = txtbNombre.Text;
                actividadN.Ponderación = float.Parse(txtbPond.Text);
                if (PD != null)
                {
                    PD.PasarAct(actividadN);
                    this.Close();
                }
            }
            //catch 
            {
            
            
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
