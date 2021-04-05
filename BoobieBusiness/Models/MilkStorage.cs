using System;
using System.Collections.Generic;

#nullable disable

namespace BoobieBusiness.Models
{
    public partial class MilkStorage
    {
        public MilkStorage()
        {
            FeedingLogs = new HashSet<FeedingLog>();
        }

        public int MomId { get; set; }
        public int BabyId { get; set; }
        public int AmountStored { get; set; }
        public DateTime DateStored { get; set; }

        public virtual FeedingLog Baby { get; set; }
        public virtual ICollection<FeedingLog> FeedingLogs { get; set; }
    }
}
