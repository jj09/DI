namespace DI.Common
{
    public class MyHttpClient : IHttpClient
    {
        public string GetHtml(string url)
        {
            var name = url.Split('/');

            return $"Hello {name[name.Length-1]}!";
        }
    }
}