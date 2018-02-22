using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics.MyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objeto instanciado de clase Animal
            Animal miAnimal = new Animal();
            //Asignación de valores en cada propiedad
            miAnimal.Nombre = "animal";
            miAnimal.Color = "amarillo";
            miAnimal.TamanoEnCentimetros = 100;




            //Objeto instanciado de clase Mamifero, que hereda de clase Animal
            Mamifero miMamifero = new Mamifero();

            //propiedades heredadas de Animal
            miMamifero.Nombre = "un mamifero";
            miMamifero.Color = "Cafe"; 
            miMamifero.TamanoEnCentimetros = 120;
            miMamifero.Habitat = "Cualquier habitat para el mamífero";



            Tigre miTigre = new Tigre();
            miTigre.Nombre = "Tigre de Bengala"; 
            miTigre.Color = "Blanco"; //Mi tigre es albino, sobre escribe el comportamiento definido en el construtor de tigre           
            miTigre.TamanoEnCentimetros = 300;
            miTigre.Habitat = "Jungla de Asia";
           
            //Comportamientos de todos los animales en el tigre
            miTigre.Nace();
            miTigre.Crece();
            miTigre.Reproduce();
            miTigre.Muere();
            //Comportamientos de todos los mamiferos en el tigre
            miTigre.Amamanta();

            //Comportamiento particular en el tigre
            miTigre.Caza();




            //Un caballo es un Animal Mamífero
            Caballo miCaballo = new Caballo();
            miCaballo.Nombre = "Caballo Español";
            miCaballo.Color = "rojo";
            miCaballo.TamanoEnCentimetros = 200;
            miCaballo.Habitat = "Pastizales de América";

            miCaballo.Nace();
            miCaballo.Crece();
            miCaballo.Reproduce();
            miCaballo.Muere();

            miCaballo.Amamanta();
            miCaballo.Relincha();




            //Pausa en la consola para ver el resultado
            Console.Read();
        }
    }

    public class Animal
    {
        #region Propiedades
        public string Nombre { get; set; }
        public int TamanoEnCentimetros { get; set; }
        public string Color { get; set; }
        
        #endregion

        #region Metodos
        public void Nace()
        {
            Console.WriteLine("Un animal ha nacido");
        }
        public void Crece()
        {
            Console.WriteLine("Un animal ha crecido");
        }
        public void Reproduce()
        {
            Console.WriteLine("Un animal se ha reproducido");
        }
        public void Muere()
        {
            Console.Write("Un animal ha muerto");
        }
        #endregion
    }
    public class Mamifero : Animal
    {
        public string Habitat { get; set; }
        public Mamifero ()
        {
        }
        public void Amamanta()
        {
            Console.WriteLine("Un Mamiferos ha amanatado");
        }

    }
    public class Tigre : Mamifero
    {      
        public int TamanoManada { get; set; }
        //Constructor generaliza el color de todos los tigres
        public Tigre()
        {
            //Propiedad color, hereda de animal
            Color = "amarillo y negro";
        }

        //Método/actividad particular de los tigres
        public void Caza()
        {
            Console.WriteLine("Un Tigre caza su presa");
        }
    }
    public class Caballo : Mamifero
    {
        public int TamanoRebano { get; set; }
        
        public Caballo()
        {
        }

        //Método/actividad particular de los caballos
        public void Relincha()
        {
            Console.WriteLine("Un caballo pastando");
        }
    }
}
