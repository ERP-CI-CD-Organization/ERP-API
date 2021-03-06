﻿using System;

namespace ERP_API.Models
{
    public partial class SysBranchAreaDetail
    {
        public int Id { get; set; }
        public int AreaId { get; set; }
        public int Sort { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Alt { get; set; }
        public string Href { get; set; }
        public DateTime UpdateTime { get; set; }
        public string ImgUrl { get; set; }
    }
}
