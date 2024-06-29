using Pregunta_3.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_3.Controlers
{
    internal class ControlersLista
    {
        List<Lista> lista = new List<Lista>();

        public void ordenar()
        {
            lista.Sort((i1, i2) => i1.CompareTo(i2));
        }

        public void mostrarlista()
        {
            foreach (var item in lista)
            {
                Console.WriteLine($" {item.numero} , ");
            }
        }

        public void leerDAtos()
        {
            lista.Add(new Lista()
            {
                numero = 28,
                mayor = 23,
                menor = 23, 
            });

            lista.Add(new Lista()
            {
                numero = 77,
                mayor = 23,
                menor = 23,
            });
            lista.Add(new Lista()
            {
                numero = 73,
                mayor = 23,
                menor = 23,
            });
            lista.Add(new Lista()
            {
                numero = 43,
                mayor = 23,
                menor = 23,
            });
            lista.Add(new Lista()
            {
                numero = 98,
                mayor = 23,
                menor = 23,
            });
            lista.Add(new Lista()
            {
                numero = 13,
                mayor = 23,
                menor = 23,
            });
            lista.Add(new Lista()
            {
                numero = 3,
                mayor = 23,
                menor = 23,
            });
        }

    }
}
