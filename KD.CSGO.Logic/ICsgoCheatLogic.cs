using KD.CSGO.Logic.Connections;
using KD.CSGO.Logic.Modules.Triggerbot;

namespace KD.CSGO.Logic
{
    /// <summary>
    /// Contains whole logic for cheating.
    /// </summary>
    public interface ICsgoCheatLogic
    {
        ICsgoConnector Connector { get; }
        //IWallhack Wallhack { get; }
        //IAimbot Aimbot { get; }
        ITriggerbot Triggerbot { get; }
    }
}