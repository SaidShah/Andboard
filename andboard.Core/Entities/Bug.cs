
using System;
using System.ComponentModel.DataAnnotations;

namespace andboard.Core.Entities
{
    public class Bug : Entity
    {
        [Required]
        public DateTimeOffset CreatedOn { get; set; }

        public DateTimeOffset? DeletedOn { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public bool Status { get; set; }

        [Required]
        public int ProjectId { get; set; }

    }
}
