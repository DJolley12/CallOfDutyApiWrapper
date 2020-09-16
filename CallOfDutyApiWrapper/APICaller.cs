using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CallOfDutyApiWrapper
{
    public class APICaller
    {
        private Setup setup { get; set; }
        private static HttpClient client { get; set; }
        private HttpWebRequest request { get; set; }
        private string cookie { get; set; }
        private DateTime lastLoggedIn { get; set; }

        public APICaller(string admin, string password)
        {
            setup = new Setup();
            setup.admin = admin;
            setup.password = password;
            client = new HttpClient();
        }

        public async Task LoginUserAsync()
        {
            var now = DateTime.UtcNow;
            var elapsedLoginTime = now - lastLoggedIn;
            if (elapsedLoginTime == null || elapsedLoginTime.TotalMinutes > 60)
            {
                string tokenUrl = $"https://profile.callofduty.com/cod/login";
                string loginUrl = $"https://profile.callofduty.com/do_login?new_SiteId=co";


                HttpResponseMessage tokenResponse = await Task.Run(() => client.GetAsync(tokenUrl));
                var tContentString = await tokenResponse.Content.ReadAsStringAsync();
                var headers = tokenResponse.Headers.FirstOrDefault(h => h.Key == "Set-Cookie");
                var cookieValue = headers.Value.FirstOrDefault(v => v.Contains("XSRF-TOKEN"));
                cookie = ParseCookie(cookieValue);
                var loginDict = new Dictionary<string, string>
                {
                    { "Cookie: ", $"XSRF_TOKEN={cookie}"},
                    { "username",  setup.admin},
                    { "password", setup.password},
                    { "remember_me", "true" },
                    { "_csrf", cookie }
                };
                var content = new FormUrlEncodedContent(loginDict);

                HttpResponseMessage authResponse = await client.PostAsync(loginUrl, content);

                var contentString = await authResponse.Content.ReadAsStringAsync();

                if (authResponse.StatusCode == HttpStatusCode.OK)
                {
                    lastLoggedIn = DateTime.UtcNow;
                }
            }
        }

        private string ParseCookie(string cookieValue)
        {
            Regex regex = new Regex("(XSRF-TOKEN=|;)");
            var cookieStrings = regex.Split(cookieValue.Trim());
            return cookieStrings[2];
        }

        private bool ReturnSuccess(string message)
        {
            if (message.Contains("success"))
            {
                return true;
            }
            return false;
        }
    }
}
