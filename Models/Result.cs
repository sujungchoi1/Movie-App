using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 
namespace MovieApp.Models
{
       
     public class Result    {
        public bool adult { get; set; } 
        public string backdrop_path { get; set; } 
        [NotMapped]
        public List<int> genre_ids { get; set; } 
        public int id { get; set; } 
        public string original_language { get; set; } 
        public string original_title { get; set; } 
        public string overview { get; set; } 
        public double popularity { get; set; } 
        public string poster_path { get; set; } 
        public string release_date { get; set; } 
        public string title { get; set; } 
        public bool video { get; set; } 
        public double vote_average { get; set; } 
        public int vote_count { get; set; } 
        // public int UserId {get;set;}
        // public User WatchedBy {get;set;}
        public List<Watch> Watches {get;set;}
        public List<Like> Likes {get;set;}
    }

}
