using KD.CSGO.Logic.Connections;
using KD.CSGO.Logic.Modules.Triggerbot;

namespace KD.CSGO.Logic
{
    public class CsgoCheatLogic : ICsgoCheatLogic
    {
        public ICsgoConnector Connector { get; private set; }
        //public IWallhack Wallhack { get; private set; }
        //public IAimbot Aimbot { get; private set; }
        public ITriggerbot Triggerbot { get; private set; }

        public CsgoCheatLogic(ICsgoConnector connector)
        {
            this.Connector = connector;
            //this.Wallhack = new Wallhack(connector);
            //this.Aimbot = new Aimbot(connector);
            this.Triggerbot = new Triggerbot(connector);
        }
    }
}