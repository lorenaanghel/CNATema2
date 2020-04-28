using System;

namespace Model
{
    public class Zodie
    {
        public string Sign { get; set; }
        public DateTime Date1 { get; set; }
        public DateTime Date2 { get; set; }

        public Zodie()
        {
        
        }
        Zodie(string Sign, DateTime date1, DateTime date2)
        {
            this.Sign = Sign;
            this.Date1 = date1;
            this.Date2 = date2;
        }

        public void ChangeYear(DateTime dt)
        {
            Date1 = Date1.AddYears(dt.Year - Date1.Year);
            Date2 = Date2.AddYears(dt.Year - Date2.Year);
        }
    }
}
