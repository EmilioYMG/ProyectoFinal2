using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal2
{
    public interface IPasardatos
    {
        void Pasaralumno(Alumno NAlumno);
        
    }
    public interface IPasarAct
    {
        void PasarAct(Actividad nAct);
    }
    public interface IEditarAlumno
    {
        void EditarAlumno(Alumno EAlumno);
    }
}
