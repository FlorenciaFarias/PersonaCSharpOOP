using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPoo
{
    class CuentaJoven : Cuentas 
    {
        
        private float bonificacion;

        //CONSTRUCTOR

        public CuentaJoven(Persona titular, float cantidadDeDinero) : base ( titular, cantidadDeDinero)
        {
            this.bonificacion = 5;
        }
        public bool EsTitularValido()
        {
            int menor = 25;
            bool esMayor = false;

            if (titular.EsMayorDeEdad() && (titular.JovenMenorA25() <= menor))
            {
                esMayor = true;
            }
            return esMayor;
        }

        public override float Retirar(float retirarDinero)
        {
            float resultado;
            if (this.EsTitularValido())
            {
              resultado =  base.Retirar(retirarDinero);
               
            }
            return this.cantidadDeDinero;
           
        }
         
    }
}
