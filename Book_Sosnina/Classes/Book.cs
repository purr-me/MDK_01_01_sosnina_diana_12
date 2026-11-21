using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Sosnina.Classes
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Ganre> Ganres { get; set; }
        public List<Author> Authors { get; set; }
        public int Year { get; set; }

        public Book(int Id, string Name, List<Ganre> Ganres, List<Author> Authors, int Year)
        {
            this.Id = Id;
            this.Name = Name;
            this.Ganres = Ganres;
            this.Authors = Authors;
            this.Year = Year;
        }

        public static List<Book> AllBook()
        {
            List<Book> allBook = new List<Book>();

            allBook.Add(new Book(
                1, "Путешествие в Элевсин",
                Ganre.AllGanres().FindAll(x => x.Id == 1),
                Author.AllAuthors().FindAll(x => x.Id == 1),
                2023));
            allBook.Add(new Book(
                2, "Чапаев и Пустота",
                Ganre.AllGanres().FindAll(x => x.Id == 1),
                Author.AllAuthors().FindAll(x => x.Id == 1),
                2008));
            allBook.Add(new Book(
                3, "Дебютная постановка. Том 1.",
                Ganre.AllGanres().FindAll(x => x.Id == 2),
                Author.AllAuthors().FindAll(x => x.Id == 2),
                2023));
            allBook.Add(new Book(
                4, "Дебютная постановка. Том 2.",
                Ganre.AllGanres().FindAll(x => x.Id == 2),
                Author.AllAuthors().FindAll(x => x.Id == 2),
                2023));
            allBook.Add(new Book(
                5, "Охота на попаданку. Бракованная жена",
                Ganre.AllGanres().FindAll(x => x.Id == 2 || x.Id == 3 || x.Id == 4),
                Author.AllAuthors().FindAll(x => x.Id == 3),
                2022));

            return allBook;
        }

        public string ToGanres()
        {
            string toGenres = "";

            for (int iGenres = 0; iGenres < Ganres.Count; iGenres++)
            {
                toGenres += Ganres[iGenres].Name;
                if (iGenres < Ganres.Count - 1)
                    toGenres += ", ";
            }
            return toGenres;
        }
        public string ToAuthors()
        {
            string toAuthors = "";

            for (int iAuthors = 0; iAuthors < Authors.Count; iAuthors++)
            {
                toAuthors += Authors[iAuthors].FIO;
                if (iAuthors < Ganres.Count - 1)
                    toAuthors += ", ";
            }
            return toAuthors;
        }
    }
}
