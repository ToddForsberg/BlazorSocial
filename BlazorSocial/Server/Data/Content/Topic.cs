using System.Collections.Generic;

namespace BlazorSocial.Server.Data.Content
{
    public class Topic
    {
        public long Id { get; set; }
        public string Title { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}