using System.Collections.Generic;

namespace BlazorSocial.Server.Data.Content
{
    public class Category
    {
        public long Id { get; set; }
        public long Title { get; set; }
        public ICollection<Topic> Topics { get; set; }
    }
}