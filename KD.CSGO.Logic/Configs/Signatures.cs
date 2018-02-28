namespace KD.CSGO.Logic.Configs
{
    /// <summary>
    /// Signatures.
    /// </summary>
    public static class Signatures
    {
        public static int dwEntityList => Settings.ParseConfigValue("dwEntityList");
        public static int dwForceAttack => Settings.ParseConfigValue("dwForceAttack");
        public static int dwLocalPlayer => Settings.ParseConfigValue("dwLocalPlayer");
    }
}