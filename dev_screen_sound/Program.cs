string mensagemDeBoasVindas = "@\r\n░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░\r\n██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗\r\n╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║\r\n░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║\r\n██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝\r\n╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░";

void ExibirMensagemdeBoasVindas()
{
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesdoMenu() 
{ 
    Console.WriteLine("\nDigite 1 para registrar uma banda"); 
    Console.WriteLine("Digite 2 para mostrar todas as bandas"); 
    Console.WriteLine("Digite 3 para avaliar uma banda"); 
    Console.WriteLine("Digite 4 para exibir a media de uma banda"); 
    Console.WriteLine("Digite 0 para sair");
    Console.WriteLine("\nDigite sua opção: ");
    
    int opcaoEscolhida = Console.Read()!;
    
    if(opcaoEscolhida == 1)
    {
        Console.WriteLine("Voce digitou a opçao " + opcaoEscolhida);
    }
}

ExibirMensagemdeBoasVindas();
ExibirOpcoesdoMenu();