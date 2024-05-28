using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classesMetodosPropriedaeds.models
{
    public class Carro
    {
        // get -> quando utilizamos o valor da variável e set -> quando atribuimos um valor a variavel

        private string _montadora;
        public string Montadora 
        { 
            get
            {
                return _montadora.ToUpper();
            }
            // ou podemos escrever o getter de forma simplificada: get => _nome.ToUpper(); pois temos somente uma linha no getter.
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _montadora = value;
            }	
        }
        public string Modelo { get; set;}
        public int Ano { get; set;}
        public double Valor { get; set;}

        public void ApresentarCarro()
        {
            Console.WriteLine($"O carro {Modelo}, do ano {Ano}, é da montadora {Montadora} e custa R${Valor}");
        }
    }
}