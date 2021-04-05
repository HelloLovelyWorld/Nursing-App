using System;
using System.Collections.Generic;

#nullable disable

namespace BoobieBusiness.Models
{
    public partial class Sleep
    {
        public int MomId { get; set; }
        public int BabyId { get; set; }
        public DateTime StartSleepTime { get; set; }
        public DateTime EndSleepTime { get; set; }
        public int TotalSleepTimeIn24Hours { get; set; }
    }
}
