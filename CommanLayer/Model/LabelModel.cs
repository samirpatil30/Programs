using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CommanLayer.Model
{
   public class LabelModel
    {
        public int Id { get; set; }

        [Required]
        [ForeignKey("UserDetails")]
        public string UserId { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z ]*$")]
        public string Label { get; set; }
        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

    }
}
