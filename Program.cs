using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphone = new Iphone("32995653228","10SE","K156423AFRA23", 128);
Nokia nokia = new Nokia("3288526491", "5", "ADVG35VA694INFRA156", 32);

Console.WriteLine("Qual aparelho deseja consultar?");
Console.WriteLine("Digite 1 para Iphone ou 2 para Nokia");
string aparelho = Console.ReadLine();

if (!string.IsNullOrEmpty(aparelho))
{
    if (aparelho == "1")
    {
        Console.WriteLine("O telefone pra contato eh: " + iphone.Numero);
    }
    else if(aparelho == "2")
    {
        Console.WriteLine("O telefone pra contato eh: " + nokia.Numero);
    }
    else
    {
        Console.WriteLine("Opção invalida");
    }
}

iphone.InstalarAplicativo("Netflix");
Console.WriteLine();
nokia.InstalarAplicativo("HBO ");

Console.WriteLine();
Console.WriteLine("Digite o novo numero de telefone? ");
nokia.Numero = Console.ReadLine();
Console.WriteLine("O novo numero eh: ",nokia.Numero);

Console.WriteLine("Ligando para o novo numero ");

iphone.Ligar(nokia.Numero);

nokia.ReceberLigacao();