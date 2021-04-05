using System;
using System.Collections.Generic;

#nullable disable

namespace BoobieBusiness.Models
{
    public partial class Mom
    {
        public int MomId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime? NumberOfBabies { get; set; }
        public int BabyId { get; set; }
    }
}
