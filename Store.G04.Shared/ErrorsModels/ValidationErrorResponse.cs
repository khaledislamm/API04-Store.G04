using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Store.G04.Shared.ErrorsModels
{
    public class ValidationErrorResponse
    {
        public static object StatusCodes { get; private set; }
        public int StatusCode { get; set; } = StatusCodes.Status400BadRequest;
        public string ErrorMessage { get; set; } = "Validation Errors";
        public IEnumerable<ValidationError> Errors { get; set; }
    }
}
