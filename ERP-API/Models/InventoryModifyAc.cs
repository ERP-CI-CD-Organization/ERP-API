﻿using System;

namespace ERP_API.Models
{
    public partial class InventoryModifyAc
    {
        public int Id { get; set; }
        public int ModifyAcid { get; set; }
        public int StoreId { get; set; }
        public string StoreZone { get; set; }
        public int GoodsId { get; set; }
        public int Num { get; set; }
        public decimal OldAc { get; set; }
        public decimal NewAc { get; set; }
        public string StoreZoneMemo { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
