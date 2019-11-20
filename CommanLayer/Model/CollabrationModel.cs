﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommanLayer.Model
{
    public class CollabrationModel
    {
        [Key]
        public int Id { get; set; }

        public string CurrentUserId { get; set; }

        [ForeignKey("UserDeatils")]
        public string UserId { get; set; }

        [ForeignKey("NotesModel")]
        public int NoteId { get; set; }
    }
}
