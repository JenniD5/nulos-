using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nulos
{
    class Program
    {
        static Alumno alumno;

        static void Main(string[] args)
        {
           alumno = new Alumno();//se el asigna un espacio en la memoria para que tenga los atributis y metodos de la clse aluumno


           alumno.Materias.Add("matematicas");

            ImprimirAlumno();
            Console.Read();
            
        }

        static void ImprimirAlumno()// para que o marque error, ya que es nula, y debes de inicializarla antes
            //static para poderla usar. se usa cuando dentro de toda la aplicacion solo abra una como esa 

        {
            try//PAR AQUE NO SE PARE EL PROGRAMa
            {
                alumno.Nombre = "jose"; //debe de ser static Alumno,alumno para que no marque error 
                Console.WriteLine("nombre " + alumno.Nombre);
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);//viene el mensaje de la escepcion
            }
            
            //Alumno alumno = new Alumno(); de forma manual en vez de hacerlo con el null
            //alumno.Nombre = "jose"; //debe de ser static Alumno,alumno para que no marque error 
            //Console.WriteLine("nombre "  + alumno.Nombre);
            
        }
    }
}
