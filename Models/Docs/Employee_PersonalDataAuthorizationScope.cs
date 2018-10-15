namespace Rejupo.Models.Docs
{
    public class Employee_PersonalDataAuthorizationScope
    {
        public Employee Employee { get; set; }
        public string EmployeeId { get; set; }
        public PersonalDataAuthorizationScope Scope{ get; set; }
        public int ScopeId { get; set; }
    }

}
