namespace Anirudh_Task.Module
{
    public class Employee
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthday { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string PersonalEmail { get; set; }
        public string Telephone { get; set; }
        public string Cellphone { get; set; }
        public string LocationType { get; set; }
        public string LocationName { get; set; }
        public string LocalAddress { get; set; }
        public string PermanentAddress { get; set; }
        public int? IdType { get; set; }
        public string IdNo { get; set; }
        public string KRA_PIN { get; set; }
        public string NHIF_No { get; set; }
        public string NSSF { get; set; }
        public int? Country { get; set; }
        public DateTime? DateHired { get; set; }
        public DateTime? ProbationFrom { get; set; }
        public DateTime? ProbationTo { get; set; }
        public DateTime? ExitDate { get; set; }
        public int? RoleId { get; set; }
        public int? EducationLevelId { get; set; }
        public string EmployeeId { get; set; }
        public int? DepartmentId { get; set; }
        public int? DesignationItemId { get; set; }
        public string FamilyContact { get; set; }
        public double? Salary { get; set; }
        public string ProfilePicture { get; set; }
        public string Branch { get; set; }
        public string Town { get; set; }
        public string FirstGuarantor { get; set; }
        public string FirstGuarantorContact { get; set; }
        public string FirstGuarantorRelationship { get; set; }
        public string SecondGuarantor { get; set; }
        public string SecondGuarantorContact { get; set; }
        public string SecondGuarantorRelationship { get; set; }
        public string NextOfKinName { get; set; }
        public string NextOfKinContact { get; set; }
        public string NextOfKinRelationship { get; set; }
        public string SpouseName { get; set; }
        public string SpouseEmail { get; set; }
        public string SpouseMobileNumber { get; set; }
        public string Password { get; set; }
        public bool CanAccess { get; set; }
        public DateTime? EmailVerifiedAt { get; set; }
        public string RememberToken { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string ProfilePic { get; set; }
        public bool IsSuperAdmin { get; set; }
        public string Status { get; set; }
        public bool IsLoanAllowed { get; set; }
        public bool IsAdvanceAllowed { get; set; }
    }
}
