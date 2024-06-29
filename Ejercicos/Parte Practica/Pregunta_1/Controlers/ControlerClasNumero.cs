using Pregunta_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_1.Controlers
{
    internal class ControlerClasNumero
    {
        List<ClaseNumero> numeros = new List<ClaseNumero>();

        // funcion para leer el numero 

        public string desglosarNumero(int numero, int val)
        {
            string? resul = "";
            if (val == 0)
            {
                switch (numero % 10)
                {
                    case 1: resul += "uno"; break;
                    case 2: resul += "dos"; break;
                    case 3: resul += "tres"; break;
                    case 4: resul += "cuatro"; break;
                    case 5: resul += "cinco"; break;
                    case 6: resul += "seis"; break;
                    case 7: resul += "siete"; break;
                    case 8: resul += "ocho"; break;
                    case 9: resul += "nueve"; break;

                }
            }
            else if (val == 1)
            {
                switch (numero % 10)
                {
                    case 1: resul += "veinti uno"; break;
                    case 2: resul += "veinti dos"; break;
                    case 3: resul += "veinti tres"; break;
                    case 4: resul += "veinti cuatro"; break;
                    case 5: resul += "veinti cico"; break;
                    case 6: resul += "veinti seis"; break;
                    case 7: resul += "veinti siete"; break;
                    case 8: resul += "veinti ocho"; break;
                    case 9: resul += "veinti nueve"; break;
                }
            }
            else if (val == 3)
            {
                switch (numero % 10)
                {
                    case 1: resul += "treinta uno"; break;
                    case 2: resul += "treinta dos"; break;
                    case 3: resul += "treinta tres"; break;
                    case 4: resul += "treinta cuatro"; break;
                    case 5: resul += "treinta cico"; break;
                    case 6: resul += "treinta seis"; break;
                    case 7: resul += "treinta siete"; break;
                    case 8: resul += "treinta ocho"; break;
                    case 9: resul += "treinta nueve"; break;
                }
            }
            else if (val == 2)
            {
                switch (numero % 10)
                {
                    case 1: resul += "once"; break;
                    case 2: resul += "doce"; break;
                    case 3: resul += "trece"; break;
                    case 4: resul += "catorce"; break;
                    case 5: resul += "quince"; break;
                    case 6: resul += "diesiceis"; break;
                    case 7: resul += "diecisite"; break;
                    case 8: resul += "dieciocho"; break;
                    case 9: resul += "diecinueve"; break;
                }
            }

            else if (val == 4)
            {
                switch (numero % 10)
                {
                    case 1: resul += "cuarenta uno"; break;
                    case 2: resul += "cuarenta dos"; break;
                    case 3: resul += "cuarenta tres"; break;
                    case 4: resul += "cuarenta cuatro"; break;
                    case 5: resul += "cuarenta cico"; break;
                    case 6: resul += "cuarenta seis"; break;
                    case 7: resul += "cuarenta siete"; break;
                    case 8: resul += "cuarenta ocho"; break;
                    case 9: resul += "cuarenta nueve"; break;
                }
            }
            else if (val == 5)
            {
                switch (numero % 10)
                {
                    case 1: resul += "cinquenta uno"; break;
                    case 2: resul += "cinquenta dos"; break;
                    case 3: resul += "cinquenta tres"; break;
                    case 4: resul += "cinquenta cuatro"; break;
                    case 5: resul += "cinquenta cico"; break;
                    case 6: resul += "cinquenta seis"; break;
                    case 7: resul += "cinquenta siete"; break;
                    case 8: resul += "cinquenta ocho"; break;
                    case 9: resul += "cinquenta nueve"; break;
                }
            }
            else if (val == 6)
            {
                switch (numero % 10)
                {
                    case 1: resul += "sesenta uno"; break;
                    case 2: resul += "sesenta dos"; break;
                    case 3: resul += "sesenta tres"; break;
                    case 4: resul += "sesenta cuatro"; break;
                    case 5: resul += "sesenta cico"; break;
                    case 6: resul += "sesenta seis"; break;
                    case 7: resul += "sesenta siete"; break;
                    case 8: resul += "sesenta ocho"; break;
                    case 9: resul += "sesenta nueve"; break;
                }
            }
            else if (val == 7)
            {
                switch (numero % 10)
                {
                    case 1: resul += "setenta uno"; break;
                    case 2: resul += "setenta dos"; break;
                    case 3: resul += "setenta tres"; break;
                    case 4: resul += "setenta cuatro"; break;
                    case 5: resul += "setenta cico"; break;
                    case 6: resul += "setenta seis"; break;
                    case 7: resul += "setenta siete"; break;
                    case 8: resul += "setenta ocho"; break;
                    case 9: resul += "setenta nueve"; break;
                }
            }
            else if (val == 8)
            {
                switch (numero % 10)
                {
                    case 1: resul += "ochenta uno"; break;
                    case 2: resul += "ochenta dos"; break;
                    case 3: resul += "ochenta tres"; break;
                    case 4: resul += "ochenta cuatro"; break;
                    case 5: resul += "ochenta cico"; break;
                    case 6: resul += "ochenta seis"; break;
                    case 7: resul += "ochenta siete"; break;
                    case 8: resul += "ochenta ocho"; break;
                    case 9: resul += "ochenta nueve"; break;
                }
            }

            else if (val == 9)
            {
                switch (numero % 10)
                {
                    case 1: resul += "noventa uno"; break;
                    case 2: resul += "noventa dos"; break;
                    case 3: resul += "noventa tres"; break;
                    case 4: resul += "noventa cuatro"; break;
                    case 5: resul += "noventa cico"; break;
                    case 6: resul += "noventa seis"; break;
                    case 7: resul += "noventa siete"; break;
                    case 8: resul += "noventa ocho"; break;
                    case 9: resul += "noventa nueve"; break;
                }
            }
            return resul;


        }

        public string Convertir_texto(int numero)
        {
            if (numero == 0)
            {
                return "cero";
            }
            else if (numero >= 1 && numero <= 10)
            {
                if (numero == 10)
                {
                    return "Diez";
                }
                else
                {
                    return desglosarNumero(numero, 0);
                }

            }
            else if (numero >= 21 && numero <= 30)
            {
                if (numero == 30)
                {
                    return "treinta";
                }
                else
                {
                    return desglosarNumero(numero, 1);
                }
            }
            else if (numero >= 31 && numero <= 40)
            {
                if (numero == 40)
                {
                    return "cuarenta";
                }
                else
                {
                    return desglosarNumero(numero, 3);
                }
            }
            else if (numero >= 41 && numero <= 50)
            {
                if (numero == 50)
                {
                    return "cinquenta";
                }
                else
                {
                    return desglosarNumero(numero, 4);
                }
            }
            else if (numero >= 51 && numero <= 60)
            {
                if (numero == 60)
                {
                    return "sesenta";
                }
                else
                {
                    return desglosarNumero(numero, 5);
                }
            }
            else if (numero >= 61 && numero <= 70)
            {
                if (numero == 70)
                {
                    return "setenta";
                }
                else
                {
                    return desglosarNumero(numero, 6);
                }
            }
            else if (numero >= 71 && numero <= 80)
            {
                if (numero == 80)
                {
                    return "ochenta";
                }
                else
                {
                    return desglosarNumero(numero, 7);
                }
            }
            else if (numero >= 81 && numero <= 90)
            {
                if (numero == 90)
                {
                    return "noventa";
                }
                else
                {
                    return desglosarNumero(numero, 8);
                }
            }
            else if (numero >= 11 && numero <= 20)
            {
                if (numero == 20)
                {
                    return "veinte";
                }
                else
                {
                    return desglosarNumero(numero, 2);
                }
            }

            else if (numero >= 91 && numero <= 100)
            {
                if (numero == 100)
                {
                    return "cien";
                }
                else
                {
                    return desglosarNumero(numero, 9);
                }
            }

            return "";
        }


        public void Leer_numeros()
        {
            numeros.Add(new ClaseNumero()
            {
                numero = 2,
                numTex = Convertir_texto(2)
            });
            numeros.Add(new ClaseNumero()
            {
                numero = 0,
                numTex = Convertir_texto(0)
            });
            numeros.Add(new ClaseNumero()
            {
                numero = 10,
                numTex = Convertir_texto(10)
            });
            numeros.Add(new ClaseNumero()
            {
                numero = 98,
                numTex = Convertir_texto(98)
            });
            numeros.Add(new ClaseNumero()
            {
                numero = 44,
                numTex = Convertir_texto(44)
            });
            numeros.Add(new ClaseNumero()
            {
                numero = 21,
                numTex = Convertir_texto(21)
            });
            numeros.Add(new ClaseNumero()
            {
                numero = 24,
                numTex = Convertir_texto(24)
            });
            numeros.Add(new ClaseNumero()
            {
                numero = 29,
                numTex = Convertir_texto(29)
            });
            numeros.Add(new ClaseNumero()
            {
                numero = 95,
                numTex = Convertir_texto(95)
            });
            numeros.Add(new ClaseNumero()
            {
                numero = 100,
                numTex = Convertir_texto(100)
            });
            numeros.Add(new ClaseNumero()
            {
                numero = 3,
                numTex = Convertir_texto(3)
            });
            numeros.Add(new ClaseNumero()
            {
                numero = 11,
                numTex = Convertir_texto(11)
            });
            numeros.Add(new ClaseNumero()
            {
                numero = 31,
                numTex = Convertir_texto(31)
            });
            numeros.Add(new ClaseNumero()
            {
                numero = 34,
                numTex = Convertir_texto(34)
            });
            numeros.Add(new ClaseNumero()
            {
                numero = 27,
                numTex = Convertir_texto(27)
            });
            numeros.Add(new ClaseNumero()
            {
                numero = 40,
                numTex = Convertir_texto(40)
            });
            numeros.Add(new ClaseNumero()
            {
                numero = 18,
                numTex = Convertir_texto(18)
            });
            

        }

        public void MostrarNumeos()
        {
            foreach (var item in numeros)
            {
                Console.WriteLine($"Numero: {item.numero} = {item.numTex}\n");
            }
        }


    }
}
