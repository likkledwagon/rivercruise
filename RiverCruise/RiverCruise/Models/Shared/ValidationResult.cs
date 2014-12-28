using System.Collections.Generic;

namespace RiverCruise.Models.Shared
{
    public class ValidationResult
    {
        public bool Valid { get; set; }

        public List<string> ErrorMessages { get; set; }

        public ValidationResult()
        {
            ErrorMessages = new List<string>();
        }
    }
}