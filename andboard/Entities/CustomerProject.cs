using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace andboard.Entities
{
    public class CustomerProject : Entity
    {
        [Required]
        public DateTimeOffset CreatedOn { get; set; }

        public DateTimeOffset DeletedOn { get; set; }

        [Required]
        public string Name { get; set; }

    }
}
