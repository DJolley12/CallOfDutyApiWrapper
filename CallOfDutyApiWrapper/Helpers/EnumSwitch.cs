using System;
using CallOfDutyApiWrapper.Enums;

namespace CallOfDutyApiWrapper
{
    public static class EnumSwitch
    {
        public static string SwitchPlatform(Platform platform)
        {
            switch (platform)
            {
                case Platform.Playstation:
                    return "psn";
                case Platform.Steam:
                    return "steam";
                case Platform.Xbox:
                    return "xbl";
                case Platform.BattlePass:
                    return "battle";
                case Platform.Uno:
                    return "uno";
                default:
                    throw new Exception($"Unknown Platform {platform}");
            }
        }

        public static Platform SwitchPlatform(string platformString)
        {
            switch (platformString)
            {
                case "psn":
                    return Platform.Playstation;
                case "steam":
                    return Platform.Steam;
                case "xbl":
                    return Platform.Xbox;
                case "battle":
                    return Platform.BattlePass;
                case "uno":
                    return Platform.Uno;
                default:
                    throw new Exception($"Unknown Platform {platformString}");
            }
        }

        public static string SwitchVersion(Enums.Version version)
        {
            switch (version)
            {
                case Enums.Version.V1:
                    return "v1";
                case Enums.Version.V2:
                    return "v2";
                default:
                    throw new Exception($"Unknown Version {version}");
            }
        }

        public static Enums.Version SwitchVersion(string versionString)
        {
            switch (versionString)
            {
                case "v1":
                    return Enums.Version.V1;
                case "v2":
                    return Enums.Version.V2;
                default:
                    throw new Exception($"Unknown Version {versionString}. Versions can only be \"v1\", or \"v2\"");
            }
        }
    }
}
