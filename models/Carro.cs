using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classesMetodosPropriedaeds.models
{
    public class Carro
    {
        public string Montadora { get; set;}
        public string Modelo { get; set;}
        public int Ano { get; set;}
        public string Valor { get; set;}

        public void ApresentarCarro()
        {
            Console.WriteLine($"");
        }
}