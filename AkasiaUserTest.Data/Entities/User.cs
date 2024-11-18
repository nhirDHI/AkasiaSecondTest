using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkasiaUserTest.Domain.Entities
{
    public class User
    {
        public int id { get; set; }

        public string? name { get; set; }

        public string? email { get; set; }

        public DateTime? created_at { get; set; }
    }
}
