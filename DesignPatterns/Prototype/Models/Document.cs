using Prototype.Services.Interfaces;

namespace Prototype.Models
{
    public class Document : IPrototype<Document>
    {
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public Metadata Metadata { get; set; }

        private readonly IRevisionService _revisionService;

        public Document(IRevisionService revisionService)
        {
            _revisionService = revisionService;
            Metadata = new Metadata();
        }

        public Document Clone()
        {
            var clonedDocument = new Document(_revisionService)
            {
                Title = this.Title,
                Content = this.Content,
                Metadata = this.Metadata.Clone()
            };

            _revisionService.TrackChange("Cloned a document.");
            return clonedDocument;
        }

        public void AddContent(string newContent)
        {
            Content += newContent;
            _revisionService.TrackChange("Added content to document.");
        }

        public override string ToString()
        {
            return $"Title: {Title}, Content: {Content}, Metadata: {Metadata}";
        }
    }
}
