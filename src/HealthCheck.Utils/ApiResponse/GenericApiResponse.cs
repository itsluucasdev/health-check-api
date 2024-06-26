namespace HealthCheck.Utils.ApiResponse;

public class GenericApiResponse
{
    public string Instance { get; set; }
    public string Title { get; set; }
    public int Status { get; set; }
    private Errors Errors { get; set; } = new();
}

public class Errors
{
    public List<string> Messages { get; set; }
}