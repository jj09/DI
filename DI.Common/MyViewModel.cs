namespace DI.Common
{
    public class MyViewModel
    {
        private readonly IHttpClient _httpClient;
        public string MyName { get; set; }

        public MyViewModel(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public string HTML => _httpClient.GetHtml($"http://jj09.net/{MyName}");
    }
}