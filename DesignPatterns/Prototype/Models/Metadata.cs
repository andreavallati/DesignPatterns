using Prototype.Services.Interfaces;

namespace Prototype.Models
{
    public class Metadata : IPrototype<Metadata>
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string Author { get; set; } = string.Empty;

        public Metadata Clone()
        {
            return new Metadata
            {
                CreatedDate = this.CreatedDate,
                Author = this.Author
            };
        }

        public override string ToString()
        {
            return $"Author: {Author}, CreatedDate: {CreatedDate}";
        }
    }
}
