using System;

namespace DateHelpers
{
    public static class DateHelpers
    {
        public static DateTime ChangeUnixToUtcTimeSeconds(long timeInSeconds)
        {
            return DateTimeOffset.FromUnixTimeSeconds(timeInSeconds).UtcDateTime;
        }

        public static DateTimeOffset ChangeUnixToUnixTimeSeconds(long timeInSeconds)
        {
            return DateTimeOffset.FromUnixTimeSeconds(timeInSeconds);
        }

        public static DateTime ChangeUnixToUtcTimeMilliseconds(long timeInMilliseconds)
        {
            return DateTimeOffset.FromUnixTimeMilliseconds(timeInMilliseconds).UtcDateTime;
        }

        public static DateTimeOffset ChangeUnixToUnixTimeMilliseconds(long timeInMilliseconds)
        {
            return DateTimeOffset.FromUnixTimeMilliseconds(timeInMilliseconds);
        }

        public static long ChangeUtcToUnixTimeSeconds(DateTime utcDateTime)
        {
            var utcSpecified = DateTime.SpecifyKind(utcDateTime, DateTimeKind.Utc);
            var unixTimeInSeconds = new DateTimeOffset(utcSpecified).ToUnixTimeSeconds();
            return unixTimeInSeconds;
        }

        public static long ChangeUtcToUnixTimeSeconds(string utcDateTimeString)
        {
            DateTime.TryParse(utcDateTimeString, out DateTime dateTime);
            var utcDateTime = DateTime.SpecifyKind(dateTime, DateTimeKind.Utc);
            var unixTimeInSeconds = new DateTimeOffset(utcDateTime).ToUnixTimeSeconds();
            return unixTimeInSeconds;
        }

        public static long ChangeUtcToUnixTimeMilliseconds(DateTime utcDateTime)
        {
            var utcSpecified = DateTime.SpecifyKind(utcDateTime, DateTimeKind.Utc);
            var unixTimeInMilliseconds = new DateTimeOffset(utcSpecified).ToUnixTimeMilliseconds();
            return unixTimeInMilliseconds;
        }

        public static long ChangeUtcToUnixTimeMilliseconds(string utcDateTimeString)
        {
            DateTime.TryParse(utcDateTimeString, out DateTime dateTime);
            var utcDateTime = DateTime.SpecifyKind(dateTime, DateTimeKind.Utc);
            var unixTimeInMilliseconds = new DateTimeOffset(utcDateTime).ToUnixTimeMilliseconds();
            return unixTimeInMilliseconds;
        }

        public static DateTime DateTimeNowUTC()
        {
            return DateTime.UtcNow;
        }

        public static DateTime ConvertUtcToLocalTime(string dateTime)
        {
            DateTime.TryParse(dateTime, out DateTime _dateTime);
            var utcTime = DateTime.SpecifyKind(_dateTime, DateTimeKind.Utc);
            var localTime = utcTime.ToLocalTime();
            return localTime;
        }

        public static DateTime ConvertStringToUtcTime(string utcTimeString)
        {
            DateTime.TryParse(utcTimeString, out DateTime dateTime);
            var utcTime = DateTime.SpecifyKind(dateTime, DateTimeKind.Utc);
            return utcTime;
        }
    }
}
