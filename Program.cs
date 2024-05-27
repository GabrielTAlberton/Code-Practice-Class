// prática de criacao de classes e aprofundamento em propriedades, metodos e construtores


using classesMetodosPropriedaeds.models;


// Classe carro teste com get set e utilizacao das propriedades em um metodo
Carro novoCarro = new Carro();
novoCarro.Montadora = "GM";
novoCarro.Modelo = "Corsa";
novoCarro.Ano = 2010;
novoCarro.Valor = 22500;
novoCarro.ApresentarCarro();


// Classe Calculadora, teste de métodos com parametros

Calculadora novaCalc = new Calculadora();
novaCalc.Somar(5, 2);
novaCalc.Subtrair(5, 2);
novaCalc.Multiplicar(5, 2);
novaCalc.Dividir(5, 2);
novaCalc.Potencia(5, 2);
novaCalc.RaizQuadrada(5);