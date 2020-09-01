using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLOGS.Models
{
    [Table("AUTHORS")]
    public class AUTHORS
    {

        /// <summary>
        /// Author ID 
        /// </summary>
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int AUTOHOR_ID { get; set; }

        /// <summary>
        /// Author Name
        /// </summary>
        [StringLength(20), Required]

        public string AUTHOR_NAME { get; set; }


        /// <summary>
        /// Author Surname
        /// </summary>
        [StringLength(20), Required]
        public string AUTHOR_SURNAME { get; set; }



        /// <summary>
        /// This area shows the creation date of the article
        /// </summary>
        public DateTime AUTHOR_CREATE_DATE { get; set; } = DateTime.Now;
        public bool AUTHOR_ISACTIVE { get; set; } = true;

    }
}
