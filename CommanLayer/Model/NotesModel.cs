// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotesModel.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// --------------------------------------------------------------------------------------------------------------------
namespace CommanLayer.Model
{
    using CommanLayer.Enum;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    /// <summary>
    /// NotesModel
    /// </summary>
    public class NotesModel
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        /// <value>
        /// The Id of the user.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        /// <value>
        /// The UserId
        /// </value>
        [ForeignKey("UserDetails")]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the NotesTitle.
        /// </summary>
        /// <value>
        /// The NotesTitle of the notes
        /// </value>
        public string NotesTitle { get; set; }

        /// <summary>
        /// Gets or sets the NotesDescription.
        /// </summary>
        /// <value>
        /// The NotesDescription of the notes.
        /// </value>
        public string NotesDescription { get; set; }

        /// <summary>
        /// Gets or sets the CreateDate.
        /// </summary>
        /// <value>
        /// The CreateDate of the notes.
        /// </value>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the Modified.
        /// </summary>
        /// <value>
        /// The ModifiedDate of the notes.
        /// </value>
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the Color.
        /// </summary>
        /// <value>
        /// The Color of the Notes.
        /// </value>
        
            [Required]
            [RegularExpression("^#(?:[0-9a-fA-F]{3}){1,2}$")]
        public string color { get; set; }

        /// <summary>
        /// Gets or sets the NotesType.
        /// </summary>  
        /// <value>
        /// The NotesTyoe of the notes.
        /// </value>
        public EnumNoteType NotesType { get; set; }

        public DateTime Reminder { get; set; }

        public string Image { get; set; }

        public bool Trash { get; set; }

        public bool Archive { get; set; }

        public bool Pin { get; set; }



    }
}
