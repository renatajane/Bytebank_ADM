

using Bytebank_ADM.Funcionários;
using Bytebank_ADM.Parceria;
using Bytebank_ADM.SistemaInterno;
using Bytebank_ADM.Utilitario;

#region
//Funcionario pedro = new Funcionario("123456789", 2000);
//pedro.Nome = "Pedro Malazartes";
//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());

//Diretor roberta = new Diretor("987654321");
//roberta.Nome = "Roberta Silva";
//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacoes);
//Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine ("O novo salário de Pedro é:" + pedro.Salario);
//Console.WriteLine ("O novo salário de Roberta é:" + roberta.Salario); 
#endregion

//CalcularBonificacao();
UsarSistema();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer Ulisses = new Designer("123456");
    Ulisses.Nome = "Ulisses Souza";

    Diretor Paula = new Diretor("34567");
    Paula.Nome = "Paola Souza";

    Auxiliar Igor = new Auxiliar("12344");
    Igor.Nome = "Igor Dias";

    GerenteDeCompras Camila = new GerenteDeCompras("3647484");
    Camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(Ulisses);
    gerenciador.Registrar(Paula);
    gerenciador.Registrar(Igor);
    gerenciador.Registrar(Camila);

    Console.WriteLine("Total de bonificação = " +gerenciador.TotalDeBonificacoes);

}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("348785");
    ingrid.Nome = "Ingrid Dias";
    ingrid.Senha = "123";
 
    GerenteDeCompras paulo = new GerenteDeCompras("48948");
    paulo.Nome = "Paulo Augusto";
    paulo.Senha = "321";

    sistema.Logar(ingrid, "123");
    sistema.Logar(paulo, "321");

    ParceiroComercial caio = new ParceiroComercial();
    caio.Senha = "234";

    sistema.Logar(caio, "239");



    //bool a = sistema.Logar(Ingrid, "173");
    //if (a == true) //é o mesmo que if (a){...
    //{
    //    Console.WriteLine("Está logado");
    //}
    //else
    //{
    //    Console.WriteLine("Você não está logado.");
    //}



}
