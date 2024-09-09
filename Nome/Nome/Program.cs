using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Kauã Cordeiro Durães de Lima - 12311ECP017

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite o nome completo: ");
        string nomeCompleto = Console.ReadLine();

        NomeProprio nome = new NomeProprio(nomeCompleto);

        nome.ImprimeNomePaper();

        Console.ReadLine();
    }
}
