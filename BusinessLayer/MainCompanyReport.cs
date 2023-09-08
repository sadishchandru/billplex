using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class MainCompanyReport : Common
    {
        public string From { get; set; }
        public string TO { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string EJoiningDate { get; set; }
        public string PFNo { get; set; }
        public string ESINo { get; set; }
        public string CompanyName { get; set; }
        public string subContractor { get; set; }
        public string OrderNo { get; set; }
        public string ModelName { get; set; }
        public string ReceivingDate { get; set; }
        public string QuantityPiece { get; set; }
        public string Wages { get; set; }
        public string Deduction { get; set; }
        public string Conveyance { get; set; }
        public string Incentive { get; set; }
        public string NetAmt { get; set; }
        public long NetAmount { get; set; }        
        public string MainCompany { get; set; }
        public List<DropDownItemInfo> MasterCompanyList { get; set; }
        public List<MainCompanyReport> MasterCompanyWagesList { get; set; }

        public void DirectBillReport()
        {
            dbReader = null;
            Result = new ResultDetail();

            try
            {
                InitializeDb();

                List<DbParams> objLstDbParams = new List<DbParams>();
                objLstDbParams.Add(new DbParams(DbType.Date, 50, From, "@From", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.Date, 50, TO, "@To", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 200, MainCompany, "@MainCompany", ParameterDirection.Input));

                dbReader = ObjDbfactory.GetReader("PRO_GetWagesReportForMainCompany", false, objLstDbParams);
                List<MainCompanyReport> masterCompanyWagesList = new List<MainCompanyReport>();
                while (dbReader.Read())
                {
                    MainCompanyReport objDetails = new MainCompanyReport();
                    objDetails.EmployeeCode = ToString(dbReader["EmployeeCode"]);
                    objDetails.EmployeeName = ToString(dbReader["EmployeeName"]);
                    objDetails.EJoiningDate = ToString(dbReader["EJoiningDate"]);
                    objDetails.PFNo = ToString(dbReader["PFNo"]);
                    objDetails.ESINo = ToString(dbReader["ESINo"]);
                    objDetails.CompanyName = ToString(dbReader["CompanyName"]);
                    objDetails.subContractor = ToString(dbReader["subContractor"]);
                    objDetails.OrderNo = ToString(dbReader["OrderNo"]);
                    objDetails.ModelName = ToString(dbReader["ModelName"]);
                    objDetails.ReceivingDate = ToString(dbReader["ReceivingDate"]);
                    objDetails.QuantityPiece = ToString(dbReader["QuantityPiece"]);
                    objDetails.Wages = ToString(dbReader["Wages"]);
                    objDetails.Deduction = ToString(dbReader["Deduction"]);
                    objDetails.Conveyance = ToString(dbReader["Conveyance"]);
                    objDetails.Incentive = ToString(dbReader["Incentive"]);
                    objDetails.NetAmt = ToString(dbReader["NetAmount"]);
                    if (masterCompanyWagesList.Count == 0)
                    {
                        objDetails.TotalCount = ToBigInt(dbReader["total_count"]);
                    }

                    objDetails.RowNumber = ToBigInt(dbReader["row_no"]);

                    masterCompanyWagesList.Add(objDetails);
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

        public List<MainCompanyReport> AssignResult(bool IsList)
        {
            List<MainCompanyReport> departmentlist = new List<MainCompanyReport>();
            while (dbReader.Read())
            {
                MainCompanyReport objDetails = new MainCompanyReport();
                if (IsList)
                {
                    objDetails.EmployeeCode = ToString(dbReader["EmployeeCode"]);
                    objDetails.EmployeeName = ToString(dbReader["EmployeeName"]);
                    objDetails.EJoiningDate = ToString(dbReader["EJoiningDate"]);
                    objDetails.PFNo = ToString(dbReader["PFNo"]);
                    objDetails.ESINo = ToString(dbReader["ESINo"]);
                    objDetails.CompanyName = ToString(dbReader["CompanyName"]);
                    objDetails.subContractor = ToString(dbReader["subContractor"]);
                    objDetails.OrderNo = ToString(dbReader["OrderNo"]);
                    objDetails.ModelName = ToString(dbReader["ModelName"]);
                    objDetails.ReceivingDate = ToString(dbReader["ReceivingDate"]);
                    objDetails.QuantityPiece = ToString(dbReader["QuantityPiece"]);
                    objDetails.Wages = ToString(dbReader["Wages"]);
                    objDetails.Deduction = ToString(dbReader["Deduction"]);
                    objDetails.Conveyance = ToString(dbReader["Conveyance"]);
                    objDetails.Incentive = ToString(dbReader["Incentive"]);
                    objDetails.NetAmt = ToString(dbReader["NetAmount"]);
                    if (departmentlist.Count == 0)
                    {
                        objDetails.TotalCount = ToBigInt(dbReader["total_count"]);
                    }

                    objDetails.RowNumber = ToBigInt(dbReader["row_no"]);
                }

                departmentlist.Add(objDetails);
            }
            return departmentlist;
        }
    }
}
