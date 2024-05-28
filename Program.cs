// prática de criacao de classes e aprofundamento em propriedades, metodos e construtores


using classesMetodosPropriedaeds.models;


// // Classe carro teste com get set e utilizacao das propriedades em um metodo
// Carro novoCarro = new Carro();
// novoCarro.Montadora = "GM";
// novoCarro.Modelo = "Corsa";
// novoCarro.Ano = 2010;
// novoCarro.Valor = 22500;
// novoCarro.ApresentarCarro();


// // Classe Calculadora, teste de métodos com parametros
// Calculadora novaCalc = new Calculadora();
// novaCalc.Somar(5, 2);
// novaCalc.Subtrair(5, 2);
// novaCalc.Multiplicar(5, 2);
// novaCalc.Dividir(5, 2);
// novaCalc.Potencia(5, 2);
// novaCalc.RaizQuadrada(5);

// Classe pessoa com getter e setter flexíveis:
// Pessoa novaPessoa = new Pessoa();
// novaPessoa.Nome = "Gabriel";
// novaPessoa.Sobrenome = "Teixeira";
// // novaPessoa.Idade = 26;
// // novaPessoa.Apresentar();

// Pessoa novaPessoa2 = new Pessoa();
// novaPessoa2.Nome = "Andressa";
// novaPessoa2.Sobrenome = "Souza";

// podemos instanciar utilizando construtores, reduzindo o número de linhas necessárias em nosso código principal, mantendo o código conciso e direto
Pessoa p1 = new Pessoa("Gabriel", "Teixeira");
Pessoa p2 = new Pessoa("Andressa", "Souza");

// Classe curso
Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

// Adicionando pessoas na lista de Alunos do curso
cursoDeIngles.AdicionaAluno(p1);
cursoDeIngles.AdicionaAluno(p2);
cursoDeIngles.ListarAlunosMatriculados();


