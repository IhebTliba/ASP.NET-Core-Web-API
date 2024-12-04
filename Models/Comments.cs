using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_api.Models
{
    public class Comments
    {
         public int Id {get; set;}
        public string Title {get; set;} = string.Empty;
        public string Content {get; set;} = string.Empty;
        public DateTime CreatedOn {get; set;}=DateTime.Now;
        //relation one to many
        public int? StockId {get; set;} //FK qui lie un comment à un stock spécifique
        public Stock? Stock {get; set;} //propriété de navigation

        
    }
}