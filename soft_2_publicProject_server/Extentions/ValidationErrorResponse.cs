namespace API.Extentions
{
    public class ValidationErrorResponse
    {
        public bool Success { get; set; }
        public object Data { get; set; }
        public string Message { get; set; }
    }
}
