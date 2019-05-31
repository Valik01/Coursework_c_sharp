using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework_c_sharp
{
   class CardFile
   {
      public string namebk;
      public string author;
      public uint yearpublish;
      public string publishhous;
      public uint price;
      public string state;
      public DateTime date;

      public CardFile( string namebk, string author, uint yearpublish, string publishhous, uint price, string state, DateTime date)
      {
         this.namebk = namebk;
         this.author = author;
         this.yearpublish = yearpublish;
         this.publishhous = publishhous;
         this.price = price;
         this.state = state;
         this.date = date;
      }

      public string Namebk { get => namebk; set => namebk = value; }
      public string Author { get => author; set => author = value; }
      public uint Yearpublish { get => yearpublish; set => yearpublish = value; }
      public string Publishhous { get => publishhous; set => publishhous = value; }
      public uint Price { get => price; set => price = value; }
      public string State { get => state; set => state = value; }
      public DateTime Date { get => date; set => date = value; }
   }
}
