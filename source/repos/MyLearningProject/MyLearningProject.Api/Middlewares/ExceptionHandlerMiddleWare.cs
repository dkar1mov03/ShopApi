using MyLearningProject.Api.Models;
using MyLearningProject.Service.Exceptions;
using System.Net.Mail;

namespace MyLearningProject.Api.Middlewares
{
    public class ExceptionHandlerMiddleWare
    {
        private readonly RequestDelegate next;
        private readonly ILogger<ExceptionHandlerMiddleWare> logger;
        public ExceptionHandlerMiddleWare(RequestDelegate next)
        {
            this.next = next;
        }
        public async void Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (LearningException ex)
            {

                context.Response.StatusCode = ex.StatusCode;
                await context.Response.WriteAsJsonAsync(new Responce
                {
                    StatusCode = ex.StatusCode,
                    Message = ex.Message
                });

            }
            catch (Exception ex)
            {
                this.logger.LogError(ex.Message);
                context.Response.StatusCode = 500;
                await context.Response.WriteAsJsonAsync(new Responce
                {
                    StatusCode = 500,
                    Message = ex.Message
                });
            }
        }
    }
}
