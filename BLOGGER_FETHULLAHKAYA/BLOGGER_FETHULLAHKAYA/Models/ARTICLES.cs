using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLOGS.Models
{
    [Table("ARTICLES")]
    public class ARTICLES
    {
        [Key]
        public int ARTICLE_ID { get; set; }
        public int ARTICLE_AUTHOR_ID { get; set; }
        public DateTime ARTICLE_CREATE_DATE { get; set; } = DateTime.Now;
        public int ARTICLE_EDIT_AUTHOR_ID { get; set; }
        public DateTime ARTICLE_EDIT_DATE { get; set; }
        public string ARTICLE_TITLE { get; set; }
        public string ARTICLE_IMAGEURL { get; set; }
        public string ARTICLE_DESCRIPTION { get; set; }
        public string ARTICLE_CONTENT { get; set; }
        public bool ARTICLE_ISACTIVE { get; set; }
        public int ARTICLE_LIKE { get; set; }

    }
}
