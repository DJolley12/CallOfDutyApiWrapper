# CallOfDutyApiWrapper

An easy api-wrapper for Call Of Duty written in C#. I had a project that required the use of this, but only saw similar projects written in other languages, so I figured I would share this to save others time.

Logging In:

You will need to login through a COD account to begin pulling data, so you will need an existing account. Usage is as follows:

APICaller _apiCaller = new APICaller(-email address for account-, -password for account-) 
Constructor will automatically authenticate. You will need to reauthenticate every two hours.

--Currently WIP, will upload additional data requests when able 
