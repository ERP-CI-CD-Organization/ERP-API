﻿using System;

namespace ERP_API.Models
{
    public partial class SysBranchHelp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime UpdateTime { get; set; }
        public int GroupId { get; set; }
        public int BranchId { get; set; }
        public bool IsLocked { get; set; }
    }
}
