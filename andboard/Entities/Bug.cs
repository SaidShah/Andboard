using andboard.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace andboard.Entities
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
