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
            List<string> family = new List<string> {"Bobby", "Nico <3", "Mama de bauti", "Profe Dipa"};
            List<string> intereses = new List<string> {"67", "dibujar cosas cool", "hacer ejercicios desafiantes de programación"};
            Integrante Bauti = new Integrante(50046913, "Bauti", "fotoAzteka", fecha, family, intereses);
            Integrantes.Add(50046913, Bauti);
            
            fecha = new DateTime(2010, 01, 14);
            family.Clear();
            family.AddRange(new List<string> {"Pequeño, pequeño Maxi(pequeñito y petit)", "En memoria de Sol Hilú.", "Guerreras homosexuales (tortugas)", "Fundadora del Kpassport y de la dinastía Yoon", "Ariiii jsjsj"});
            intereses.Clear();
            intereses.Add("Libros");
            intereses.Add("Bandalizar propiedad del Estado.");
            Integrante Llara = new Integrante(46982167, "Kyara", "*AsiáticaCHINA*", fecha, family, intereses);
            Integrantes.Add(46982167, Llara);
        }
    }
}