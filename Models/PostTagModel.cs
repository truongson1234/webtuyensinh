using Azure;
using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations.Schema;

namespace webtuyensinh.Models
{
    [Table("PostTags")]
    public class PostTagModel
    {
        public int ID { get; set; }
        public int PostID { get; set; }
        public int TagID { get; set; }

        public PostModel Post { get; set; }
        public TagModel Tag { get; set; }

    }
}
