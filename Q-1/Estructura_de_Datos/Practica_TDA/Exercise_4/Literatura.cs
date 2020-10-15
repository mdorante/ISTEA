using System;

namespace Exercise_4
{
    public class Libro
    {
        public string nombre;
        public Autor autor;
        public float precio;
        public int paginas;

        public Libro(string nombre, Autor autor, float precio, int paginas)
        {
            this.nombre = nombre;
            this.autor = autor;
            this.precio = precio;
            this.paginas = paginas;
        }

        public void MostrarPortada()
        {
            int nameLength = this.nombre.Length;
            int authorNameLength = this.autor.nombre.Length;

            string longestAttribute;

            if (nameLength > authorNameLength)
            {
                longestAttribute = this.nombre;
            }
            else
            {
                longestAttribute = this.autor.nombre;
            }

            int longestAttributeLength = longestAttribute.Length;

            for (int j = 0; j <= 5; j++)
            {
                for (int i = 0; i < longestAttributeLength + 2; i++)
                {
                    if (j == 0 || j == 5 || i == 0 || i == longestAttributeLength + 1)
                    {
                        Console.Write('*');
                    }
                    else if (j == 1)
                    {
                        if (i < nameLength + 1)
                            Console.Write(this.nombre[i - 1]);
                        else
                            Console.Write(' ');
                    }
                    else if (j == 3)
                    {
                        if (i < authorNameLength + 1)
                            Console.Write(this.autor.nombre[i - 1]);
                        else
                            Console.Write(' ');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
    }

    public class Autor
    {
        public enum Genero
        {
            Masculino,
            Femenino
        }
        public string nombre;
        public string email;
        public int birthYear;
        public Genero genero;

        public Autor(string nombre, string email, int birth, Genero gender)
        {
            this.nombre = nombre;
            this.email = email;
            this.birthYear = birth;
            this.genero = gender;
        }

        public int ObtenerEdad()
        {
            return DateTime.Now.Year - this.birthYear;
        }
    }

    public class Pagina
    {
        public string titulo;
        public string[] cuerpo;
        public int numeroPagina;

        public Pagina(string titulo, string[] cuerpo, int numeroPagina)
        {
            this.titulo = titulo;
            this.cuerpo = cuerpo;
            this.numeroPagina = numeroPagina;
        }

        public Pagina(string[] cuerpo, int numeroPagina)
        {
            this.cuerpo = cuerpo;
            this.numeroPagina = numeroPagina;
        }

        public void ImprimirPagina()
        {
            int numLines = this.cuerpo.Length;
            int longestLine = 0;
            bool hasTitle = this.titulo != null;

            for (int i = 0; i < numLines; i++)
            {
                if (this.cuerpo[i].Length > longestLine)
                    longestLine = this.cuerpo[i].Length;
            }

            if (hasTitle && this.titulo.Length > longestLine)
                longestLine = this.titulo.Length;

            for (int i = 0; i < numLines + 2; i++)
            {
                for (int j = 0; j < longestLine + 2; j++)
                {
                    if (i == 0 || i == numLines + 1 || j == 0 || j == longestLine + 1)
                    {
                        Console.Write('*');
                    }
                    else if (hasTitle && i == 1)
                    {
                        if (j < longestLine + 1)
                            Console.Write(this.titulo[j - 1]);
                        else
                            Console.Write(' ');
                    }
                    else if (i == 3)
                    {
                        for (int k = 0; k < cuerpo.Length; k++)
                        {
                            for (int l = 0; l < cuerpo[k].Length; l++)
                            {
                                Console.Write(cuerpo[k][l]);
                            }
                            Console.WriteLine();
                        }
                    }
                    // else if (i == numLines)
                    // {
                    //     Console.Write(this.numeroPagina);
                    // }
                    else
                    {
                        Console.Write(' ');
                    }
                }
            }
        }
    }
}