using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Medias.API.Entities
{
    [Table("Medias")]
    public class Media
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Title { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }


        public string Thumbnail { get; set; }

        public Guid MediaGroupId { get; set; }
        public MediaGroup MediaGroup { get; set; }
    }
}
