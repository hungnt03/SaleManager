using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Entities
{
    public abstract class Auditable
    {
        public DateTime? CreatedAt { set; get; }

        [MaxLength(256)]
        public string CreatedBy { set; get; }

        public DateTime? UpdatedAt { set; get; }

        [MaxLength(256)]
        public string UpdatedBy { set; get; }
    }
}
