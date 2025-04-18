using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Project;


namespace OOP_Project
{
    public class Movie
    { 
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
        public decimal Rating { get; set; }
        public string ImageUrl { get; set; }
        public int Views { get; set; }
        public DateTime CreatedAt { get; set; }

        //search
       
        public override string ToString() => Title;

    }
}
