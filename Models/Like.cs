using System;
using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models
{
    public class Like
    {
        [Key]
        public int LikeId {get;set;}
        public int UserId {get;set;} 
        public User UserWhoLikes {get;set;} 
        public int MovieId {get;set;} 
        public string MovieTitle {get;set;}
        // public Movie LikedMovie {get;set;} 

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}