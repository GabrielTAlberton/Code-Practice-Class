// prática de criacao de classes e aprofundamento em propriedades, metodos e construtores


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



