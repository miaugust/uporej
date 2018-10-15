namespace Rejupo.Models.Docs
{
    // relacja many 2 many - klasa wymagana do łączenia danych z tabeli
    public class PersonalDataAuthorization_Document_Scope
    {
        public AuthorizationToProcesPersonalDataDocument Document { get; set; }
        public int DocumentId { get; set; }
        public PersonalDataAuthorizationScope Scope { get; set; }
        public int ScopeId { get; set; }

        
    }

}
