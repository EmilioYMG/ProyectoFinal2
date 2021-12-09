using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal2
{
    #region Interfaces alumno
    public interface IPasardatos
    {
        void Pasaralumno(Alumno NAlumno);

    }
    public interface IEditarAlumno
    {
        void EditarAlumno(Alumno EAlumno);
    }
    #endregion
    #region Interfaces Actividad
    public interface IPasarAct
    {
        void PasarAct(Actividad nAct);
    }
    public interface IEditarAct
    {
        void EditarAct(Actividad edAct);
    }
    #endregion


}
