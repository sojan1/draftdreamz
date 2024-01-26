using System.ComponentModel.DataAnnotations;

namespace draftdreamz.Components.Model
{
    public class ContentType
    {
        [Key]
        public Guid ContentTypeId { get; set; }
        public string ContentTypeName { get; set; }
        public string ContentTypeDescription { get; set; }
        public string ContentTypeImageUrl { get; set; }
        public string ContentTypeCreatedBy { get; set; }
        public DateTime ContentTypeCreatedDate { get; set; }
        public bool ContentTypeActive { get; set; }
    }
}