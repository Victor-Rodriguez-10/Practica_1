using Pregunta_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pregunta_4.Controlers
{
    internal class ControlersPc
    {
        List<Pc> pcs = new List<Pc>();

        public void gurdarDatos()
        {
            pcs.Add(new Pc()
            {
                Ram = 64,
                Pantalla = 72.98,
                Marca = "Asus",
                Modelo = "Gaming",
                TipoSistema = "Intel",
                Almacenamiento = 1
            });
            pcs.Add(new Pc()
            {
                Ram = 12,
                Pantalla = 64.98,
                Marca = "Asus",
                Modelo = "Gaming",
                TipoSistema = "Raizer",
                Almacenamiento = 500
            });
            pcs.Add(new Pc()
            {
                Ram = 4,
                Pantalla = 12.98,
                Marca = "Samsung",
                Modelo = "Gaming",
                TipoSistema = "Intel",
                Almacenamiento = 200
            });

            pcs.Add(new Pc()
            {
                Ram = 12,
                Pantalla = 32.98,
                Marca = "Grande",
                Modelo = "Gaming",
                TipoSistema = "Intel",
                Almacenamiento = 200
            });

            pcs.Add(new Pc()
            {
                Ram = 32,
                Pantalla = 32.98,
                Marca = "Asus",
                Modelo = "Gaming",
                TipoSistema = "Intel",
                Almacenamiento = 1
            });

            pcs.Add(new Pc()
            {
                Ram = 32,
                Pantalla = 32.98,
                Marca = "Asus",
                Modelo = "Gaming",
                TipoSistema = "Intel",
                Almacenamiento = 1
            });

            pcs.Add(new Pc()
            {
                Ram = 32,
                Pantalla = 32.98,
                Marca = "Asus",
                Modelo = "Gaming",
                TipoSistema = "Intel",
                Almacenamiento = 1
            });

            pcs.Add(new Pc()
            {
                Ram = 32,
                Pantalla = 32.98,
                Marca = "Asus",
                Modelo = "Gaming",
                TipoSistema = "Intel",
                Almacenamiento = 1
            });

            pcs.Add(new Pc()
            {
                Ram = 32,
                Pantalla = 32.98,
                Marca = "Asus",
                Modelo = "Gaming",
                TipoSistema = "Intel",
                Almacenamiento = 1
            });

            pcs.Add(new Pc()
            {
                Ram = 32,
                Pantalla = 32.98,
                Marca = "Asus",
                Modelo = "Gaming",
                TipoSistema = "Intel",
                Almacenamiento = 1
            });
        }
        public virtual void Mostrar()
        {
            foreach (var item in pcs)
            {
                Console.WriteLine($" Ram: {item.Ram},\n Pantalla: {item.Pantalla},\n Marca: {item.Marca},\n Modelo: {item.Modelo},\n Tipo de Sistema: {item.TipoSistema}, \n Almacenamiento: {item.Almacenamiento}\n ");
            }
        }
    }

  
}
