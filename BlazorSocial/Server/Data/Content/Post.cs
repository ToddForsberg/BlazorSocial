using System;
using System.Collections.Generic;

namespace BlazorSocial.Server.Data.Content
{
    public class Post
    {
        public long Id { get; set; }
        public Post Parent { get; set; }
        public string Author { get; set; }
        public DateTime Posted { get; set; }
        public DateTime Edited { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public ICollection<Post> Responses { get; set; }
    }
}