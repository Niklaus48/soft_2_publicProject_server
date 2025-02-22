using Newtonsoft.Json;

namespace API.Helpers
{
    internal class ApiResponse
    {
        public bool Success { get; set; }
        public object? Data { get; set; }
        public string? Message { get; set; }
    }

    public class Output
    {
        public static string CreateResponse(bool success, object? data, string message)
        {
            var response = new ApiResponse
            {
                Success = success,
                Data = data,
                Message = message,
            };
            return JsonConvert.SerializeObject(response);
        }

    }
}
