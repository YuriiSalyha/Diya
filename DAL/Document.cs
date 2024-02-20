namespace DAL
{
    public class Document
    {
        public Guid DocumentId { get; set; }
        public int DocumentType { get; set; }
        public string DocumentLink { get; set; }
        public virtual Person? Person { get; set; }
    }
}
