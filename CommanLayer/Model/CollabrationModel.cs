using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CommanLayer.Model
{
   public class CollabrationModel
    {
        [Key]
        public int Id { get; set; }

        public string SenderId { get; set; }

        [ForeignKey("NotesModel")]
        public string UserId { get; set; }

        [ForeignKey("NotesModel")]
        public int NoteId { get; set; }
    }
}
