using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Results;

namespace WebAPI2BoilerPlate.Exception
{
    public class GlobalExceptionHandler : ExceptionHandler
    {
        /// <summary>When overridden in a derived class, handles the exception asynchronously.</summary>
        /// <returns>A task representing the asynchronous exception handling operation.</returns>
        /// <param name="context">The exception handler context.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        public async override Task HandleAsync(ExceptionHandlerContext context, CancellationToken cancellationToken)
        {
            // Access Exception using context.Exception;
            string errorMessage = context.Exception.ToString();

            Logging.Logger.Error(context.Exception, context.Exception.Message);

            var response = context.Request.CreateResponse(HttpStatusCode.InternalServerError,
                new
                {
                    Message = errorMessage
                });
            response.Headers.Add("X-Error", context.Exception.Message);
            context.Result = new ResponseMessageResult(response);
        }
    }
}