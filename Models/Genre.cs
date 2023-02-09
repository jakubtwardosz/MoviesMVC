using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MoviesMVC.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
