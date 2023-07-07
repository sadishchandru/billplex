using System;
using System.Collections.Generic;
using DataLayer;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class EmployeeNominee : Common
    {
        public string ENEmpCode { get; set; }
        public Int64 ENEmpId { get; set; }
        public string ENSNo { get; set; }
        public string ENName { get; set; }
        public string ENAddress { get; set; }
        public string ENArea { get; set; }
        public string ENDistrict { get; set; }
        public string ENState { get; set; }
        public string ENPin { get; set; }
        public string ENRelation { get; set; }
        public string ENDob { get; set; }
        public string ENAge { get; set; }
        public string ENResidence { get; set; }
        public string ENgratuity { get; set; }
        public string ENMStatus { get; set; }
        public string ENReligion { get; set; }
        public string ENFName { get; set; }
        public string ENGName { get; set; }
        public string ENGAddress { get; set; }
        public string ENGRelation { get; set; }


        public List<EmployeeNominee> NomineeList { get; set; }
        public List<EmployeeNominee> NomineeDBList { get; set; }


        #region List

        public void GetList()
        {
            dbReader = null;
            Result = new ResultDetail();

            try
            {
                InitializeDb();
                List<DbParams> objLstDbParams = new List<DbParams>();

                objLstDbParams.Add(new DbParams(DbType.String, 50, ENEmpId, "@EmpId", ParameterDirection.Input));

                dbReader = ObjDbfactory.GetReader("PRO_GetEmployeeNomineeList", false, objLstDbParams);

                NomineeDBList = AssignResult();
                //ResultSet.Add("dairyList", FilterList(DairyList));

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


        public List<EmployeeNominee> AssignResult()
        {
            List<EmployeeNominee> FamilyList = new List<EmployeeNominee>();

            while (dbReader.Read())
            {
                EmployeeNominee FamilyDetail = new EmployeeNominee();
                FamilyDetail.Id = ToInteger(dbReader["Id"]);
                FamilyDetail.ENEmpId = ToInteger(dbReader["EmpId"]);
                FamilyDetail.ENSNo = ToString(dbReader["SNo"]);
                FamilyDetail.ENName = ToString(dbReader["Name"]);
                FamilyDetail.ENAddress = ToString(dbReader["FAddress"]);
                FamilyDetail.ENArea = ToString(dbReader["Farea"]);
                FamilyDetail.ENDistrict = ToString(dbReader["Fdistrict"]);
                FamilyDetail.ENState = ToString(dbReader["State"]);
                FamilyDetail.ENPin = ToString(dbReader["Pincode"]);
                FamilyDetail.ENRelation = ToString(dbReader["EmployeeRelation"]);
                FamilyDetail.ENDob = ToDateTimeToString(dbReader["DoB"], "dd/MM/yyyy hh:mm tt");
                FamilyDetail.ENAge = ToString(dbReader["Age"]);
                FamilyDetail.ENResidence = ToString(dbReader["Residing"]);
                FamilyDetail.ENgratuity = ToString(dbReader["Porportion"]);
                FamilyDetail.ENMStatus = ToString(dbReader["MaritalStatus"]);
                FamilyDetail.ENReligion = ToString(dbReader["Religion"]);
                FamilyDetail.ENFName = ToString(dbReader["FName"]);
                FamilyDetail.ENGName = ToString(dbReader["GuardianName"]);
                FamilyDetail.ENGAddress = ToString(dbReader["GuardianAddress"]);

                FamilyList.Add(FamilyDetail);
            }

            return FamilyList;
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
                string NomineeItems = CollectDairyItems();

                objLstDbParams.Add(new DbParams(DbType.Xml, NomineeItems.Length, NomineeItems, "@nominee_items", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ENEmpId, "@EmpId", ParameterDirection.Input));

                dbReader = ObjDbfactory.GetReader("PRO_UpdateNominee", false, objLstDbParams);

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


        #region Convert List to XML
        public string CollectDairyItems()
        {
            StringBuilder ItemData = new StringBuilder();
            try
            {
                ItemData.Append("<Nominee>");
                foreach (EmployeeNominee item in NomineeList)
                {
                    ItemData.Append("<NomineeItems>");
                    ItemData.AppendFormat("<EmpId>{0}</EmpId>", item.ENEmpId);
                    ItemData.AppendFormat("<SNo>{0}</SNo>", item.ENSNo);
                    ItemData.AppendFormat("<Name>{0}</Name>", item.ENName);
                    ItemData.AppendFormat("<FAddress>{0}</FAddress>", item.ENAddress);
                    ItemData.AppendFormat("<Farea>{0}</Farea>", item.ENArea);
                    ItemData.AppendFormat("<Fdistrict>{0}</Fdistrict>", item.ENDistrict);
                    ItemData.AppendFormat("<State>{0}</State>", item.ENState);
                    ItemData.AppendFormat("<Pincode>{0}</Pincode>", item.ENPin);
                    ItemData.AppendFormat("<EmployeeRelation>{0}</EmployeeRelation>", item.ENRelation);
                    ItemData.AppendFormat("<DoB>{0}</DoB>", item.ENDob == "" ? null : item.ENDob);
                    ItemData.AppendFormat("<Age>{0}</Age>", item.ENAge);
                    ItemData.AppendFormat("<Residing>{0}</Residing>", item.ENResidence);
                    ItemData.AppendFormat("<Porportion>{0}</Porportion>", item.ENgratuity);
                    ItemData.AppendFormat("<MaritalStatus>{0}</MaritalStatus>", item.ENMStatus);
                    ItemData.AppendFormat("<Religion>{0}</Religion>", item.ENReligion);
                    ItemData.AppendFormat("<FName>{0}</FName>", item.ENFName);
                    ItemData.AppendFormat("<GuardianName>{0}</GuardianName>", item.ENGName);
                    ItemData.AppendFormat("<GuardianAddress>{0}</GuardianAddress>", item.ENGAddress);
                    ItemData.AppendFormat("<GuardianRelation>{0}</GuardianRelation>", item.ENGRelation);

                    ItemData.Append("</NomineeItems>");
                }
                ItemData.Append("</Nominee>");
            }
            catch (Exception ex)
            {
                //XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ItemData.ToString();
        }
        #endregion 
        #endregion
    }
}
