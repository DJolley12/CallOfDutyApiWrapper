using CallOfDutyApiWrapper.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

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

        #region Login
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
        #endregion
        #region Warzone
        public async Task<JObject> GetMatchDataPerMatchId(string matchId, Platform platform)
        {
            if (matchId == null || matchId.Trim() == "")
            {
                return null;
            }

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var platformString = EnumSwitch.SwitchPlatform(platform);


            string getPlayerUrl = $"https://my.callofduty.com/api/papi-client/crm/cod/v2/title/mw/platform/{platformString}/fullMatch/wz/{matchId}/en";;
            var json = await MakeRequestAndReturnJsonOrNull(getPlayerUrl);
            return json;
        }

        /// <summary>
        /// Pulls JObject of overview data 
        /// </summary>
        /// <param name="gamerTag">user name for a user, needs to match the platform the id is for</param>
        /// <param name="version"></param>
        /// <param name="platform"></param>
        /// <returns>Returns deserialized JObject of overview</returns>
        public async Task<JObject> GetPlayerOverviewInfoForWarzoneAsync(string gamerTag, Enums.Version version, Platform platform)
        {
            if (gamerTag == null || gamerTag.Trim() == "")
            {
                return null;
            }

            var platformString = EnumSwitch.SwitchPlatform(platform);
            var versionString = EnumSwitch.SwitchVersion(version);

            var trimmedGamerTag = gamerTag.Trim();

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var urlEncodedUsername = HttpUtility.UrlEncode(trimmedGamerTag);
            string getPlayerUrl = $"https://my.callofduty.com/api/papi-client/stats/cod/{versionString}/title/mw/platform/{platformString}/gamer/{urlEncodedUsername}/profile/type/wz";
            var json = await MakeRequestAndReturnJsonOrNull(getPlayerUrl);
            return json;
        }  
        
        
        /// <summary>
        /// Pulls complete match history, but less detailed data. Includes match Id, start time
        /// </summary>
        /// <param name="gamerTag">Activision Id or gamerTag string</param>
        /// <param name="version">API version to use</param>
        /// <param name="platform">Platform the user id is on</param>
        /// <returns>Returns deserialized JObject</returns>
        public async Task<JObject> GetPlayerMatchDataForWarzoneFullAsync(string gamerTag, string startTime, string endTime, Enums.Version version, Platform platform)
        {
            if (gamerTag == null || gamerTag.Trim() == "")
            {
                return null;
            }

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var platformString = EnumSwitch.SwitchPlatform(platform);
            var versionString = EnumSwitch.SwitchVersion(version);
            var lookupType = "gamer";
            //if (platform == Platform.Uno)
            //{
            //    lookupType = "id";
            //}

            var trimmedGamerTag = gamerTag.Trim();

            var urlEncodedUsername = HttpUtility.UrlEncode(trimmedGamerTag);
            string getPlayerUrl = $"https://my.callofduty.com/api/papi-client/crm/cod/{versionString}/title/mw/platform/{platformString}/{lookupType}/{urlEncodedUsername}/matches/wz/start/0/end/0";
            var json = await MakeRequestAndReturnJsonOrNull(getPlayerUrl);
            return json;
        }

        ///<summary>
        ///Pulls recent 20 matches with summary data
        ///</summary>
        ///<returns>
        ///Returns deserialized JObject containing match data and summary info
        /// </returns>
        public async Task<JObject> GetLast20PlayerMatchDataForWarzoneAsync(string gamerTag, Enums.Version version, Platform platform)
        {
            if (gamerTag == null || gamerTag.Trim() == "")
            {
                return null;
            }

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var platformString = EnumSwitch.SwitchPlatform(platform);
            var versionString = EnumSwitch.SwitchVersion(version);

            var trimmedGamerTag = gamerTag.Trim();

            var urlEncodedUsername = HttpUtility.UrlEncode(trimmedGamerTag);
            string getPlayerUrl = $"https://my.callofduty.com/api/papi-client/crm/cod/{versionString}/title/mw/platform/{platformString}/gamer/{urlEncodedUsername}/matches/wz/start/0/end/0/details";
            var json = await MakeRequestAndReturnJsonOrNull(getPlayerUrl);
            return json;
        }

        ///<summary>
        ///Pulls data based on Unix Time in milliseconds
        ///</summary>
        /// <param name="gamerTag">Activision Id or gamerTag string</param>
        /// <param name="startTime">Starting time period to look up in unix time milliseconds</param>
        /// <param name="endTime">Ending time period to look up in unix time milliseconds</param>
        /// <param name="version">API version to use</param>
        /// <param name="platform">Platform the user id is on</param>
        ///<returns>
        ///Returns deserialized JObject containing match data of specified date, and summary info
        /// </returns>
        /// <exception cref="Exception">
        /// Thrown when date is not at least 13 digits, or greater than current unix dates digits in milliseconds 
        /// </exception>
        public async Task<JObject> GetPlayerMatchDataForByUnixMillisecondsDateWarzoneAsync(string gamerTag, string startTime, string endTime, Enums.Version version, Platform platform)
        {
            if (gamerTag == null || gamerTag.Trim() == "")
            {
                return null;
            }

            var unixEpochNow = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            if (startTime.Length < 13 && endTime.Length > unixEpochNow.ToString().Length || endTime.Length < 13 && endTime.Length > unixEpochNow.ToString().Length)
            {
                throw new Exception($"startTime must be unix time in milliseconds. Check your inputs for the correct number of digits: Current unix time in miliseconds is {unixEpochNow} with {unixEpochNow.ToString().Length} digits. If you want to access last 20 default use GetLast20PlayerMatchDataForWarzoneAsync()");
            }


            var platformString = EnumSwitch.SwitchPlatform(platform);
            var versionString = EnumSwitch.SwitchVersion(version);
            var lookupType = "gamer";
            //if (platform == Platform.Uno)
            //{
            //    lookupType = "id";
            //}

            var trimmedGamerTag = gamerTag.Trim();

            var urlEncodedUsername = HttpUtility.UrlEncode(trimmedGamerTag);
            string getPlayerUrl = $"https://my.callofduty.com/api/papi-client/crm/cod/{versionString}/title/mw/platform/{platformString}/{lookupType}/{urlEncodedUsername}/matches/wz/start/{startTime}/end/{endTime}/details";
            var json = await MakeRequestAndReturnJsonOrNull(getPlayerUrl);
            return json;
        }

        /// <summary>
        /// Pulls complete match history, but less detailed data. Includes match Id, start time
        /// </summary>
        /// <param name="gamerTag">Activision Id or gamerTag string</param>
        /// <param name="startTime">Starting time period to look up in unix time milliseconds</param>
        /// <param name="endTime">Ending time period to look up in unix time milliseconds</param>
        /// <param name="version">API version to use</param>
        /// <param name="platform">Platform the user id is on</param>
        /// <returns>Returns deserialized JObject</returns>
        /// <exception cref="Exception">
        /// Thrown when date is not at least 13 digits, or greater than current unix dates digits in milliseconds 
        /// </exception>
        public async Task<JObject> GetPlayerMatchDataForByUnixMillisecondsDateWarzoneFullAsync(string gamerTag, string startTime, string endTime, Enums.Version version, Platform platform)
        {
            if (gamerTag == null || gamerTag.Trim() == "")
            {
                return null;
            }

            var unixEpochNow = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            if (startTime.Length < 13 && endTime.Length > unixEpochNow.ToString().Length || endTime.Length < 13 && endTime.Length > unixEpochNow.ToString().Length)
            {
                throw new Exception($"startTime must be unix time in milliseconds. Check your inputs for the correct number of digits: Current unix time in miliseconds is {unixEpochNow} with {unixEpochNow.ToString().Length} digits.  If you want to access last 20 default use GetPlayerMatchDataForWarzoneFullAsync()");
            }

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var platformString = EnumSwitch.SwitchPlatform(platform);
            var versionString = EnumSwitch.SwitchVersion(version);
            var lookupType = "gamer";
            //if (platform == Platform.Uno)
            //{
            //    lookupType = "id";
            //}

            var trimmedGamerTag = gamerTag.Trim();

            var urlEncodedUsername = HttpUtility.UrlEncode(trimmedGamerTag);
            string getPlayerUrl = $"https://my.callofduty.com/api/papi-client/crm/cod/{versionString}/title/mw/platform/{platformString}/{lookupType}/{urlEncodedUsername}/matches/wz/start/{startTime}/end/{endTime}";
            var json = await MakeRequestAndReturnJsonOrNull(getPlayerUrl);
            return json;
        }
        #endregion

        #region Request
        private async Task<JObject> MakeRequestAndReturnJsonOrNull(string getPlayerUrl)
        {
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.GetAsync(getPlayerUrl);
            var content = await response.Content.ReadAsStringAsync();
            var responseSuccess = ReturnSuccess(content);
            if (responseSuccess)
            {
                var deserializedContent = (JObject)JsonConvert.DeserializeObject(content);
                return deserializedContent;
            }

            return null;
        }
        #endregion

        #region Helpers
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
        #endregion
    }
}
