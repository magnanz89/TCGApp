using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCGApp.Application.Models
{
    public class Card
    {
        public int Id { get; set; }
        
        public string CardReferenceString { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
