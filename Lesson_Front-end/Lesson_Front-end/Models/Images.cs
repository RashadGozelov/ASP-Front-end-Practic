using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson_Front_end.Models
{
    public class Images
    {
        private static List<Image> images = new List<Image>
        {
            new Image{Id=1,Link="recent1.jpg"},
            new Image{Id=1,Link="recent2.jpg"},
            new Image{Id=1,Link="recent3.jpg"}
        };

        public static List<Image> GetImages() => images;
    }

    public class Image
    {
        public int Id { get; set; }

        public string Link { get; set; }
    }
}