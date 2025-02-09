namespace Notespr.Web.Midleware
{
    public class LoggingMidleware
    {
        private readonly ILogger<LoggingMidleware> _logger;
        private readonly RequestDelegate _next;

        public LoggingMidleware(RequestDelegate next,ILogger<LoggingMidleware> logger)
        {
            _logger = logger;
            _next = next;
        }

        public async Task Invoke(HttpContext context) 
        {
            //инфа о запросе
            _logger.LogInformation($"Запрос: {context.Request.Method} {context.Request.Path}");

            await _next(context);
             
            //инфа о статус коде
            _logger.LogInformation($"Статус код: {context.Response.StatusCode}");

            await _next(context);

            //инфа о теле запроса 
            //context.Request.ContentLength > 0 - имеются ли данные,context.Request.Body.CanSeek - можно ли перематывать поток или считать его несколько раз
            if (context.Request.ContentLength > 0 && context.Request.Body.CanSeek)
            {
                //перемещаем указатель потока в начало данных
                context.Request.Body.Seek(0,SeekOrigin.Begin);
                //StreamReader считывает данные из боди 
                using var reader = new StreamReader(context.Request.Body);
                //приводит данные из боди в виде строки 
                var requestBody = await reader.ReadToEndAsync();
                //логигрует
                _logger.LogInformation($"Тело запроса: {requestBody}");
                //перемещаем указатель потока в начало данных
                context.Request.Body.Seek(0, SeekOrigin.Begin);
            }
        }

    }
}
