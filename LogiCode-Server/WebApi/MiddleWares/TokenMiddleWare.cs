namespace WebApi.MiddleWares
{
 
       public class TokenValidationMiddleware
        {
            private readonly RequestDelegate _next;

            public TokenValidationMiddleware(RequestDelegate next)
            {
                _next = next;
            }

            public async Task Invoke(HttpContext context)
            {
                var hasToken = context.Request.Headers.TryGetValue("Authorization", out var tokenHeader);

                if (!hasToken || string.IsNullOrWhiteSpace(tokenHeader))
                {
                    context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                    await context.Response.WriteAsync("Missing or invalid token");
                    return;
                }

                await _next(context); 
            }
        }

    }

