using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillPlex.Models
{
    public class LabourBillData
    {
        public string BillNo { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string Date { get; set; }
        public string LessDeducation { get; set; }
        public string SubTotal1 { get; set; }
        public string Conveyance { get; set; }
        public string Incentives { get; set; }
        public string SubTotal2 { get; set; }
        public string SupVisorTotal { get; set; }
        public string GrandTotal { get; set; }
        public string ProductIncentive { get; set; }
        public string PFText { get; set; }
        public string TotalESI { get; set; }
        public string TotalBouns { get; set; }
        public string FinalTotal { get; set; }
        public string Advance { get; set; }
        public string NetAmount { get; set; }
    }
}
