using System;
using System.Collections.Generic;

#nullable disable

namespace BoobieBusiness.Models
{
    public partial class Baby
    {
        public int MomId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int BabyId { get; set; }
    }
}
