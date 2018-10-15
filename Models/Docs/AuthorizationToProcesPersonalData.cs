using System.Collections.Generic;

namespace Rejupo.Models.Docs
{
    public class AuthorizationToProcesPersonalData : DocumentBase
    {
        
        public IEnumerable<Employee_PersonalDataAuthorizationScope> Employee_PersonalDataAuthorizationScopes { get; set; }
        
    }

}
