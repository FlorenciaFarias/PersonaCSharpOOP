using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPoo
{
    abstract class Cuentas 
        
    {
        protected Persona titular;
        protected float cantidadDeDinero;
       

        //Constructor
        public Cuentas(Persona titular,float cantidadDeDinero)
        {
            this.titular = titular;
            this.cantidadDeDinero= cantidadDeDinero;
        }

        public float Mostrar()
        {
             
             return this.cantidadDeDinero;
        }

        public float Ingresar(float cantidad)
        {

            if(cantidad > 0)
            {
                this.cantidadDeDinero += cantidad; 
            }
            else
            {
                Console.WriteLine("...");
            }
            return this.cantidadDeDinero;
        }

        public virtual float Retirar(float retirarDinero)
        {
           
            if(retirarDinero <= this.cantidadDeDinero)
            {
               this.cantidadDeDinero -= retirarDinero;
                Console.Write("El dinero fue extraido con éxito. Tu saldo disponible es: $");
            }
            return this.cantidadDeDinero;
        }

    }
}
