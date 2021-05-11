using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public string Sound { get; set; }
        //public string Description { get; set; }
        public Boolean isSinger { get; set; }
        public static List<Album> GetList()
        {
            List<Album> list = new List<Album>();
            Album a1 = new Album { Id = 1, Name = "Despacito", Type = "Spanish", Category="A", isSinger=true, Sound="low"};
            list.Add(a1);
            Album a2 = new Album { Id = 2, Name = "Shape of You", Type = "Jazz" , Category="B", isSinger=false, Sound="medium" };
            list.Add(a2);
            Album a3 = new Album { Id = 3, Name = "Never Ending Story", Type = "Poetic", Category = "A", isSinger=true, Sound="high" };
            list.Add(a3);
            Album a4 = new Album { Id = 4, Name = "Love me like you do", Type = "Romantic", Category = "B", isSinger=true, Sound="medium" };
            list.Add(a4);
            Album a5 = new Album { Id = 5, Name = "Birthday song", Type = "DJ", Category = "A", isSinger=false, Sound="low" };
            list.Add(a5);
            Album a6 = new Album { Id = 6, Name = "Jingle Bells", Type = "Christmas", Category = "C", isSinger=false, Sound="high"};
            list.Add(a6);
            return list;
        }
    }
}
