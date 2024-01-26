using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace draftdreamz.Components.Model
{
    [Table("ContentInfo")]
    public class ContentInfo
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // work is the post and content is the parent of multiple posts
        public Guid ContentId { get; set; }

        public string ContentTitle { get; set; }
        public string ContentData { get; set; }
        public string ContentType { get; set; }
        public string Author { get; set; }
        public string ContentLastUpdatedBy { get; set; }
        public int ContentOrder { get; set; }
        public Guid WorkId { get; set; }
    }
}