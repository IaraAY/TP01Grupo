using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace PresentacionGrupo.Models
{
    public class Curso
    {
        public Dictionary<int, Integrante> Integrantes;
        public Curso()
        {
            Integrantes = new Dictionary<int, Integrante>();
            DateTime fecha = new DateTime(2010, 01, 28);
            List<string> familyB = new List<string> {"Bobby", "Nico <3", "Mama de bauti", "Profe Dipa"};
            List<string> interesesB = new List<string> {"67", "dibujar cosas cool", "hacer ejercicios desafiantes de programación"};
            Integrante Bauti = new Integrante(50046913, "Bauti", "fotoAzteka.png", fecha, familyB, interesesB);
            Integrantes.Add(50046913, Bauti);
            
            fecha = new DateTime(2010, 01, 14);
            List<string> familyI = new List<string> {"Pequeño, pequeño Maxi(pequeñito y petit)", "En memoria de Sol Hilú.", "Guerreras homosexuales (tortugas)", "Fundadora del Kpassport y de la dinastía Yoon", "Ariiii jsjsj"};
            List<string> interesesI = new List<string> {"Libros", "Bandalizar propiedad del Estado."};
            Integrante Llara = new Integrante(46982167, "Kyara", "AsiáticaCHINA.png", fecha, familyI, interesesI);
            Integrantes.Add(46982167, Llara);
        }
    }
}