using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
        
        //<--- inicio ( Nome e Sobrenome)--->//
        Console.Write("Digite Seu Nome:");
        string nome = Console.ReadLine();
        Console.Write("Digite seu Sobrenome:");
        string sobrenome = Console.ReadLine();
        Console.Write("\n");
        //<--- fim (Nome e Sobrenome )--->//

        //<--- inicio (nome sobrnome)--->//
        Console.Write("nome completo: {nome} {sobrenome}");
        Console.Write("\n");
        //<---fim (nome)--->//

        //<---inicio (nome catálago)--->//
        Console.WriteLine("nome catálago {sobrenome . ToUpper ()} , {nome}");
        Console.Write("\n");
        //<---fim (nome catálgo)--->//

        //<---(para sair)--->//
        Console.WriteLine("clik a técla ENTER para sair");
        Console.ReadKey();
        //<---fim --->//
}
  
    } 

} 
        

        



