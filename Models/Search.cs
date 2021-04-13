using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
namespace MovieApp.Models
{
    public class Search {
        public int SearchId { get;set; }
        public int page { get; set; } 
        public List<Result> results { get; set; } 
        public int total_pages { get; set; } 
        public int total_results { get; set; } 
        public int search_title { get; set; } 
    }
    
}
