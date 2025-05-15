using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{   
    public class Album
    {
        public int Id { get; set; }
        [DisplayName("Album")]
        public string Title { get; set; }
        public string Artist { get; set; }
        public Genre Genre { get; set; }
        public Edition Edition { get; set; }
        public int Songs { get; set; }
        public string ImageURL { get; set; }
    }
}
