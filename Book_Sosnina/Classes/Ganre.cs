using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Sosnina.Classes
{
    public class Ganre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Ganre(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public static List<Ganre> AllGanres()
        {
            List<Ganre> allGenres = new List<Ganre>();

            allGenres.Add(new Ganre(1, "Современная русская литература"));
            allGenres.Add(new Ganre(2, "Современные детективы"));
            allGenres.Add(new Ganre(3, "Любовное фэнтази"));
            allGenres.Add(new Ganre(4, "Попаданцы"));
            allGenres.Add(new Ganre(5, "Юмористическое фэнтази"));


            return allGenres;
        }
    }
}
