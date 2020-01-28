using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    [Authorize(Roles = "Admin")]
    public class Manager
    {
        public int Id { get; set; }

        public User User { get; set; }
    }

}
