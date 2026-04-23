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
        DateTime FechaNacimiento;
        List<string> Familiares, Intereses;
        public Integrante(int DNI, string nombre, string foto, DateTime fechaN, List<string> familiares, List<string> intereses)
        {
            this.DNI = DNI;
            Nombre = nombre;
            Foto = foto;
            FechaNacimiento = fechaN;
            Familiares = familiares;
            Intereses = intereses;
        }
        public string DevNombre(){
            return Nombre;
        }
        public int DevDNI(){
            return DNI;
        }
        public string DevFNacimiento(){
            return FechaNacimiento.ToString("dd/MM/yyyy");
        }
        public List<string> DevFamiliares(){
            return Familiares;
        }
        public List<string> DevIntereses(){
            return Intereses;
        }
        public string DevFoto(){
            return Foto;
        }
    }
            
}