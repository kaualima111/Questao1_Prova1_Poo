using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NomeProprio
{
    private string nome_completo;
    private string nome_paper;

    public NomeProprio(string nomeCompleto)
    {
        nome_completo = nomeCompleto;
        nome_paper = GerarNomePaper(nome_completo);
    }

    private string GerarNomePaper(string nomeCompleto)
    {
        string[] partes = nomeCompleto.Split(' ');

        if (partes.Length == 0)
        {
            return "";
        }

        string sobrenome = partes[partes.Length - 1];

        string primeiroNome = partes.Length > 1 ? partes[0] : "";

        string inicialNomeDoMeio = partes.Length > 2 ? partes[1][0] + "." : "";

        if (!string.IsNullOrEmpty(inicialNomeDoMeio))
        {
            return $"{sobrenome}, {primeiroNome} {inicialNomeDoMeio}";
        }
        else
        {
            return $"{sobrenome}, {primeiroNome}";
        }
    }

    public void ImprimeNomePaper()
    {
        Console.WriteLine(nome_paper);
    }
}