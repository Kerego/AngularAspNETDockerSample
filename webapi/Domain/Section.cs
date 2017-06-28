namespace WebApi
{
    public class Section : Entity<long>
    {
        public long PresentationId { get; set; }
        public Presentation Presentation { get; set; }
        public string Name { get; set; }
    }
}
