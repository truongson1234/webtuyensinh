namespace webtuyensinh.Middleware
{
    public class SimpleMiddleware
    {
        private readonly RequestDelegate _next;

        public SimpleMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine("hehe1");
            await _next(context);
            Console.WriteLine("hehe2");
        }
    }
}
