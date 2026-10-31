namespace DooDesch.Weapons
{
    internal static class WeaponDefinition
    {
        internal const string Name = "TeddyBatPlus";
        internal static readonly int ItemId = 1100;
        internal static bool IsGun => false;
        internal static bool IsBat => true;
        internal static bool IsReload(int skill) => false;
        internal static bool HasSkill(int skill) => skill == 10800;
    }
}
