using FilmsLibrary.Models.Interfaces;

namespace FilmsLibrary.Models
{
    public class Film : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }

    }
}
