﻿using Pregunta_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_4.Controlers
{
    internal class ControlersPcNueva : Pc
    {
        List<PcNueva> pcs = new List<PcNueva>();
        public void gurdarDatos()
        {
            pcs.Add(new PcNueva()
            {
                Ram = 64,
                Pantalla = 72.98,
                Marca = "Asus",
                Modelo = "Gaming",
                TipoSistema = "Intel",
                Almacenamiento = 1,
                FechaIngreso = Convert.ToDateTime("07/12/23"),
                Precio = 23400

            }) ;
            pcs.Add(new PcNueva()
            {
                Ram = 12,
                Pantalla = 64.98,
                Marca = "Asus",
                Modelo = "Gaming",
                TipoSistema = "Raizer",
                Almacenamiento = 500,
                FechaIngreso = Convert.ToDateTime("07/12/23"),
                Precio = 23400
            });
            pcs.Add(new PcNueva()
            {
                Ram = 4,
                Pantalla = 12.98,
                Marca = "Samsung",
                Modelo = "Gaming",
                TipoSistema = "Intel",
                Almacenamiento = 200,
                FechaIngreso = Convert.ToDateTime("07/12/23"),
                Precio = 23400
            });

            pcs.Add(new PcNueva()
            {
                Ram = 12,
                Pantalla = 32.98,
                Marca = "Grande",
                Modelo = "Gaming",
                TipoSistema = "Intel",
                Almacenamiento = 200,
                FechaIngreso = Convert.ToDateTime("07/12/23"),
                Precio = 23400
            });

            pcs.Add(new PcNueva()
            {
                Ram = 32,
                Pantalla = 32.98,
                Marca = "Asus",
                Modelo = "Gaming",
                TipoSistema = "Intel",
                Almacenamiento = 1,
                FechaIngreso = Convert.ToDateTime("07/12/23"),
                Precio = 23400
            });

            pcs.Add(new PcNueva()
            {
                Ram = 32,
                Pantalla = 32.98,
                Marca = "Asus",
                Modelo = "Gaming",
                TipoSistema = "Intel",
                Almacenamiento = 1,
                FechaIngreso = Convert.ToDateTime("07/12/23"),
                Precio = 23400
            });

            pcs.Add(new PcNueva()
            {
                Ram = 32,
                Pantalla = 32.98,
                Marca = "Asus",
                Modelo = "Gaming",
                TipoSistema = "Intel",
                Almacenamiento = 1,
                FechaIngreso = Convert.ToDateTime("07/12/23"),
                Precio = 23400
            });

            pcs.Add(new PcNueva()
            {
                Ram = 32,
                Pantalla = 32.98,
                Marca = "Asus",
                Modelo = "Gaming",
                TipoSistema = "Intel",
                Almacenamiento = 1,
                FechaIngreso = Convert.ToDateTime("07/12/23"),
                Precio = 23400
            });

            pcs.Add(new PcNueva()
            {
                Ram = 32,
                Pantalla = 32.98,
                Marca = "Asus",
                Modelo = "Gaming",
                TipoSistema = "Intel",
                Almacenamiento = 1,
                FechaIngreso = Convert.ToDateTime("07/12/23"),
                Precio = 23400
            });

            pcs.Add(new PcNueva()
            {
                Ram = 32,
                Pantalla = 32.98,
                Marca = "Asus",
                Modelo = "Gaming",
                TipoSistema = "Intel",
                Almacenamiento = 1,
                FechaIngreso = Convert.ToDateTime("07/12/23"),
                Precio = 23400
            });
        }

        public void Mostrar()
        {
            Console.WriteLine(" __________________________________________________________________________________");
            Pc pc = new Pc();
            foreach (var item in pcs)
            {
                item.Mostrar();
                Console.WriteLine($"Fecha: {item.FechaIngreso} \n Precio: {item.Precio}\ns");
                Console.WriteLine(" ____________________________________________________________________________________________");
            }
        }
    }
}