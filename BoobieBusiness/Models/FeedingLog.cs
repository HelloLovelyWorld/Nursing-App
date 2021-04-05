using System;
using System.Collections.Generic;

#nullable disable

namespace BoobieBusiness.Models
{
    public partial class FeedingLog
    {
        public FeedingLog()
        {
            MilkStorages = new HashSet<MilkStorage>();
        }

        public int BabyId { get; set; }
        public int AmountFed { get; set; }
        public DateTime? TimeFed { get; set; }
        public int MilkId { get; set; }

        public virtual MilkStorage Milk { get; set; }
        public virtual ICollection<MilkStorage> MilkStorages { get; set; }
    }
}
