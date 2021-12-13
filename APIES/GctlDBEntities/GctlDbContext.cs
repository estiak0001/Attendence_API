using System;
using APIES.Helper.ModelHelper;
using APIES.Models.Leave;
using APIES.Models.Report;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace APIES.GctlDBEntities
{
    public partial class GctlDbContext : DbContext
    {
        public GctlDbContext()
        {
        }

        public GctlDbContext(DbContextOptions<GctlDbContext> options)
            : base(options)
        {
        }
        
        [Obsolete]
        public virtual DbQuery<EmployeeJobCard> EmployeeJobCard { get; set; }
        [Obsolete]
        public virtual DbQuery<CustomID> customID { get; set; }
        [Obsolete]
        public virtual DbQuery<IsLeaveExist> IsLeaveExist { get; set; }
        public virtual DbSet<AccDurationType> AccDurationType { get; set; }
        public virtual DbSet<AccMonths> AccMonths { get; set; }
        public virtual DbSet<AccPeriod> AccPeriod { get; set; }
        public virtual DbSet<AccTrType> AccTrType { get; set; }
        public virtual DbSet<AttAbsentData> AttAbsentData { get; set; }
        public virtual DbSet<AttDetails> AttDetails { get; set; }
        public virtual DbSet<AttDetails2> AttDetails2 { get; set; }
        public virtual DbSet<AttHolidayData> AttHolidayData { get; set; }
        public virtual DbSet<AttHolidayData2> AttHolidayData2 { get; set; }
        public virtual DbSet<AttInOutData> AttInOutData { get; set; }
        public virtual DbSet<AttInOutData1> AttInOutData1 { get; set; }
        public virtual DbSet<AttLeaveData> AttLeaveData { get; set; }
        public virtual DbSet<AttMainData> AttMainData { get; set; }
        public virtual DbSet<AttTemDailyAbsentEmps> AttTemDailyAbsentEmps { get; set; }
        public virtual DbSet<AttTemDailyInOut> AttTemDailyInOut { get; set; }
        public virtual DbSet<AttTemDailyInOut2> AttTemDailyInOut2 { get; set; }
        public virtual DbSet<AttTemDailyInOutIt> AttTemDailyInOutIt { get; set; }
        public virtual DbSet<AttTemDailyLate> AttTemDailyLate { get; set; }
        public virtual DbSet<AttTemDailyPresent> AttTemDailyPresent { get; set; }
        public virtual DbSet<AttTemDasr> AttTemDasr { get; set; }
        public virtual DbSet<AttTemDasr2> AttTemDasr2 { get; set; }
        public virtual DbSet<AttTemSoatt> AttTemSoatt { get; set; }
        public virtual DbSet<AttWeekenData> AttWeekenData { get; set; }
        public virtual DbSet<AttWeekenData2> AttWeekenData2 { get; set; }
        public virtual DbSet<AttdTempDailyInOutVoyager> AttdTempDailyInOutVoyager { get; set; }
        public virtual DbSet<CaDefCountry> CaDefCountry { get; set; }
        public virtual DbSet<CaDefCurrency> CaDefCurrency { get; set; }
        public virtual DbSet<CoreAccessCode> CoreAccessCode { get; set; }
        public virtual DbSet<CoreAccessCode2> CoreAccessCode2 { get; set; }
        public virtual DbSet<CoreBankAccountInformation> CoreBankAccountInformation { get; set; }
        public virtual DbSet<CoreBranch> CoreBranch { get; set; }
        public virtual DbSet<CoreCompany> CoreCompany { get; set; }
        public virtual DbSet<CoreCompanyGroup> CoreCompanyGroup { get; set; }
        public virtual DbSet<CoreCountry> CoreCountry { get; set; }
        public virtual DbSet<CoreFavorate> CoreFavorate { get; set; }
        public virtual DbSet<CoreMenuTab> CoreMenuTab { get; set; }
        public virtual DbSet<CoreMenuTab2> CoreMenuTab2 { get; set; }
        public virtual DbSet<CoreNotice> CoreNotice { get; set; }
        public virtual DbSet<CoreNoticeHistory> CoreNoticeHistory { get; set; }
        public virtual DbSet<CorePeriodInfo> CorePeriodInfo { get; set; }
        public virtual DbSet<CorePushNotificationDeviceSetup> CorePushNotificationDeviceSetup { get; set; }
        public virtual DbSet<CoreUserInfo> CoreUserInfo { get; set; }
        public virtual DbSet<CoreUserInfo2> CoreUserInfo2 { get; set; }
        public virtual DbSet<CoreUserInfoHistory> CoreUserInfoHistory { get; set; }
        public virtual DbSet<CoreUserLog> CoreUserLog { get; set; }
        public virtual DbSet<EventTable> EventTable { get; set; }
        public virtual DbSet<Holidays> Holidays { get; set; }
        public virtual DbSet<HrmAssignedProjectMembers> HrmAssignedProjectMembers { get; set; }
        public virtual DbSet<HrmAtdAttendanceType> HrmAtdAttendanceType { get; set; }
        public virtual DbSet<HrmAtdBulkEntry> HrmAtdBulkEntry { get; set; }
        public virtual DbSet<HrmAtdCompanyLeaveSetup> HrmAtdCompanyLeaveSetup { get; set; }
        public virtual DbSet<HrmAtdCompanyWeekEnd> HrmAtdCompanyWeekEnd { get; set; }
        public virtual DbSet<HrmAtdCompanyWeekEnd1> HrmAtdCompanyWeekEnd1 { get; set; }
        public virtual DbSet<HrmAtdEmpAttendanceSetup> HrmAtdEmpAttendanceSetup { get; set; }
        public virtual DbSet<HrmAtdEmployeeLeaveSetup> HrmAtdEmployeeLeaveSetup { get; set; }
        public virtual DbSet<HrmAtdEmployeeWeekEnd> HrmAtdEmployeeWeekEnd { get; set; }
        public virtual DbSet<HrmAtdHoliday> HrmAtdHoliday { get; set; }
        public virtual DbSet<HrmAtdHolidayType> HrmAtdHolidayType { get; set; }
        public virtual DbSet<HrmAtdLeaveType> HrmAtdLeaveType { get; set; }
        public virtual DbSet<HrmAtdLeaveWithPay> HrmAtdLeaveWithPay { get; set; }
        public virtual DbSet<HrmAtdMachineData> HrmAtdMachineData { get; set; }
        public virtual DbSet<HrmAtdManual> HrmAtdManual { get; set; }
        public virtual DbSet<HrmAtdManualLateComment> HrmAtdManualLateComment { get; set; }
        public virtual DbSet<HrmAtdShift> HrmAtdShift { get; set; }
        public virtual DbSet<HrmAtdWorkingDay> HrmAtdWorkingDay { get; set; }
        public virtual DbSet<HrmAttTempDasr> HrmAttTempDasr { get; set; }
        public virtual DbSet<HrmAttdInOutData1> HrmAttdInOutData1 { get; set; }
        public virtual DbSet<HrmAttdJobCardMad> HrmAttdJobCardMad { get; set; }
        public virtual DbSet<HrmAttdJobCardMonthlyData> HrmAttdJobCardMonthlyData { get; set; }
        public virtual DbSet<HrmAttdJobCardWeeklyHoliday> HrmAttdJobCardWeeklyHoliday { get; set; }
        public virtual DbSet<HrmAttdProcessAttdLog> HrmAttdProcessAttdLog { get; set; }
        public virtual DbSet<HrmAttdProcessAttdLog1> HrmAttdProcessAttdLog1 { get; set; }
        public virtual DbSet<HrmAttdTemDsrm> HrmAttdTemDsrm { get; set; }
        public virtual DbSet<HrmAttdTemDsrm2> HrmAttdTemDsrm2 { get; set; }
        public virtual DbSet<HrmAttdTempAllData> HrmAttdTempAllData { get; set; }
        public virtual DbSet<HrmAttdTempAllDataJc> HrmAttdTempAllDataJc { get; set; }
        public virtual DbSet<HrmAttdTempAllDataMonthly> HrmAttdTempAllDataMonthly { get; set; }
        public virtual DbSet<HrmAttdTempAverageOfHours> HrmAttdTempAverageOfHours { get; set; }
        public virtual DbSet<HrmAttdTempAverageOfHoursDpSe> HrmAttdTempAverageOfHoursDpSe { get; set; }
        public virtual DbSet<HrmAttdTempCombineDandMdata> HrmAttdTempCombineDandMdata { get; set; }
        public virtual DbSet<HrmAttdTempDailyInOutBr> HrmAttdTempDailyInOutBr { get; set; }
        public virtual DbSet<HrmAttdTempDailyInOutBr2> HrmAttdTempDailyInOutBr2 { get; set; }
        public virtual DbSet<HrmAttdTempDailyInOutBr3a> HrmAttdTempDailyInOutBr3a { get; set; }
        public virtual DbSet<HrmAttdTempDailyInOutBrZo> HrmAttdTempDailyInOutBrZo { get; set; }
        public virtual DbSet<HrmAttdTempDailyInOutBrZo2> HrmAttdTempDailyInOutBrZo2 { get; set; }
        public virtual DbSet<HrmAttdTempDailyInOutBrZo3a> HrmAttdTempDailyInOutBrZo3a { get; set; }
        public virtual DbSet<HrmAttdTempDailyProcess> HrmAttdTempDailyProcess { get; set; }
        public virtual DbSet<HrmAttdTempDasrEmail> HrmAttdTempDasrEmail { get; set; }
        public virtual DbSet<HrmAttdTempExtraWorkedDay2> HrmAttdTempExtraWorkedDay2 { get; set; }
        public virtual DbSet<HrmAttdTempInOutData> HrmAttdTempInOutData { get; set; }
        public virtual DbSet<HrmAttdTempInOutDataAb> HrmAttdTempInOutDataAb { get; set; }
        public virtual DbSet<HrmAttdTempInOutDataMonthly> HrmAttdTempInOutDataMonthly { get; set; }
        public virtual DbSet<HrmAttdTempJcinitialData> HrmAttdTempJcinitialData { get; set; }
        public virtual DbSet<HrmAttdTempJobCard> HrmAttdTempJobCard { get; set; }
        public virtual DbSet<HrmAttdTempJobCard2> HrmAttdTempJobCard2 { get; set; }
        public virtual DbSet<HrmAttdTempJobCard3> HrmAttdTempJobCard3 { get; set; }
        public virtual DbSet<HrmAttdTempMachineAndManualData> HrmAttdTempMachineAndManualData { get; set; }
        public virtual DbSet<HrmAttdTempMaxAndMinDataDp> HrmAttdTempMaxAndMinDataDp { get; set; }
        public virtual DbSet<HrmAttdTempPresent1> HrmAttdTempPresent1 { get; set; }
        public virtual DbSet<HrmAttdTempPresent1st> HrmAttdTempPresent1st { get; set; }
        public virtual DbSet<HrmAttdTempSelectDataPla> HrmAttdTempSelectDataPla { get; set; }
        public virtual DbSet<HrmAttdTempSelectDataPla2> HrmAttdTempSelectDataPla2 { get; set; }
        public virtual DbSet<HrmAttdTempTotalOt> HrmAttdTempTotalOt { get; set; }
        public virtual DbSet<HrmAttdTempTotalOt2> HrmAttdTempTotalOt2 { get; set; }
        public virtual DbSet<HrmAttdTempTotalOt3> HrmAttdTempTotalOt3 { get; set; }
        public virtual DbSet<HrmAttdTimeCalBetweenInOutTime2> HrmAttdTimeCalBetweenInOutTime2 { get; set; }
        public virtual DbSet<HrmAttdTimeCalculation> HrmAttdTimeCalculation { get; set; }
        public virtual DbSet<HrmAttdTimeCalculation2> HrmAttdTimeCalculation2 { get; set; }
        public virtual DbSet<HrmAttdTimeCalculation2DpSe> HrmAttdTimeCalculation2DpSe { get; set; }
        public virtual DbSet<HrmAttdTimeCalculation2Tbsc> HrmAttdTimeCalculation2Tbsc { get; set; }
        public virtual DbSet<HrmAttdTimeCalculation2TbscDpSe> HrmAttdTimeCalculation2TbscDpSe { get; set; }
        public virtual DbSet<HrmAttdTimeCalculation2TbscF> HrmAttdTimeCalculation2TbscF { get; set; }
        public virtual DbSet<HrmAttdTimeCalculation2TbscF2> HrmAttdTimeCalculation2TbscF2 { get; set; }
        public virtual DbSet<HrmAttdTimeCalculationByEmp> HrmAttdTimeCalculationByEmp { get; set; }
        public virtual DbSet<HrmAttdTimeCalculationByEmp2> HrmAttdTimeCalculationByEmp2 { get; set; }
        public virtual DbSet<HrmAttdTimeCalculationByEmpDpSe> HrmAttdTimeCalculationByEmpDpSe { get; set; }
        public virtual DbSet<HrmAttdTimeCalculationMonthly> HrmAttdTimeCalculationMonthly { get; set; }
        public virtual DbSet<HrmAttendance> HrmAttendance { get; set; }
        public virtual DbSet<HrmCustomerCatagory> HrmCustomerCatagory { get; set; }
        public virtual DbSet<HrmCustomerType> HrmCustomerType { get; set; }
        public virtual DbSet<HrmDefBankAndNomineeInfo> HrmDefBankAndNomineeInfo { get; set; }
        public virtual DbSet<HrmDefBloodGroup> HrmDefBloodGroup { get; set; }
        public virtual DbSet<HrmDefBoardCountryName> HrmDefBoardCountryName { get; set; }
        public virtual DbSet<HrmDefCompanyInfo> HrmDefCompanyInfo { get; set; }
        public virtual DbSet<HrmDefCourseTitle> HrmDefCourseTitle { get; set; }
        public virtual DbSet<HrmDefDegree> HrmDefDegree { get; set; }
        public virtual DbSet<HrmDefDepartment> HrmDefDepartment { get; set; }
        public virtual DbSet<HrmDefDesignation> HrmDefDesignation { get; set; }
        public virtual DbSet<HrmDefDistrict> HrmDefDistrict { get; set; }
        public virtual DbSet<HrmDefDivision> HrmDefDivision { get; set; }
        public virtual DbSet<HrmDefDivisionGrade> HrmDefDivisionGrade { get; set; }
        public virtual DbSet<HrmDefDurationType> HrmDefDurationType { get; set; }
        public virtual DbSet<HrmDefEmpType> HrmDefEmpType { get; set; }
        public virtual DbSet<HrmDefEmployeeException> HrmDefEmployeeException { get; set; }
        public virtual DbSet<HrmDefEmployeeStatus> HrmDefEmployeeStatus { get; set; }
        public virtual DbSet<HrmDefExamGroupInfo> HrmDefExamGroupInfo { get; set; }
        public virtual DbSet<HrmDefExamTitle> HrmDefExamTitle { get; set; }
        public virtual DbSet<HrmDefGrade> HrmDefGrade { get; set; }
        public virtual DbSet<HrmDefIdSetup> HrmDefIdSetup { get; set; }
        public virtual DbSet<HrmDefInstitute> HrmDefInstitute { get; set; }
        public virtual DbSet<HrmDefLanguageInfo> HrmDefLanguageInfo { get; set; }
        public virtual DbSet<HrmDefLine> HrmDefLine { get; set; }
        public virtual DbSet<HrmDefLocation> HrmDefLocation { get; set; }
        public virtual DbSet<HrmDefMaritalStatus> HrmDefMaritalStatus { get; set; }
        public virtual DbSet<HrmDefMembership> HrmDefMembership { get; set; }
        public virtual DbSet<HrmDefNationality> HrmDefNationality { get; set; }
        public virtual DbSet<HrmDefOccupation> HrmDefOccupation { get; set; }
        public virtual DbSet<HrmDefProjectType> HrmDefProjectType { get; set; }
        public virtual DbSet<HrmDefRelationship> HrmDefRelationship { get; set; }
        public virtual DbSet<HrmDefReligion> HrmDefReligion { get; set; }
        public virtual DbSet<HrmDefSection> HrmDefSection { get; set; }
        public virtual DbSet<HrmDefSeparationType> HrmDefSeparationType { get; set; }
        public virtual DbSet<HrmDefSetupName> HrmDefSetupName { get; set; }
        public virtual DbSet<HrmDefSex> HrmDefSex { get; set; }
        public virtual DbSet<HrmDefShiftType> HrmDefShiftType { get; set; }
        public virtual DbSet<HrmDefTrainingTitle> HrmDefTrainingTitle { get; set; }
        public virtual DbSet<HrmDefWorkingType> HrmDefWorkingType { get; set; }
        public virtual DbSet<HrmDestinationInfo> HrmDestinationInfo { get; set; }
        public virtual DbSet<HrmEisDefCurrencyType> HrmEisDefCurrencyType { get; set; }
        public virtual DbSet<HrmEisDefDisbursementMethod> HrmEisDefDisbursementMethod { get; set; }
        public virtual DbSet<HrmEisDefEmploymentNature> HrmEisDefEmploymentNature { get; set; }
        public virtual DbSet<HrmEisReposition> HrmEisReposition { get; set; }
        public virtual DbSet<HrmEmpDigitalSignature> HrmEmpDigitalSignature { get; set; }
        public virtual DbSet<HrmEmployee> HrmEmployee { get; set; }
        public virtual DbSet<HrmEmployeeAdditionalInfo> HrmEmployeeAdditionalInfo { get; set; }
        public virtual DbSet<HrmEmployeeCashRewardEntry> HrmEmployeeCashRewardEntry { get; set; }
        public virtual DbSet<HrmEmployeeContactInfo> HrmEmployeeContactInfo { get; set; }
        public virtual DbSet<HrmEmployeeDailyMovementInfo> HrmEmployeeDailyMovementInfo { get; set; }
        public virtual DbSet<HrmEmployeeDailyMovementInfoDetailsExistingCustomer> HrmEmployeeDailyMovementInfoDetailsExistingCustomer { get; set; }
        public virtual DbSet<HrmEmployeeDailyMovementInfoDetailsExistingCustomerTemp> HrmEmployeeDailyMovementInfoDetailsExistingCustomerTemp { get; set; }
        public virtual DbSet<HrmEmployeeDailyMovementInfoDetailsOther> HrmEmployeeDailyMovementInfoDetailsOther { get; set; }
        public virtual DbSet<HrmEmployeeDailyMovementInfoDetailsOtherTemp> HrmEmployeeDailyMovementInfoDetailsOtherTemp { get; set; }
        public virtual DbSet<HrmEmployeeDailyMovementInfoNew> HrmEmployeeDailyMovementInfoNew { get; set; }
        public virtual DbSet<HrmEmployeeDocumentInfo> HrmEmployeeDocumentInfo { get; set; }
        public virtual DbSet<HrmEmployeeEducation> HrmEmployeeEducation { get; set; }
        public virtual DbSet<HrmEmployeeExp> HrmEmployeeExp { get; set; }
        public virtual DbSet<HrmEmployeeFamily> HrmEmployeeFamily { get; set; }
        public virtual DbSet<HrmEmployeeFineEntry> HrmEmployeeFineEntry { get; set; }
        public virtual DbSet<HrmEmployeeHolidayDeclaration> HrmEmployeeHolidayDeclaration { get; set; }
        public virtual DbSet<HrmEmployeeIdConfiguration> HrmEmployeeIdConfiguration { get; set; }
        public virtual DbSet<HrmEmployeeLetterOfAppreciation> HrmEmployeeLetterOfAppreciation { get; set; }
        public virtual DbSet<HrmEmployeeLetterOfWarning> HrmEmployeeLetterOfWarning { get; set; }
        public virtual DbSet<HrmEmployeeMedicalInfo> HrmEmployeeMedicalInfo { get; set; }
        public virtual DbSet<HrmEmployeeMembership> HrmEmployeeMembership { get; set; }
        public virtual DbSet<HrmEmployeeMonthlyMovementInfo> HrmEmployeeMonthlyMovementInfo { get; set; }
        public virtual DbSet<HrmEmployeeMonthlyMovementInfoDetailsExistingCustomer> HrmEmployeeMonthlyMovementInfoDetailsExistingCustomer { get; set; }
        public virtual DbSet<HrmEmployeeMonthlyMovementInfoDetailsExistingCustomerTemp> HrmEmployeeMonthlyMovementInfoDetailsExistingCustomerTemp { get; set; }
        public virtual DbSet<HrmEmployeeMonthlyMovementInfoDetailsOther> HrmEmployeeMonthlyMovementInfoDetailsOther { get; set; }
        public virtual DbSet<HrmEmployeeMonthlyMovementInfoDetailsOtherTemp> HrmEmployeeMonthlyMovementInfoDetailsOtherTemp { get; set; }
        public virtual DbSet<HrmEmployeeNomineeInfo> HrmEmployeeNomineeInfo { get; set; }
        public virtual DbSet<HrmEmployeeOfficialInfo> HrmEmployeeOfficialInfo { get; set; }
        public virtual DbSet<HrmEmployeeOfficialInfoTest> HrmEmployeeOfficialInfoTest { get; set; }
        public virtual DbSet<HrmEmployeePhoto> HrmEmployeePhoto { get; set; }
        public virtual DbSet<HrmEmployeeQualification> HrmEmployeeQualification { get; set; }
        public virtual DbSet<HrmEmployeeRecomdedTrainingInfo> HrmEmployeeRecomdedTrainingInfo { get; set; }
        public virtual DbSet<HrmEmployeeRef> HrmEmployeeRef { get; set; }
        public virtual DbSet<HrmEmployeeReferenceInfo> HrmEmployeeReferenceInfo { get; set; }
        public virtual DbSet<HrmEmployeeRewardType> HrmEmployeeRewardType { get; set; }
        public virtual DbSet<HrmEmployeeTest> HrmEmployeeTest { get; set; }
        public virtual DbSet<HrmEmployeeTraining> HrmEmployeeTraining { get; set; }
        public virtual DbSet<HrmEmployeeWeekendDeclaration> HrmEmployeeWeekendDeclaration { get; set; }
        public virtual DbSet<HrmExtraWorkingDayDeclaration> HrmExtraWorkingDayDeclaration { get; set; }
        public virtual DbSet<HrmFine> HrmFine { get; set; }
        public virtual DbSet<HrmHospitalizationInfo> HrmHospitalizationInfo { get; set; }
        public virtual DbSet<HrmIncrement> HrmIncrement { get; set; }
        public virtual DbSet<HrmJobResponsibilities> HrmJobResponsibilities { get; set; }
        public virtual DbSet<HrmJobResponsibilities1> HrmJobResponsibilities1 { get; set; }
        public virtual DbSet<HrmLeaveApplicationDays> HrmLeaveApplicationDays { get; set; }
        public virtual DbSet<HrmLeaveApplicationEntry> HrmLeaveApplicationEntry { get; set; }
        public virtual DbSet<HrmLeaveWithPay> HrmLeaveWithPay { get; set; }
        public virtual DbSet<HrmManualTimeScheduleEntry> HrmManualTimeScheduleEntry { get; set; }
        public virtual DbSet<HrmMedicalBenefit> HrmMedicalBenefit { get; set; }
        public virtual DbSet<HrmMonth> HrmMonth { get; set; }
        public virtual DbSet<HrmMovementOtherType> HrmMovementOtherType { get; set; }
        public virtual DbSet<HrmNomineePhoto> HrmNomineePhoto { get; set; }
        public virtual DbSet<HrmNomineeSignature> HrmNomineeSignature { get; set; }
        public virtual DbSet<HrmNotifyTypeInfo> HrmNotifyTypeInfo { get; set; }
        public virtual DbSet<HrmPayAbsentDeduction> HrmPayAbsentDeduction { get; set; }
        public virtual DbSet<HrmPayAdvancePay> HrmPayAdvancePay { get; set; }
        public virtual DbSet<HrmPayBonusProcess> HrmPayBonusProcess { get; set; }
        public virtual DbSet<HrmPayCalculationType> HrmPayCalculationType { get; set; }
        public virtual DbSet<HrmPayGradeName> HrmPayGradeName { get; set; }
        public virtual DbSet<HrmPayGradePayScale> HrmPayGradePayScale { get; set; }
        public virtual DbSet<HrmPayGradeRule> HrmPayGradeRule { get; set; }
        public virtual DbSet<HrmPayLateDeduction> HrmPayLateDeduction { get; set; }
        public virtual DbSet<HrmPayMonth> HrmPayMonth { get; set; }
        public virtual DbSet<HrmPayOtruleSetup> HrmPayOtruleSetup { get; set; }
        public virtual DbSet<HrmPayPayHeadName> HrmPayPayHeadName { get; set; }
        public virtual DbSet<HrmPayPromotion> HrmPayPromotion { get; set; }
        public virtual DbSet<HrmPayRules> HrmPayRules { get; set; }
        public virtual DbSet<HrmPaySalCal> HrmPaySalCal { get; set; }
        public virtual DbSet<HrmPaySalaryHead> HrmPaySalaryHead { get; set; }
        public virtual DbSet<HrmPaySalaryInfoDetails> HrmPaySalaryInfoDetails { get; set; }
        public virtual DbSet<HrmPaySalaryInformation> HrmPaySalaryInformation { get; set; }
        public virtual DbSet<HrmPaySalaryOnHold> HrmPaySalaryOnHold { get; set; }
        public virtual DbSet<HrmPayTempBonus> HrmPayTempBonus { get; set; }
        public virtual DbSet<HrmPayTempBonus2> HrmPayTempBonus2 { get; set; }
        public virtual DbSet<HrmPayTempBonus3> HrmPayTempBonus3 { get; set; }
        public virtual DbSet<HrmPayTempMonthlyReportNg5> HrmPayTempMonthlyReportNg5 { get; set; }
        public virtual DbSet<HrmPayTempOvertimeSheet> HrmPayTempOvertimeSheet { get; set; }
        public virtual DbSet<HrmPayTempOvertimeSheet2> HrmPayTempOvertimeSheet2 { get; set; }
        public virtual DbSet<HrmPayTempSsinitialData> HrmPayTempSsinitialData { get; set; }
        public virtual DbSet<HrmPayTempSsinitialData1> HrmPayTempSsinitialData1 { get; set; }
        public virtual DbSet<HrmPayTempSsinitialData2> HrmPayTempSsinitialData2 { get; set; }
        public virtual DbSet<HrmPayTempSsinitialData3> HrmPayTempSsinitialData3 { get; set; }
        public virtual DbSet<HrmPayTempSsinitialData4> HrmPayTempSsinitialData4 { get; set; }
        public virtual DbSet<HrmPayTempSsinitialData5> HrmPayTempSsinitialData5 { get; set; }
        public virtual DbSet<HrmPayTempSsinitialDataEx> HrmPayTempSsinitialDataEx { get; set; }
        public virtual DbSet<HrmPayTempSsinitialDataOut> HrmPayTempSsinitialDataOut { get; set; }
        public virtual DbSet<HrmPayTempSst1> HrmPayTempSst1 { get; set; }
        public virtual DbSet<HrmPayTempSst2> HrmPayTempSst2 { get; set; }
        public virtual DbSet<HrmPayTempSst3> HrmPayTempSst3 { get; set; }
        public virtual DbSet<HrmPayTransfer> HrmPayTransfer { get; set; }
        public virtual DbSet<HrmProjectModule> HrmProjectModule { get; set; }
        public virtual DbSet<HrmProjectPlan> HrmProjectPlan { get; set; }
        public virtual DbSet<HrmReAppointment> HrmReAppointment { get; set; }
        public virtual DbSet<HrmReleaseInfo> HrmReleaseInfo { get; set; }
        public virtual DbSet<HrmRosterScheduleEntry> HrmRosterScheduleEntry { get; set; }
        public virtual DbSet<HrmSalaryScale> HrmSalaryScale { get; set; }
        public virtual DbSet<HrmSendEmailEmployeeInfo> HrmSendEmailEmployeeInfo { get; set; }
        public virtual DbSet<HrmSeparation> HrmSeparation { get; set; }
        public virtual DbSet<HrmShortLeaveHoursMonthWise> HrmShortLeaveHoursMonthWise { get; set; }
        public virtual DbSet<HrmShortLeaveTime> HrmShortLeaveTime { get; set; }
        public virtual DbSet<HrmShortLeaveTime2> HrmShortLeaveTime2 { get; set; }
        public virtual DbSet<HrmStockType> HrmStockType { get; set; }
        public virtual DbSet<HrmSuspension> HrmSuspension { get; set; }
        public virtual DbSet<HrmTecnicalSkillType> HrmTecnicalSkillType { get; set; }
        public virtual DbSet<HrmTemIdcardGenerate> HrmTemIdcardGenerate { get; set; }
        public virtual DbSet<HrmTempAttendanceInfoDashboard> HrmTempAttendanceInfoDashboard { get; set; }
        public virtual DbSet<HrmTempAttendanceInfoDashboard2> HrmTempAttendanceInfoDashboard2 { get; set; }
        public virtual DbSet<HrmTempAttendanceInfoDashboard2Das> HrmTempAttendanceInfoDashboard2Das { get; set; }
        public virtual DbSet<HrmTempAttendanceInfoDashboardDas> HrmTempAttendanceInfoDashboardDas { get; set; }
        public virtual DbSet<HrmTempImage> HrmTempImage { get; set; }
        public virtual DbSet<HrmTempJcOt> HrmTempJcOt { get; set; }
        public virtual DbSet<HrmTempJobCard> HrmTempJobCard { get; set; }
        public virtual DbSet<HrmTempJobCard2> HrmTempJobCard2 { get; set; }
        public virtual DbSet<HrmTempJobCard3> HrmTempJobCard3 { get; set; }
        public virtual DbSet<HrmTempJobCard4> HrmTempJobCard4 { get; set; }
        public virtual DbSet<HrmTempOvertimeVoyager> HrmTempOvertimeVoyager { get; set; }
        public virtual DbSet<HrmTermsAndCondition> HrmTermsAndCondition { get; set; }
        public virtual DbSet<HrmTrainingInfo> HrmTrainingInfo { get; set; }
        public virtual DbSet<HrmWarningLetter> HrmWarningLetter { get; set; }
        public virtual DbSet<HrmWarrentyType> HrmWarrentyType { get; set; }
        public virtual DbSet<HrmWorkingDayDeclaredEmployeeInfo> HrmWorkingDayDeclaredEmployeeInfo { get; set; }
        public virtual DbSet<HrmWorkingDaySectionWiseDec> HrmWorkingDaySectionWiseDec { get; set; }
        public virtual DbSet<InvDefCompanyFor> InvDefCompanyFor { get; set; }
        public virtual DbSet<InvDefCustomerSector> InvDefCustomerSector { get; set; }
        public virtual DbSet<InvDefGatepass> InvDefGatepass { get; set; }
        public virtual DbSet<InvDefGatepassDetails> InvDefGatepassDetails { get; set; }
        public virtual DbSet<InvDefItemType> InvDefItemType { get; set; }
        public virtual DbSet<InvDefPortInfo> InvDefPortInfo { get; set; }
        public virtual DbSet<InvDefPurchaseType> InvDefPurchaseType { get; set; }
        public virtual DbSet<InvDefSalesType> InvDefSalesType { get; set; }
        public virtual DbSet<InvDefSupplierType> InvDefSupplierType { get; set; }
        public virtual DbSet<MonthlyAttData> MonthlyAttData { get; set; }
        public virtual DbSet<MonthlyEmpInfoData> MonthlyEmpInfoData { get; set; }
        public virtual DbSet<PosTermsCondition> PosTermsCondition { get; set; }
        public virtual DbSet<RmgProdDefDeliveryMethod> RmgProdDefDeliveryMethod { get; set; }
        public virtual DbSet<RmgProdDefInvSubItem2> RmgProdDefInvSubItem2 { get; set; }
        public virtual DbSet<RmgProdDefNegativeFormat> RmgProdDefNegativeFormat { get; set; }
        public virtual DbSet<RmgProdDefUnitType> RmgProdDefUnitType { get; set; }
        public virtual DbSet<RmgTermsCondition> RmgTermsCondition { get; set; }
        public virtual DbSet<RosterScheduleShift> RosterScheduleShift { get; set; }
        public virtual DbSet<SalesDefBankBranchInfo> SalesDefBankBranchInfo { get; set; }
        public virtual DbSet<SalesDefBankInfo> SalesDefBankInfo { get; set; }
        public virtual DbSet<SalesDefPaymentMode> SalesDefPaymentMode { get; set; }
        public virtual DbSet<SalesDefPaymentTerms> SalesDefPaymentTerms { get; set; }
        public virtual DbSet<SalesDefPaymentType> SalesDefPaymentType { get; set; }
        public virtual DbSet<SalesDeliveryLocation> SalesDeliveryLocation { get; set; }
        public virtual DbSet<SalesSupplierBankAccount> SalesSupplierBankAccount { get; set; }
        public virtual DbSet<SalesSupplierBankAccountTemp> SalesSupplierBankAccountTemp { get; set; }
        public virtual DbSet<TableOfDates> TableOfDates { get; set; }
        public virtual DbSet<TableOfDatesMad> TableOfDatesMad { get; set; }
        public virtual DbSet<TblReportFormat> TblReportFormat { get; set; }
        public virtual DbSet<TemAttdSummary> TemAttdSummary { get; set; }
        public virtual DbSet<TemAttdSummary2> TemAttdSummary2 { get; set; }
        public virtual DbSet<TempHrmDiagnosticTestDetails> TempHrmDiagnosticTestDetails { get; set; }
        public virtual DbSet<TempTDashboardTimeSum> TempTDashboardTimeSum { get; set; }
        public virtual DbSet<TempTDashboardTimeSumLs> TempTDashboardTimeSumLs { get; set; }
        public virtual DbSet<TempTDatesBetweenDates> TempTDatesBetweenDates { get; set; }
        public virtual DbSet<TempTDatesBetweenDates2> TempTDatesBetweenDates2 { get; set; }
        public virtual DbSet<TemtbAttJobCard> TemtbAttJobCard { get; set; }
        public virtual DbSet<TemtbAttJobCard2> TemtbAttJobCard2 { get; set; }
        public virtual DbSet<TemtbAttJobCard3> TemtbAttJobCard3 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=walton45461;Database=Att_DB;User Id=sa;password=Walton@2021;Trusted_Connection=False;MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccDurationType>(entity =>
            {
                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();

                entity.Property(e => e.Luser).IsFixedLength();
            });

            modelBuilder.Entity<AccMonths>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<AccPeriod>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();

                entity.Property(e => e.Luser).IsFixedLength();
            });

            modelBuilder.Entity<AccTrType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AttAbsentData>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AttDetails>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AttDetails2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AttHolidayData>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AttHolidayData2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AttInOutData>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AttInOutData1>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AttLeaveData>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AttMainData>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AttTemDailyAbsentEmps>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();

                entity.Property(e => e.DepartmentName).IsUnicode(false);

                entity.Property(e => e.DesignationName).IsUnicode(false);

                entity.Property(e => e.EmployeeName).IsUnicode(false);

                entity.Property(e => e.LineName).IsUnicode(false);
            });

            modelBuilder.Entity<AttTemDailyInOut>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AttTemDailyInOut2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DepartmentName).IsUnicode(false);

                entity.Property(e => e.DesignationName).IsUnicode(false);

                entity.Property(e => e.EmployeeName).IsUnicode(false);

                entity.Property(e => e.LineName).IsUnicode(false);
            });

            modelBuilder.Entity<AttTemDailyInOutIt>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();

                entity.Property(e => e.DepartmentName).IsUnicode(false);

                entity.Property(e => e.DesignationName).IsUnicode(false);

                entity.Property(e => e.EmployeeName).IsUnicode(false);

                entity.Property(e => e.LineName).IsUnicode(false);
            });

            modelBuilder.Entity<AttTemDailyLate>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();

                entity.Property(e => e.DepartmentName).IsUnicode(false);

                entity.Property(e => e.DesignationName).IsUnicode(false);

                entity.Property(e => e.EmployeeName).IsUnicode(false);

                entity.Property(e => e.LineName).IsUnicode(false);
            });

            modelBuilder.Entity<AttTemDailyPresent>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();

                entity.Property(e => e.DepartmentName).IsUnicode(false);

                entity.Property(e => e.DesignationName).IsUnicode(false);

                entity.Property(e => e.EmployeeName).IsUnicode(false);

                entity.Property(e => e.LineName).IsUnicode(false);
            });

            modelBuilder.Entity<AttTemDasr>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();

                entity.Property(e => e.DepartmentCode).IsUnicode(false);

                entity.Property(e => e.DesignationCode).IsUnicode(false);

                entity.Property(e => e.LineCode).IsUnicode(false);
            });

            modelBuilder.Entity<AttTemDasr2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();

                entity.Property(e => e.DepartmentCode).IsUnicode(false);

                entity.Property(e => e.DesignationCode).IsUnicode(false);

                entity.Property(e => e.LineCode).IsUnicode(false);
            });

            modelBuilder.Entity<AttTemSoatt>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();

                entity.Property(e => e.DepartmentName).IsUnicode(false);

                entity.Property(e => e.DivisionName).IsUnicode(false);
            });

            modelBuilder.Entity<AttWeekenData>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AttWeekenData2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AttdTempDailyInOutVoyager>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CaDefCountry>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CountryName).IsUnicode(false);

                entity.Property(e => e.Ioccode).IsUnicode(false);

                entity.Property(e => e.Isocode).IsUnicode(false);

                entity.Property(e => e.Tc).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CaDefCurrency>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Tc).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CoreAccessCode>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AccessId).ValueGeneratedOnAdd();

                entity.Property(e => e.Opstatus).IsFixedLength();
            });

            modelBuilder.Entity<CoreAccessCode2>(entity =>
            {
                entity.HasKey(e => e.AccessId)
                    .HasName("PK__Core_Acc__4130D0BF6DC0D8D2");
            });

            modelBuilder.Entity<CoreBankAccountInformation>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CoreBranch>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CoreCompany>(entity =>
            {
                entity.Property(e => e.Luser).IsFixedLength();
            });

            modelBuilder.Entity<CoreCompanyGroup>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Luser).IsFixedLength();

                entity.Property(e => e.Status).IsFixedLength();
            });

            modelBuilder.Entity<CoreCountry>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CountryCode).ValueGeneratedOnAdd();

                entity.Property(e => e.CountryId).IsUnicode(false);

                entity.Property(e => e.CountryName).IsUnicode(false);

                entity.Property(e => e.Ioccode).IsUnicode(false);

                entity.Property(e => e.Isocode).IsUnicode(false);
            });

            modelBuilder.Entity<CoreMenuTab>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Opstatus).IsFixedLength();
            });

            modelBuilder.Entity<CoreNotice>(entity =>
            {
                entity.Property(e => e.Status).IsFixedLength();
            });

            modelBuilder.Entity<CoreNoticeHistory>(entity =>
            {
                entity.HasKey(e => e.NoticeBid)
                    .HasName("PK_Core_Notice_BackUP");

                entity.Property(e => e.Status).IsFixedLength();
            });

            modelBuilder.Entity<CorePeriodInfo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Tc).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CoreUserInfo>(entity =>
            {
                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CoreUserInfoHistory>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Bid).ValueGeneratedOnAdd();

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<EventTable>(entity =>
            {
                entity.Property(e => e.ThemeColor).IsFixedLength();
            });

            modelBuilder.Entity<Holidays>(entity =>
            {
                entity.HasKey(e => e.Holidayid)
                    .HasName("HOLID");

                entity.HasIndex(e => e.Holidayname)
                    .HasName("HOLIDAYNAME")
                    .IsUnique();

                entity.Property(e => e.DeptId).HasDefaultValueSql("((1))");

                entity.Property(e => e.Holidayday).HasDefaultValueSql("((1))");

                entity.Property(e => e.Holidayname).IsUnicode(false);

                entity.Property(e => e.Minzu).IsUnicode(false);

                entity.Property(e => e.Xinbie).IsUnicode(false);
            });

            modelBuilder.Entity<HrmAssignedProjectMembers>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Tc).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAtdAttendanceType>(entity =>
            {
                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAtdBulkEntry>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAtdCompanyLeaveSetup>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CompLeaveSetupCode).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAtdCompanyWeekEnd>(entity =>
            {
                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAtdCompanyWeekEnd1>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAtdEmpAttendanceSetup>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAtdEmployeeLeaveSetup>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EmpLeaveSetupCode).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAtdEmployeeWeekEnd>(entity =>
            {
                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAtdHoliday>(entity =>
            {
                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAtdHolidayType>(entity =>
            {
                entity.HasKey(e => e.HolidayType)
                    .HasName("PK__HRM_ATD___6B0E10063F831A26");

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAtdLeaveType>(entity =>
            {
                entity.Property(e => e.LeaveTypeCode).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAtdLeaveWithPay>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();

                entity.Property(e => e.EmployeeId).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);
            });

            modelBuilder.Entity<HrmAtdMachineData>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAtdManual>(entity =>
            {
                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAtdManualLateComment>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAtdShift>(entity =>
            {
                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAtdWorkingDay>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttTempDasr>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();

                entity.Property(e => e.DepartmentCode).IsUnicode(false);

                entity.Property(e => e.DesignationCode).IsUnicode(false);

                entity.Property(e => e.LineCode).IsUnicode(false);
            });

            modelBuilder.Entity<HrmAttdInOutData1>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdJobCardMad>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdJobCardMonthlyData>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.FingerPrintId, e.Date, e.Time })
                    .HasName("UQ_HRM_Attd_JobCardMonthlyData_JC")
                    .IsUnique();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();

                entity.Property(e => e.IsSalApp)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<HrmAttdJobCardWeeklyHoliday>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdProcessAttdLog>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdProcessAttdLog1>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AttdProcessStatus).IsUnicode(false);

                entity.Property(e => e.MachineIp).IsUnicode(false);

                entity.Property(e => e.Tc).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTemDsrm>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();

                entity.Property(e => e.DepartmentCode).IsUnicode(false);

                entity.Property(e => e.DepartmentName).IsUnicode(false);
            });

            modelBuilder.Entity<HrmAttdTemDsrm2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();

                entity.Property(e => e.DepartmentCode).IsUnicode(false);

                entity.Property(e => e.DepartmentName).IsUnicode(false);
            });

            modelBuilder.Entity<HrmAttdTempAllData>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTempAllDataJc>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTempAllDataMonthly>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTempAverageOfHours>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTempAverageOfHoursDpSe>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTempCombineDandMdata>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTempDailyInOutBr>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTempDailyInOutBr2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTempDailyInOutBr3a>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTempDailyInOutBrZo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTempDailyInOutBrZo2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTempDailyInOutBrZo3a>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTempDailyProcess>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTempDasrEmail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AttStatus).IsUnicode(false);

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();

                entity.Property(e => e.DepartmentName).IsUnicode(false);

                entity.Property(e => e.DesignationName).IsUnicode(false);

                entity.Property(e => e.DivisionName).IsUnicode(false);

                entity.Property(e => e.InTime).IsUnicode(false);

                entity.Property(e => e.LineName).IsUnicode(false);

                entity.Property(e => e.Sick).IsUnicode(false);
            });

            modelBuilder.Entity<HrmAttdTempExtraWorkedDay2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTempInOutData>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTempInOutDataAb>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTempInOutDataMonthly>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTempJcinitialData>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.FingerPrintId, e.Date, e.Time })
                    .HasName("UQ_HRM_Attd_Temp_JCInitialData_JC")
                    .IsUnique();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTempJobCard>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTempJobCard2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTempJobCard3>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTempMachineAndManualData>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTempMaxAndMinDataDp>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTempPresent1>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTempPresent1st>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTempSelectDataPla>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTempSelectDataPla2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTempTotalOt>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTempTotalOt2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTempTotalOt3>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTimeCalBetweenInOutTime2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTimeCalculation>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTimeCalculation2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTimeCalculation2DpSe>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTimeCalculation2Tbsc>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTimeCalculation2TbscDpSe>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTimeCalculation2TbscF>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTimeCalculation2TbscF2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTimeCalculationByEmp>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTimeCalculationByEmp2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTimeCalculationByEmpDpSe>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttdTimeCalculationMonthly>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmAttendance>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<HrmCustomerCatagory>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmCustomerType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefBankAndNomineeInfo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefBloodGroup>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefBoardCountryName>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefCompanyInfo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefCourseTitle>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefDegree>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefDepartment>(entity =>
            {
                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefDesignation>(entity =>
            {
                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefDistrict>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefDivision>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefDivisionGrade>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefDurationType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();

                entity.Property(e => e.Luser).IsFixedLength();
            });

            modelBuilder.Entity<HrmDefEmpType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefEmployeeException>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefEmployeeStatus>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EmployeeStatusCode).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefExamGroupInfo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefExamTitle>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefGrade>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefIdSetup>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();

                entity.Property(e => e.Luser).IsFixedLength();

                entity.Property(e => e.ZeroPadding)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<HrmDefInstitute>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefLanguageInfo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.LanguageInfoCode).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefLine>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefLocation>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefMaritalStatus>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefMembership>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefNationality>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();

                entity.Property(e => e.Nationality).IsUnicode(false);
            });

            modelBuilder.Entity<HrmDefOccupation>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefProjectType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Tc).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefRelationship>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefReligion>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefSection>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefSeparationType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.SeparationTypeCode).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefSetupName>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();

                entity.Property(e => e.Luser).IsFixedLength();
            });

            modelBuilder.Entity<HrmDefSex>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefShiftType>(entity =>
            {
                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefTrainingTitle>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmDefWorkingType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();

                entity.Property(e => e.Luser).IsFixedLength();
            });

            modelBuilder.Entity<HrmDestinationInfo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEisDefCurrencyType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Tc).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEisDefDisbursementMethod>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Tc).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEisDefEmploymentNature>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Tc).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEisReposition>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Tc).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmpDigitalSignature>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__HRM_Empl__7AD04FF1DB4E7C05");

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeAdditionalInfo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeCashRewardEntry>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeContactInfo>(entity =>
            {
                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeDailyMovementInfo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeDailyMovementInfoDetailsExistingCustomer>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeDailyMovementInfoDetailsExistingCustomerTemp>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeDailyMovementInfoDetailsOther>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeDailyMovementInfoDetailsOtherTemp>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeDailyMovementInfoNew>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeDocumentInfo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeEducation>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeExp>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeFamily>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeFineEntry>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeHolidayDeclaration>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeIdConfiguration>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();

                entity.Property(e => e.Luser).IsFixedLength();
            });

            modelBuilder.Entity<HrmEmployeeLetterOfAppreciation>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeLetterOfWarning>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeMedicalInfo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeMembership>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeMonthlyMovementInfo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeMonthlyMovementInfoDetailsExistingCustomer>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeMonthlyMovementInfoDetailsExistingCustomerTemp>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeMonthlyMovementInfoDetailsOther>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeMonthlyMovementInfoDetailsOtherTemp>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeNomineeInfo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeOfficialInfo>(entity =>
            {
                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeOfficialInfoTest>(entity =>
            {
                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeePhoto>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeQualification>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeRecomdedTrainingInfo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeRef>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeReferenceInfo>(entity =>
            {
                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeRewardType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeTest>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__HRM_Empl__7AD04FF177B03EA5");

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeTraining>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmEmployeeWeekendDeclaration>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Tc).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmExtraWorkingDayDeclaration>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmFine>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FineCode).ValueGeneratedOnAdd();

                entity.Property(e => e.IsReceived)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<HrmHospitalizationInfo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmIncrement>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Tc).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmJobResponsibilities>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmJobResponsibilities1>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.JobResponsibilitiesCode).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmLeaveApplicationDays>(entity =>
            {
                entity.HasKey(e => e.AutoId)
                    .HasName("PK__HRM_Leav__385EFE48464023E6");

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmLeaveApplicationEntry>(entity =>
            {
                entity.Property(e => e.FirstOrSecondHalf)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HalfDay)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LeaveAppEntryCode).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmLeaveWithPay>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EmployeeId).IsUnicode(false);

                entity.Property(e => e.LeaveWithPayCode).ValueGeneratedOnAdd();

                entity.Property(e => e.LeaveWithPayId).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);
            });

            modelBuilder.Entity<HrmManualTimeScheduleEntry>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmMedicalBenefit>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmMonth>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmMovementOtherType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmNomineePhoto>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmNomineeSignature>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmNotifyTypeInfo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmPayAbsentDeduction>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AbsentDeductionCode).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmPayAdvancePay>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AdvancePayCode).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmPayBonusProcess>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BonusProcessCode).ValueGeneratedOnAdd();

                entity.Property(e => e.IsActive)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<HrmPayCalculationType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CalculationTypeCode).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmPayGradeName>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.GradeNameCode).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmPayGradePayScale>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.GradePayScaleCode).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmPayGradeRule>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.GradeRuleCode).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmPayLateDeduction>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.LateDeductionCode).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmPayMonth>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.MonthName).IsUnicode(false);
            });

            modelBuilder.Entity<HrmPayOtruleSetup>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.OvertimeRuleCode).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmPayPayHeadName>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.PayHeadNameCode).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmPayPromotion>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.PromotionCode).ValueGeneratedOnAdd();

                entity.Property(e => e.Remark).IsUnicode(false);
            });

            modelBuilder.Entity<HrmPayRules>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.RuleDefinition).IsUnicode(false);

                entity.Property(e => e.RuleName).IsUnicode(false);

                entity.Property(e => e.Shname).IsUnicode(false);

                entity.Property(e => e.StateRemarks).IsUnicode(false);

                entity.Property(e => e.StateStatus).IsUnicode(false);
            });

            modelBuilder.Entity<HrmPaySalCal>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<HrmPaySalaryHead>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<HrmPaySalaryInfoDetails>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.SalaryInfoDetailsCode).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmPaySalaryInformation>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<HrmPaySalaryOnHold>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.SalaryOnHoldCode).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmPayTempBonus>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmPayTempBonus2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmPayTempBonus3>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmPayTempMonthlyReportNg5>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.EmployeeId, e.MonthName, e.YearName, e.IsSalApp })
                    .HasName("UQ_HRM_Pay_Temp_MonthlyReport_NG_5_MRD")
                    .IsUnique();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();

                entity.Property(e => e.IsSalApp)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<HrmPayTempOvertimeSheet>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmPayTempOvertimeSheet2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmPayTempSsinitialData>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmPayTempSsinitialData1>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmPayTempSsinitialData2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmPayTempSsinitialData3>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmPayTempSsinitialData4>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmPayTempSsinitialData5>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.EmployeeId, e.MonthName, e.YearName, e.IsSalApp })
                    .HasName("UQ_HRM_Pay_Temp_SSInitialData_5_MSD")
                    .IsUnique();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();

                entity.Property(e => e.IsSalApp)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<HrmPayTempSsinitialDataEx>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmPayTempSsinitialDataOut>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmPayTempSst1>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmPayTempSst2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmPayTempSst3>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmPayTransfer>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Remark).IsUnicode(false);

                entity.Property(e => e.TransferCode).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmProjectModule>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Tc).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmProjectPlan>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Tc).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmReAppointment>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ReAppointmentCode).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmReleaseInfo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IsPaid)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReleaseCode).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmRosterScheduleEntry>(entity =>
            {
                entity.Property(e => e.Tc).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmSalaryScale>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmSendEmailEmployeeInfo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Tc).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmSeparation>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IsPaid)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SeparationCode).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmShortLeaveHoursMonthWise>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmShortLeaveTime>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmShortLeaveTime2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmStockType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmSuspension>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IsContinuing)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SuspensionCode).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmTecnicalSkillType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmTemIdcardGenerate>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Tc).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmTempAttendanceInfoDashboard>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmTempAttendanceInfoDashboard2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmTempAttendanceInfoDashboard2Das>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmTempAttendanceInfoDashboardDas>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmTempImage>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmTempJcOt>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmTempJobCard>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmTempJobCard2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmTempJobCard3>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmTempJobCard4>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<HrmTempOvertimeVoyager>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmTermsAndCondition>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmTrainingInfo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmWarningLetter>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.WarningLetterEntryCode).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmWarrentyType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmWorkingDayDeclaredEmployeeInfo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HrmWorkingDaySectionWiseDec>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<InvDefCompanyFor>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CompanyForId).IsUnicode(false);

                entity.Property(e => e.CompanyForName).IsUnicode(false);

                entity.Property(e => e.Tc).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<InvDefCustomerSector>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<InvDefGatepass>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<InvDefGatepassDetails>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<InvDefItemType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<InvDefPortInfo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<InvDefPurchaseType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<InvDefSalesType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<InvDefSupplierType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MonthlyAttData>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MonthlyEmpInfoData>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.EmployeeId, e.MonthName, e.YearName, e.IsSalApp })
                    .HasName("UQ_MonthlyEmpInfoData_MSD")
                    .IsUnique();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();

                entity.Property(e => e.IsSalApp)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PosTermsCondition>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Tc).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RmgProdDefDeliveryMethod>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Tc).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RmgProdDefInvSubItem2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.SubItem2Name).IsUnicode(false);

                entity.Property(e => e.Tc).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RmgProdDefNegativeFormat>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Tc).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RmgProdDefUnitType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ShortName).IsUnicode(false);

                entity.Property(e => e.Tc).ValueGeneratedOnAdd();

                entity.Property(e => e.UnitTypId).IsUnicode(false);

                entity.Property(e => e.UnitTypeName).IsUnicode(false);
            });

            modelBuilder.Entity<RmgTermsCondition>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Tc).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RosterScheduleShift>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SalesDefBankBranchInfo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Tc).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SalesDefBankInfo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BankCode).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SalesDefPaymentMode>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<SalesDefPaymentTerms>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Tc).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SalesDefPaymentType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.PaymentType).IsUnicode(false);

                entity.Property(e => e.PaymentTypeId).IsUnicode(false);

                entity.Property(e => e.ShortName).IsUnicode(false);

                entity.Property(e => e.Tc).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SalesSupplierBankAccount>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SalesSupplierBankAccountTemp>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TableOfDates>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<TableOfDatesMad>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<TblReportFormat>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TemAttdSummary>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();

                entity.Property(e => e.DepartmentCode).IsUnicode(false);

                entity.Property(e => e.DepartmentName).IsUnicode(false);
            });

            modelBuilder.Entity<TemAttdSummary2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();

                entity.Property(e => e.DepartmentCode).IsUnicode(false);

                entity.Property(e => e.DepartmentName).IsUnicode(false);
            });

            modelBuilder.Entity<TempHrmDiagnosticTestDetails>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TempTDashboardTimeSum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TempTDashboardTimeSumLs>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TempTDatesBetweenDates>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<TempTDatesBetweenDates2>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<TemtbAttJobCard>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TemtbAttJobCard2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TemtbAttJobCard3>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
