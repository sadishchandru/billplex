using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class EmployeeFamily : Common
    {
        public Int64 EFEmpId { get; set; }
        public string EFEmpCode { get; set; }
        public string SNo { get; set; }
        public string EFName { get; set; }
        public string EFAddress { get; set; }
        public string EFArea { get; set; }
        public string EFDistrict { get; set; }
        public string EFState { get; set; }
        public string EFPin { get; set; }
        public string EFRelation { get; set; }
        public string EFDOB { get; set; }
        public string EFAge { get; set; }
        public string EFResiding { get; set; }
        public string EFRemark { get; set; }
        
        public List<EmployeeFamily> FamilyList { get; set; }

        #region List

        public void GetList()
        {
            dbReader = null;
            Result = new ResultDetail();
            

            try
            {
                InitializeDb();
                List<DbParams> objLstDbParams = new List<DbParams>();

                objLstDbParams.Add(new DbParams(DbType.String, 50, EFEmpId, "@EmpId", ParameterDirection.Input));

                dbReader = ObjDbfactory.GetReader("PRO_GetEmployeeFamilyList", false, objLstDbParams);

                FamilyList = AssignResult();
               // ResultSet.Add("dairyList", FilterList(DairyList));

                Result.Status = ResultStatus.Success;
            }
            catch (Exception ex)
            {
                Result.Status = ResultStatus.Error;
                Result.Message = ex.Message;
            }
            finally
            {
                CloseConnection();
            }
        }


        public List<EmployeeFamily> AssignResult()
        {
            List<EmployeeFamily> FamilyList = new List<EmployeeFamily>();

            while (dbReader.Read())
            {
                EmployeeFamily FamilyDetail = new EmployeeFamily();
                FamilyDetail.Id = ToInteger(dbReader["Id"]);
                FamilyDetail.EFEmpId = ToInteger(dbReader["EmpId"]);
                FamilyDetail.SNo = ToString(dbReader["SNo"]);
                FamilyDetail.EFName = ToString(dbReader["Name"]);
                FamilyDetail.EFAddress = ToString(dbReader["FAddress"]);
                FamilyDetail.EFArea = ToString(dbReader["Farea"]);
                FamilyDetail.EFDistrict = ToString(dbReader["Fdistrict"]);
                FamilyDetail.EFState = ToString(dbReader["State"]);
                FamilyDetail.EFPin = ToString(dbReader["Pincode"]);
                FamilyDetail.EFRelation = ToString(dbReader["EmployeeRelation"]);
                FamilyDetail.EFDOB = ToDateTimeToString(dbReader["DoB"], "dd/MM/yyyy hh:mm tt");
                FamilyDetail.EFAge = ToString(dbReader["Age"]);
                FamilyDetail.EFResiding = ToString(dbReader["Residing"]);
                FamilyDetail.EFRemark = ToString(dbReader["Remark"]);

                FamilyList.Add(FamilyDetail);
            }

            return FamilyList;
        }
        public object FilterList(List<EmployeeFamily> ItemsList)
        {
            var FilteredList = from FamilyDetail in ItemsList
                               select new
                               {
                                   FamilyDetail.Id
                                   ,FamilyDetail.EFEmpId
                                   ,FamilyDetail.SNo
                                   ,FamilyDetail.EFName
                                   ,FamilyDetail.EFAddress
                                   ,FamilyDetail.EFArea
                                   ,FamilyDetail.EFDistrict
                                   ,FamilyDetail.EFState
                                   ,FamilyDetail.EFPin
                                   ,FamilyDetail.EFRelation
                                   ,FamilyDetail.EFDOB
                                   ,FamilyDetail.EFAge
                                   ,FamilyDetail.EFResiding
                                   ,FamilyDetail.EFRemark



                               };

            return FilteredList;
        }
        #endregion

        #region Update

        public void Update()
        {
            dbReader = null;
            Result = new ResultDetail();

            try
            {
                InitializeDb();

                // Calling the stored procedure for creating a Employee Finance
                List<DbParams> objLstDbParams = new List<DbParams>();
                string FamilyItems = CollectDairyItems();

                objLstDbParams.Add(new DbParams(DbType.Xml, FamilyItems.Length, FamilyItems, "@family_items", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EFEmpId, "@EmpId", ParameterDirection.Input));

                dbReader = ObjDbfactory.GetReader("PRO_UpdateFamily", false, objLstDbParams);

                while (dbReader.Read())
                {
                    Result.Message = ToString(dbReader["ResultMessage"]);
                    Result.Status = (ResultStatus)ToInteger(dbReader["ResultNo"]);
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
        #endregion

        #region Convert List to XML
        public string CollectDairyItems()
        {
            StringBuilder ItemData = new StringBuilder();
            try
            {
                ItemData.Append("<Family>");
                foreach (EmployeeFamily item in FamilyList)
                {
                    ItemData.Append("<FamilyItems>");
                    ItemData.AppendFormat("<EmpId>{0}</EmpId>", item.EFEmpId);
                    ItemData.AppendFormat("<SNo>{0}</SNo>", item.SNo);
                    ItemData.AppendFormat("<Name>{0}</Name>", item.EFName);
                    ItemData.AppendFormat("<FAddress>{0}</FAddress>", item.EFAddress);
                    ItemData.AppendFormat("<Farea>{0}</Farea>", item.EFArea);
                    ItemData.AppendFormat("<Fdistrict>{0}</Fdistrict>", item.EFDistrict);
                    ItemData.AppendFormat("<State>{0}</State>", item.EFState);
                    ItemData.AppendFormat("<Pincode>{0}</Pincode>", item.EFPin);
                    ItemData.AppendFormat("<EmployeeRelation>{0}</EmployeeRelation>", item.EFRelation);
                    ItemData.AppendFormat("<DoB>{0}</DoB>", item.EFDOB);
                    ItemData.AppendFormat("<Age>{0}</Age>", item.EFAge);
                    ItemData.AppendFormat("<Residing>{0}</Residing>", item.EFResiding);
                    ItemData.AppendFormat("<Remark>{0}</Remark>", item.EFRemark);

                    ItemData.Append("</FamilyItems>");
                }
                ItemData.Append("</Family>");
            }
            catch (Exception ex)
            {
                //XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ItemData.ToString();
        }
        #endregion 
    }
}
