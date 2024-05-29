// prática de criacao de classes e aprofundamento em propriedades, metodos e construtores


using System.Globalization;
using classesMetodosPropriedaeds.models;


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

// utilizando valores monetarios 
decimal ValorMonetarioUSD = 1450.50M;
Console.WriteLine($"{ValorMonetarioUSD:C}"); // note que quando nao definimos a Cultura/localizacao, é automaticamente assumido a cultura cadastrada no PC, neste caso em USD

// Para mudar dentro do próprio código a cultura utilize:
CultureInfo.DefaultThreadCurrentCulture= new CultureInfo("pt-BR");
decimal ValorMonetarioBRL = 1450.50M;
Console.WriteLine($"{ValorMonetarioBRL:C}");
// este é um exemplo de alteracao dentro do próprio código, porém é possível alterar a cultura em si



