using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nulos
{
    class Alumno
    {
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public List<string>Materias { get; set; }

        public Alumno ()//para uque cunado se cree una instancia nueva de alumno, se puede tener propiedades 
        {
            Materias = new List<string>();//inicializar la lista 
        }
        //los nulls sirev para liberar espacio, en vez de hacelro manualmente

    }
}
