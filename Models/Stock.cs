using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace my_api.Models
{
    public class Stock
    {
        public int Id {get; set;}
        public string Symbol {get; set;} = string.Empty;
        public string CompanyName {get; set;} = string.Empty;
        [Column (TypeName ="decimal(18,2)")]
        public decimal Purshase {get; set;}
        [Column (TypeName ="decimal(18,2)")]
        public decimal LastDiv {get; set;}
        public string Industry  {get; set;}=string.Empty;
        public long MarketCap {get; set;}
        //relation one to many
        //proprité de navigation pour la relation One-To-Many
        public List<Comments> Comments {get; set;} = new List<Comments>();

    }
}