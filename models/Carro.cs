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
        public double Valor { get; set;}

        public void ApresentarCarro()
        {
            Console.WriteLine($"O carro {Modelo}, do ano {Ano}, é da montadora {Montadora} e custa R${Valor}");
        }
    }
}