namespace ScorePromeAPI.APIKey
{
    public class APIKeyMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly string _validApiKey;

        public APIKeyMiddleware(RequestDelegate next, string validApiKey)
        {
            //null verification
            _next = next ?? throw new ArgumentNullException(nameof(next));
            _validApiKey = validApiKey ?? throw new ArgumentNullException(nameof(validApiKey));
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var apiKey = context.Request.Headers["ApiKey"];

            if (string.IsNullOrEmpty(apiKey) || !IsValidApiKey(apiKey))
            {   
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                await context.Response.WriteAsync("Invalid APIKey");
                return;
            }

            await _next(context);
        }

        private bool IsValidApiKey(string apiKey)
        {
            return apiKey == _validApiKey;
        }
    }
}
