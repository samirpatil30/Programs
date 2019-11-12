using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CommanLayer.Model
{
    /// <summary>
    /// LabelModel
    /// </summary>
    public class LabelModel
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// UserId
        /// </summary>
        [Required]
        [ForeignKey("UserDetails")]
        public string UserId { get; set; }

        /// <summary>
        /// Label
        /// </summary>
        [Required]
        [RegularExpression("^[a-zA-Z ]*$")]
        public string Label { get; set; }

        /// <summary>
        /// CreatedDate
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// ModifiedDate
        /// </summary>
        public DateTime? ModifiedDate { get; set; }

    }
}
