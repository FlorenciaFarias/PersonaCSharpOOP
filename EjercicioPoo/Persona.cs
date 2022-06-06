using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPoo
{
     class Persona
    {
        protected string nombre;
        protected int edad;
        protected string dni;


        //Constructor
        public Persona(string nombre, int edad, string dni)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;

        }
        //Metodos

        public  virtual void Mostrar()
        {
            Console.WriteLine(this.nombre);
            Console.WriteLine(this.edad);
            Console.WriteLine(this.dni);
            

        }
        public bool EsMayorDeEdad()
        {
            int mayoriaDeEdadMenor = 18;
            bool esMayor = false;
            if(this.edad >= mayoriaDeEdadMenor)
            {
                return esMayor = true;
            }
            else
            {
                return esMayor;
            }
           
        }
        
        public int JovenMenorA25()
        {
            return this.edad;
        }

    }
}
