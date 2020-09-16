using System;
using System.ComponentModel.DataAnnotations;

namespace andboard.Core.Entities
{
    public class CustomerProject : Entity
    {
        [Required]
        public DateTimeOffset CreatedOn { get; set; }

        public DateTimeOffset? DeletedOn { get; set; }

        [Required]
        public string Name { get; set; }

    }
}
