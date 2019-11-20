using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CommanLayer.Model
{
   public class SearchModel
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("UserDetails")]
        public string UserId { get; set; }

        [ForeignKey("NotesModel")]
        public int NoteId { get; set; }

        [ForeignKey("LabelModel")]
        public int LabelId { get; set; }

    }
}
