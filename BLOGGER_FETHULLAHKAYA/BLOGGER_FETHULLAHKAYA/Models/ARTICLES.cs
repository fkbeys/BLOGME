using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLOGS.Models
{
    [Table("ARTICLES")]
    public class ARTICLES
    {
        /// <summary>
        /// ID FOR ARTICLE
        /// </summary>
        [Key]
        public int ARTICLE_ID { get; set; }

        /// <summary>
        /// This area is used to find which author created the article
        /// </summary>
        public int ARTICLE_AUTHOR_ID { get; set; }
        
        /// <summary>
        /// Represents the the creation date of the article 
        /// </summary>
        public DateTime ARTICLE_CREATE_DATE { get; set; } = DateTime.Now;

        /// <summary>
        /// by default this area is null, otherwise if this field contains a author id, it means that, that author has made 
        /// changes to the article.
        /// </summary>
        public int ARTICLE_EDIT_AUTHOR_ID { get; set; }

        /// <summary>
        /// this area represents the change date of the article
        /// </summary>
        public DateTime ARTICLE_EDIT_DATE { get; set; }

        /// <summary>
        /// article title
        /// </summary>
        public string ARTICLE_TITLE { get; set; }

        /// <summary>
        /// this area stores the path of the image 
        /// </summary>
        public string ARTICLE_IMAGEURL { get; set; }

        /// <summary>
        /// Article Description
        /// </summary>
        public string ARTICLE_DESCRIPTION { get; set; }

        /// <summary>
        /// Article Content
        /// </summary>
        public string ARTICLE_CONTENT { get; set; }

        /// <summary>
        /// This bool area is used to check if the article is active or not
        /// </summary>
        public bool ARTICLE_ISACTIVE { get; set; }

        /// <summary>
        /// this int area keeps the information of how many times the article liked by the users
        /// </summary>
        public int ARTICLE_LIKE { get; set; }

    }
}
