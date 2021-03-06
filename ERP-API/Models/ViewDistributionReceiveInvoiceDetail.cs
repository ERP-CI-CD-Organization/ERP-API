﻿using System;

namespace ERP_API.Models
{
    public partial class ViewDistributionReceiveInvoiceDetail
    {
        public int Id { get; set; }
        public int ReceiveInvoiceId { get; set; }
        public int OrderId { get; set; }
        public int GoodsId { get; set; }
        public int Num { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public decimal ChargeOffAmount { get; set; }
        public decimal TaxRate { get; set; }
        public string TaxCode { get; set; }
        public DateTime UpdateTime { get; set; }
        public int BranchId { get; set; }
        public int ChildBranchId { get; set; }
        public int InvoiceType { get; set; }
        public string InvoiceNo { get; set; }
        public string InvoiceCode { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime ReceiveDate { get; set; }
        public decimal InvoiceMoney { get; set; }
        public decimal ChargeOff { get; set; }
        public string BuyerName { get; set; }
        public string BuyerTaxNo { get; set; }
        public string BuyerBank { get; set; }
        public string BuyerBankAccount { get; set; }
        public string BuyerPhone { get; set; }
        public string BuyerAddress { get; set; }
        public string SaleName { get; set; }
        public string SaleTaxNo { get; set; }
        public string SaleBank { get; set; }
        public string SaleBankAccount { get; set; }
        public string SalePhone { get; set; }
        public string SaleAddress { get; set; }
        public string Memo { get; set; }
        public int UserId { get; set; }
        public string DisplayName { get; set; }
        public string Unit { get; set; }
        public string ChildBranchName { get; set; }
        public string UserName { get; set; }
        public bool IsDelete { get; set; }
        public int StatementId { get; set; }
    }
}
