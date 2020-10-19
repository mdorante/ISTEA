using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Pagina[] pages = new Pagina[100];
            string[] page87 = {
                "Hello",
                "This is chapter two",
                "The end."
                };

            Pagina page = new Pagina("Chapter 2", page87, 87);
            pages[88] = page;

            Autor author = new Autor("J.K Rowling", "jkrowling@potterverse.com", 1965, Autor.Genero.Femenino);
            Libro book = new Libro("Harry Potter and the Chamber of Secrets", author, 59.99f, pages);


            book.MostrarPortada();
            
            Console.WriteLine();
            
            book.ObtenerPagina(87);
        }
    }
}
