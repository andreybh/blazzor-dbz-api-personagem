using System.Collections.Generic;

namespace BlazzorDbzPersonagem.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Planet { get; set; }
        public List<string>? Transformations { get; set; }
    }
}
