using System;
using System.Collections.Generic;

namespace EjercicioPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona personita = new Persona("Juan", 18, "1111222");
             
           

            CuentaJoven joven = new CuentaJoven(personita, 3000);

            Console.WriteLine(joven.Retirar(1000));

        }
        
    }
}
