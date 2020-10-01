# CallOfDutyApiWrapper

An easy api-wrapper for Call Of Duty written in C#. I had a project that required the use of this, but only saw similar projects written in other languages, so I figured I would share this to save others time.

## Logging In:

You will need to login through a COD account to begin pulling data, so you will need an existing account. Usage is as follows:

APICaller _apiCaller = new APICaller(-email address for account-, -password for account-) 
Constructor will automatically authenticate. You will need to reauthenticate every two hours.

## Pulling match data by date:

_apiCaller.GetPlayerMatchDataForByUnixMillisecondsDateWarzoneAsync(gamerTag, startTime, string endTime, Enums.Version version, Platform platform);
startTime/endTime is in unix time milliseconds. This is very important, data won't pull if not formatted correctly. Helper methods are available to make this easier.
version is the API version, there is either v1, or v2. Enum is required for this field.
platform is the platform the users gamer tag is on. Uno is for activision id. 

--Currently WIP, will upload additional data requests when able 
