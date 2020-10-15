using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Autor author = new Autor("J.K Rowling", "jkrowling@potterverse.com", 1965, Autor.Genero.Femenino);
            Libro book = new Libro("Harry Potter and the Chamber of Secrets", author, 59.99f, 300);

            string[] chapterTwoPage = {
                "Hello",
                "This is chapter two",
                "The end."
                };
            Pagina page = new Pagina("Chapter 2", chapterTwoPage, 87);

            book.MostrarPortada();
        }
    }
}
