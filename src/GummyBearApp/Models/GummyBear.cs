using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GummyBearApp.Models
{
    [Table("GummyBear")]
    public class GummyBear
    {
        [Key]
        public int GummyBearId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int Cost { get; set; }
        public string ImageSrc { get; set; }
        public string ImageAlt { get; set; }

    }
}
