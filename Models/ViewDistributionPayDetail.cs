﻿using System;

namespace ERP_API.Models
{
    public partial class ViewDistributionPayDetail
    {
        public int Id { get; set; }
        public int PayId { get; set; }
        public int BranchId { get; set; }
        public int ChildBranchId { get; set; }
        public decimal ChargeOff { get; set; }
        public decimal PayMoney { get; set; }
        public DateTime PayDate { get; set; }
        public string PayType { get; set; }
        public int? PayAccount { get; set; }
        public string Memo { get; set; }
        public int UserId { get; set; }
        public string ChildBranchName { get; set; }
        public string UserName { get; set; }
        public int OrderId { get; set; }
        public int GoodsId { get; set; }
        public int Num { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public decimal ChargeOffAmount { get; set; }
        public DateTime UpdateTime { get; set; }
        public string DisplayName { get; set; }
        public string Unit { get; set; }
        public string BankInfo { get; set; }
        public bool IsDelete { get; set; }
        public int StatementId { get; set; }
    }
}
