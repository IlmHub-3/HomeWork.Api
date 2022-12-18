using System;
using HomeWork.Common.Exceptions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace HomeWork.Common.Midldeware;

public class ErrorHandlerMiddleware
{
    private readonly RequestDelegate _request;
    private readonly ILogger _logger;

    public ErrorHandlerMiddleware(RequestDelegate request, ILogger logger)
	{
        request = _request;
        logger = _logger;
	}
    public async Task Invoke(HttpContext httpContext)
    {
        try
        {
            await _request(httpContext);
        }
        catch (NotFoundException e)
        {
            httpContext.Response.StatusCode = StatusCodes.Status404NotFound;
            await httpContext.Response.WriteAsync("Interval Server Error.");
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Internal error");
            throw;
        }
    }
}