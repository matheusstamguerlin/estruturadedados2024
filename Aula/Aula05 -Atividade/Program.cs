using System;
using System.Collections.Generic;

class Livro
{
    public string Nome { get; set; }
    public string Editora { get; set; }
    public string Autor { get; set; }
    public int NumeroDePaginas { get; set; }

    public Livro(string nome, string editora, string autor, int numeroDePaginas)
    {
        Nome = nome;
        Editora = editora;
        Autor = autor;
        NumeroDePaginas = numeroDePaginas;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Editora: {Editora}, Autor: {Autor}, Páginas: {NumeroDePaginas}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Livro> livros = new List<Livro>
        {
            new Livro("O Código Da Vinci", "Editora Planeta", "Dan Brown", 592),
            new Livro("A Arte da Guerra", "Editora BestSeller", "Sun Tzu", 240),
            new Livro("Sapiens: Uma Breve História da Humanidade", "Editora L&PM", "Yuval Noah Harari", 464),
            new Livro("1984", "Companhia das Letras", "George Orwell", 368),
            new Livro("O Pequeno Príncipe", "Editora Salamandra", "Antoine de Saint-Exupéry", 96)
        };

        Livro? livroComMaisPaginas = null;
        int maxPaginas = 0;

        foreach (var livro in livros)
        {
            if (livro.NumeroDePaginas > maxPaginas)
            {
                maxPaginas = livro.NumeroDePaginas;
                livroComMaisPaginas = livro;
            }
        }

        Console.WriteLine("Livro com o maior número de páginas:");
        Console.WriteLine(livroComMaisPaginas);
    }
}