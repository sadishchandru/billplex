using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CustomerMasterInfo : Common
    {

        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string OffAddress { get; set; }
        public string State { get; set; }
        public string StatePin { get; set; }
        public string Code { get; set; }
        public string Country { get; set; }
        public string PhoneNo { get; set; }
        public string EmailID { get; set; }
        public string CDAddress { get; set; }
        public string Pin { get; set; }
        public string CDCountry { get; set; }
        public string MobileNo { get; set; }
        public string TINno { get; set; }
        public string TINDate { get; set; }
        public string CSTno { get; set; }
        public string CSTDate { get; set; }
        public string LicenseNo { get; set; }
        public string Website { get; set; }
        public object GridDetial { get; set; }

       // public string List<GridViewEntireList> GridViewEntireList { get; set; } 


        #region Update

        public void Update()
        {
            dbReader = null;
            Result = new ResultDetail();

            try
            {
                InitializeDb();

                // Calling the stored procedure for creating a new Company Profile
                List<DbParams> objLstDbParams = new List<DbParams>();
                objLstDbParams.Add(new DbParams(DbType.String, 50, Id, "@Id", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, CustomerCode, "@Code", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, CustomerName, "@Name", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 200, OffAddress, "@OffAddress", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, State, "@State", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50,  StatePin, "@Pin", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Code, "@PhonePin", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Country, "@Country", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, PhoneNo, "@OffPhone", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EmailID, "@Email", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 200,CDAddress, "@ResAddress", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Pin, "@ResPin", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, CDCountry, "@ResCountry", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, MobileNo, "@Mobile", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, TINno, "@TinNo", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, TINDate, "@TinDate", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, CSTno, "@CstNo", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, CSTDate, "@CstDate", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, LicenseNo, "@LicenseNo", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Website, "@Website", ParameterDirection.Input));

                dbReader = ObjDbfactory.GetReader("PRO_UpdateCustomerInfo", false, objLstDbParams);

                while (dbReader.Read())
                {
                    Result.Message = ToString(dbReader["ResultMessage"]);
                    Result.Status = (ResultStatus)ToInteger(dbReader["ResultNo"]);
                }


            }
            catch (Exception ex)
            {
                // Display a warning alert
               // XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                CloseConnection();
            }
        }
        #endregion

        #region GetList
        public void GetList() 
        {
            dbReader = null;
            Result = new ResultDetail();
            List<CustomerMasterInfo> GridViewEntireList = new List<CustomerMasterInfo>();
            try
            {
                InitializeDb();

                // Calling the stored procedure for creating a new Company Profile
                List<DbParams> objLstDbParams = new List<DbParams>();
                objLstDbParams.Add(new DbParams(DbType.String, 50, Id, "@Id", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, CustomerCode, "@Code", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, CustomerName, "@Name", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 200, OffAddress, "@OffAddress", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, State, "@State", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, StatePin, "@Pin", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Code, "@PhonePin", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Country, "@Country", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, PhoneNo, "@OffPhone", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EmailID, "@Email", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 200, CDAddress, "@ResAddress", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Pin, "@ResPin", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, CDCountry, "@ResCountry", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, MobileNo, "@Mobile", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, TINno, "@TinNo", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, TINDate, "@TinDate", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, CSTno, "@CstNo", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, CSTDate, "@CstDate", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, LicenseNo, "@LicenseNo", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Website, "@Website", ParameterDirection.Input));

                dbReader = ObjDbfactory.GetReader("PRO_GetCustomerInfo", false, objLstDbParams);
                GridViewEntireList = BindValues();
                while (dbReader.Read())
                {
                    Result.Message = ToString(dbReader["ResultMessage"]);
                    Result.Status = (ResultStatus)ToInteger(dbReader["ResultNo"]);
                }

            }

            catch 
            {
            
            }
        }
        #endregion

        public List<CustomerMasterInfo> BindValues() 
        {
            List<CustomerMasterInfo> GridViewEntireList = new List<CustomerMasterInfo>();

            while (dbReader.Read())
            {
                //CustomerMasterInfo GridDetail = new CustomerMasterInfo();
                //GridDetial.CustomerCode = ToString(dbReader["CustomerCode"]);
                //GridDetial.CustomerName = ToString(dbReader["CustomerName"]);
                //GridDetial.OffAddress = ToString(dbReader["OffAddress"]);
                //GridDetial.State = ToString(dbReader["State"]);
                //GridDetial.StatePin = ToString(dbReader["StatePin"]);
                //GridDetial.Code = ToString(dbReader["Code"]);
                //GridDetial.Country = ToString(dbReader["Country"]);
                //GridDetial.PhoneNo = ToString(dbReader["PhoneNo"]);
                //GridDetial.EmailID = ToString(dbReader["EmailID"]);
                //GridDetial.CDAddress = ToString(dbReader["CDAddress"]);
                //GridDetial.Pin = ToString(dbReader["Pin"]);
                //GridDetial.CDCountry = ToString(dbReader["CDCountry"]);
                //GridDetial.MobileNo = ToString(dbReader["MobileNo"]);
                //GridDetial.TINno = ToString(dbReader["TINno"]);
                //GridDetial.TINDate = ToString(dbReader["TINDate"]);
                //GridDetial.CSTno = ToString(dbReader["CSTno"]);
                //GridDetial.CSTDate = ToString(dbReader["@CSTDate"]);
                //GridDetial.LicenseNo = ToString(dbReader["@LicenseNo"]);
                //GridDetial.Website = ToString(dbReader["@Website"]);
            }

            return GridViewEntireList;

        }

        #region Delete
        public void Delete()
        {

            dbReader = null;
            Result = new ResultDetail();

            try
            {
                InitializeDb();

                // Calling the stored procedure for creating a new Company Profile
                List<DbParams> objLstDbParams = new List<DbParams>();
                objLstDbParams.Add(new DbParams(DbType.String, 50, Id, "@Id", ParameterDirection.Input));

                dbReader = ObjDbfactory.GetReader("PRO_DeleteCustomerInfo", false, objLstDbParams);

                Result.Message = "Customer Master Deleted Successfully";
                Result.Status = ResultStatus.Success;

                while (dbReader.Read())
                {
                    Result.Message = ToString(dbReader["ResultMessage"]);
                    Result.Status = (ResultStatus)ToInteger(dbReader["ResultNo"]);
                }


            }
            catch (Exception ex)
            {
                // Display a warning alert
                // XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                CloseConnection();
            }
        }


        #endregion
    }
}
