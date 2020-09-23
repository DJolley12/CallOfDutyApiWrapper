using CallOfDutyApiWrapper.Models.MatchModels.WzBrPlayerModels.WzBrLoadoutModels;

namespace CallOfDutyApiWrapper.Models
{
    public class WzBrLoadout
    {
        public WzBrPrimaryWeapon PrimaryWeapon { get; set; }
        public WzBrSecondaryWeapon SecondaryWeapon { get; set; }
        public WzBrPerks Perks { get; set; }
        public WzBrExtraPerks ExtraPerks { get; set; }
        public WzBrKillstreaks Killstreaks { get; set; }
    }
}