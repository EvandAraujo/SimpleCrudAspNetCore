using Microsoft.AspNetCore.Mvc;

namespace SimpleCrudBackEndNetCore.Crosscutting.Models
{
    public class ValidationResultDTO<T>
    {
        public ValidationProblemDetails ValidationProblemDetails { get; set; }
        public T Response { get; set; }
        public T[] ListResponse { get; set; }
    }
}
