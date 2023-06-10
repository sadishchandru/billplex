﻿using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusinessLayer
{
    class EmployeeFinance: Common
    {
        public Int32 FEmpId { get; set; }
        public string FBankName { get; set; }
        public string FAddress { get; set; }
        public string FSalaryAcNo { get; set; }
        public string FPaymentMode { get; set; }
        public string FAcType { get; set; }
        public string FBankRefNo { get; set; }
        public string FWard { get; set; }
        public string FPolicyNo { get; set; }
        public string FPolicyTerm { get; set; }
        public string FLicId { get; set; }
        public string FARenewableDate { get; set; }
        public string FPfApplication { get; set; }
        public string FPfJoiningDate { get; set; }
        public string FPfNo { get; set; }
        public string FPfLastDate { get; set; }
        public string FPensionApplication { get; set; }
        public string FJoiningDate { get; set; }
        public string FEsiApplication { get; set; }
        public string FEsiJoiningDate { get; set; }
        public string FEsiNo { get; set; }
        public string FEsiLastDate { get; set; }
        public string FLocalOffice { get; set; }
        public string FEsiDespensary { get; set; }

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
                objLstDbParams.Add(new DbParams(DbType.String, 50, FEmpId, "@EmpId", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, FBankName, "@BankName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, FAddress, "@BankAddress", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 200, FSalaryAcNo, "@SalaryNo", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, FPaymentMode, "@PaymentMode", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, FAcType, "@AccountType", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, FBankRefNo, "@BankRef", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, FWard, "@Ward", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, FPolicyNo, "@PolicyNo", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, FPolicyTerm, "@PolicyTerm", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 200, FLicId, "@LicId", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, FARenewableDate, "@AnnualDate", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, FPfApplication, "@PFApplicable", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, FPfJoiningDate, "@PFJoiningDate", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, FPfNo, "@PFNo", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, FPfLastDate, "@PFLastDate", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, FPensionApplication, "@PensionApplicable", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, FJoiningDate, "@PensionJoiningDate", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, FEsiApplication, "@ESIApplicable", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, FEsiJoiningDate, "@ESIJoiningDate", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, FEsiNo, "@ESINo", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, FEsiLastDate, "@ESILastDate", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, FLocalOffice, "@ESIOffice", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, FEsiDespensary, "@ESIDispensary", ParameterDirection.Input));
                

                dbReader = ObjDbfactory.GetReader("PRO_UpdateEmployeeFinance", false, objLstDbParams);

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