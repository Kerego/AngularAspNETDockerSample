using System.Collections.Generic;

namespace WebApi
{
    public class Presentation : Entity<long>
    {
        public string Title { get; set; }
        public string Speaker { get; set; }
        public IList<Section> Sections { get; set; }
    }
}
