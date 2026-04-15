using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace PresentacionGrupo.Models
{
    public class Integrante
    {
        int DNI;
        string Nombre, Foto;
        date FechaNacimiento;
        List<string> Familiares, Intereses;
        public Integrante(int DNI, string nombre, string foto, date fechaN, List<string> familiares, List<string> intereses)
        {
            this.DNI = DNI;
            Nombre = nombre;
            Foto = foto;
            FechaNacimiento = fechaN;
            Familiares = familiares;
            Intereses = intereses;
        }
    }
}