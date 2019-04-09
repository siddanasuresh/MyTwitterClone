using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyTwitterClone.Models
{
    public class Tweet
    {
        [Key]
        public int id { get; set; }

        [DisplayName("User")]
        public string UserId { get; set; }

        public string Message { get; set; }

        [DisplayName("Date")]
        public DateTime CreatedDate { get; set; }

        public Person User { get; set; }
        
        public ICollection<Tweet> TweetList { get; set; }

    }
}