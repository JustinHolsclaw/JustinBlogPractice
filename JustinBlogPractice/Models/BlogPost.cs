using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustinBlogPractice.Models
{
    public class BlogPost
    {
        public string Title { get; set; }

        public int ID { get; set; }
        public string Body { get; set; }
        public DateTime PostedOn { get; set; }
        public DateTime EditedOn { get; set; }

    }
}
