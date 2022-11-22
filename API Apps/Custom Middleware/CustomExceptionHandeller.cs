
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
namespace API_Apps.Custom_Middleware
{
    internal class CustomException
    {
        public int StatusCode { get; set; }

        public string? Message { get; set; }
    }
    public class CustomExceptionHandeller
    {

        RequestDelegate _next;
        public CustomExceptionHandeller(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {

                context.Response.StatusCode = 500;

                string errMsg = ex.Message;

                CustomException exceptionDetails = new CustomException()
                {
                    StatusCode = context.Response.StatusCode,
                    Message = errMsg,

                };

                await context.Response.WriteAsJsonAsync(exceptionDetails);
            }
        }
    }


    public static class CustomExceptionExtension
    {
        public static void UseAppExceptionHandeller(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<CustomExceptionHandeller>();
        }
    }
}
