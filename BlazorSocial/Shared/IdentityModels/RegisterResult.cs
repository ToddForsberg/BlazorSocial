using System.Collections.Generic;

namespace BlazorSocial.Shared.IdentityModels
{
    public class RegisterResult
    {
        public bool Successful { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}