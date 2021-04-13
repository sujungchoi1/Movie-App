using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
namespace MovieApp.Models
{
    public class MovieGenre    {
        public int id { get; set; } 
        public string name { get; set; } 
    }

    public class Root    {
        public bool adult { get; set; } 
        public string backdrop_path { get; set; } 
        public object belongs_to_collection { get; set; } 
        public int budget { get; set; } 
        public List<Genre> genres { get; set; } 
        public string homepage { get; set; } 
        public int id { get; set; } 
        public string imdb_id { get; set; } 
        public string original_language { get; set; } 
        public string original_title { get; set; } 
        public string overview { get; set; } 
        public double popularity { get; set; } 
        public string poster_path { get; set; } 
        public string release_date { get; set; } 
        public int revenue { get; set; } 
        public int runtime { get; set; } 
        public string status { get; set; } 
        public string tagline { get; set; } 
        public string title { get; set; } 
        public bool video { get; set; } 
        public double vote_average { get; set; } 
        public int vote_count { get; set; } 
    }


    
}
