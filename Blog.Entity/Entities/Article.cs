using Blog.Core;
//ctrl+R+G

namespace Blog.Entity.Entities
{
    internal class Article : EntityBase
    {
        public string Content { get; set; }
        public int ViewCount { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public Guid ImageId { get; set; }
        public Image Image { get; set; }
    }
}
