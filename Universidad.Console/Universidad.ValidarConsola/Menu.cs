﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Libreria.Helper
{
    public class Menu
    {

        List<string> opciones = new List<string>();
        private string titulo;

        public Menu(string titulo, string[] opciones)
        {  //Constructor
            this.titulo = titulo;
            this.opciones = opciones.ToList();
        }

        public string print()
        {
            string resultado = "";
            resultado += titulo + "\n";
            try
            {
                if (!isEmpty())
                {
                    for (int i = 0; i < opciones.Count; i++)
                    {
                        resultado += ("\t" + (i + 1) + ". " + opciones[i] + "\n");
                    }
                }
            }
            catch (Exception ave)
            {
                Console.WriteLine(ave.Message);
            }
            return resultado;
        }

        public int elegir()
        {
            try
            {
                int opcionElegida = Validador.pedirInt(print());
                string opcion = opciones[opcionElegida - 1]; //Esto me va a tirar el error 
                return opcionElegida - 1;
            }
            catch (IndexOutOfRangeException iore)
            {
                Console.WriteLine("No existe esa opcion");
            }
            return -1;
        }

        public bool isEmpty()
        {
            if (this.opciones.Count == 0)
            {
                throw new Exception("Menu sin opciones");
            }
            return !(this.opciones.Count > 0);
        }
    }
}
