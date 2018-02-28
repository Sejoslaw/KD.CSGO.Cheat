namespace KD.CSGO.Logic.Configs
{
    /// <summary>
    /// Contains offsets.
    /// </summary>
    public static class Offsets
    {
        public static int m_iCrosshairId => Settings.ParseConfigValue("m_iCrosshairId");
        public static int m_iHealth => Settings.ParseConfigValue("m_iHealth");
        public static int m_iTeamNum => Settings.ParseConfigValue("m_iTeamNum");
    }
}