using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLOGS.Models
{
    [Table("AUTHORS")]
    public class AUTHORS
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int AUTOHOR_ID { get; set; }

        [StringLength(20), Required]
        public string AUTHOR_NAME { get; set; }


        [StringLength(20), Required]
        public string AUTHOR_SURNAME { get; set; }

        public DateTime AUTHOR_CREATE_DATE { get; set; } = DateTime.Now;
        public bool AUTHOR_ISACTIVE { get; set; } = true;

    }
}
