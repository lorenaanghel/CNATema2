using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.IO;
using System.Globalization;

namespace Server
{
    public class Repo
    {
        private List<Zodie> ListaZodii;

        public List<Zodie> GetAll()
        {
            return ListaZodii;
        }
        public Repo()
        {
            ListaZodii = new List<Zodie>();
            string[] words;
            var fileStream = new FileStream(@"E:\FacultateAn2Sem2\CNA\HoroscopTema2\Server\zodiac.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                words = streamReader.ReadToEnd().Split(' ');
            }

            CultureInfo provider = CultureInfo.InvariantCulture;

            for (int i = 0; i < words.Length; i = i + 3)
            {
                Zodie element = new Zodie();
                element.Date1 = DateTime.ParseExact(words[i], "MM/dd/yyyy", null);
                element.Date2 = DateTime.ParseExact(words[i + 1], "MM/dd/yyyy", null);
                element.Sign = words[i + 2];

                ListaZodii.Add(element);

            }
        }
    }
}
