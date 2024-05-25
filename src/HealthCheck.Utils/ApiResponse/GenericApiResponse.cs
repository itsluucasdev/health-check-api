using System.Net;

namespace HealthCheck.Utils.ApiResponse;

public class GenericApiResponse(HttpStatusCode code, string message, List<string> errors)
{
    public HttpStatusCode Code { get; set; } = code;
    public string Message { get; set; } = message;
    public List<string> Errors { get; set; } = errors;
}