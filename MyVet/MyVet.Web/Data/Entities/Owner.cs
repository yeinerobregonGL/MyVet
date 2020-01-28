using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;

namespace MyVet.Web.Data.Entities
{
    [Authorize( Roles ="Admin")]
    public class Owner
    {
        public int Id { get; set; }

        public User User { get; set; }

        public ICollection<Pet> Pets { get; set; }
    }
}
