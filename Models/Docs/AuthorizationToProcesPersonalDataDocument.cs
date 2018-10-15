using System.Collections.Generic;

namespace Rejupo.Models.Docs
{
    
    public class AuthorizationToProcesPersonalDataDocument : DocumentBase
    {
        public IEnumerable<PersonalDataAuthorization_Document_Scope> PersonalDataAuthorization_Document_Scope { get; set; }
        
    }

}
