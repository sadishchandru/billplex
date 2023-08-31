using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DirectLabourBill : Common
    {
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string ClientWise { get; set; }
        public string MainComapny { get; set; }
        public string ClientComapny { get; set; }
        public string SubClientCompany { get; set; }
        public string ModelName { get; set; }
        public string ProductName { get; set; }
        public string ProductSize { get; set; }
        public string QuantityPiece { get; set; }
        public string WagesforEmp { get; set; }
        public string TotalQty { get; set; }
        public string NetAmt { get; set; }
        public string TotalAmt { get; set; }
        public List<DropDownItemInfo> MasterCompanyList { get; set; }
        public List<DropDownItemInfo> ClientCompanyList { get; set; }
        public List<DropDownItemInfo> SubClientList { get; set; }
        public List<DirectLabourBill> DirectBillReportList { get; set; }

        public void DirectBillReport()
        {
            dbReader = null;
            Result = new ResultDetail();

            DirectBillReportList = new List<DirectLabourBill>();

            try
            {
                InitializeDb();

                List<DbParams> objLstDbParams = new List<DbParams>();
                objLstDbParams.Add(new DbParams(DbType.String, 50, FromDate, "@From", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ToDate, "@To", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 200, ClientWise, "@IsClientWise", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 200, MainComapny, "@MainCompany", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 200, ClientComapny, "@ClientCompany", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 200, SubClientCompany, "@SubClientCompany", ParameterDirection.Input));

                dbReader = ObjDbfactory.GetReader("PRO_GetDirectLabourBill", false, objLstDbParams);

                while (dbReader.Read())
                {
                    DirectLabourBill item = new DirectLabourBill();

                    item.ModelName = ToString(dbReader["ModelName"]);
                    item.ProductName = ToString(dbReader["ProductName"]);
                    item.ProductSize = ToString(dbReader["ProductSize"]);
                    item.QuantityPiece = ToString(dbReader["QuantityPiece"]);
                    item.WagesforEmp = ToString(dbReader["WagesforEmp"]);
                    item.TotalQty = ToString(dbReader["TotalQty"]);
                    item.NetAmt = ToString(dbReader["NetAmt"]);
                    item.TotalAmt = ToString(dbReader["TotalAmt"]);
                    DirectBillReportList.Add(item);
                }
            }
            catch (Exception ex)
            {
                Result.Message = ex.Message;
                Result.Status = ResultStatus.Success;
            }
            finally
            {
                CloseConnection();
            }
        }

        //public List<DirectLabourBill> AssignResult()
        //{
        //    List<DirectLabourBill> OrderList = new List<DirectLabourBill>();
        //    dbReader.NextResult();

        //    while (dbReader.Read())
        //    {
        //        DirectLabourBill OrderDetail = new DirectLabourBill();
        //        OrderDetail.ModelName = ToString(dbReader["ModelName"]);
        //        OrderDetail.ProductName = ToString(dbReader["ProductName"]);
        //        OrderDetail.ProductSize = ToDateTimeToString(dbReader["ProductSize"]);
        //        OrderDetail.QuantityPiece = ToString(dbReader["QuantityPiece"]);
        //        OrderDetail.WagesforEmp = ToString(dbReader["WagesforEmp"]);
        //        OrderDetail.TotalQty = ToString(dbReader["TotalQty"]);
        //        OrderDetail.NetAmt = ToString(dbReader["NetAmt"]);
        //        OrderDetail.TotalAmt = ToString(dbReader["TotalAmt"]);
        //        OrderList.Add(OrderDetail);
        //    }

        //    return OrderList;
        //}
    }
}
