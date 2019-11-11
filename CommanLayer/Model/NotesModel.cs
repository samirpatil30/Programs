using CommanLayer.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CommanLayer.Model
{
    public class NotesModel
    {
        public int Id { get; set; }
        [ForeignKey("UserDetails")]
        public string UserId { get; set; }

        public string NotesTitle { get; set; }

        public string NotesDescription { get; set; }

        public DateTime? CreatedDate { get; set; }  

        public DateTime? ModifiedDate { get; set; }

        public string color { get; set; }

        public EnumNoteType NotesType { get; set; }
    }
}
