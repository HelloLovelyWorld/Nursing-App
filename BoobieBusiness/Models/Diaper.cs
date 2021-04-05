using System;
using System.Collections.Generic;

#nullable disable

namespace BoobieBusiness.Models
{
    public partial class Diaper
    {
        public int MomId { get; set; }
        public int BabyId { get; set; }
        public int? NumberOfUrineDiapers { get; set; }
        public int? NumberOfSoiledDiapers { get; set; }
        public int? NumberOfMixedDiapers { get; set; }
        public DateTime DateOfDiaperChang { get; set; }
    }
}
