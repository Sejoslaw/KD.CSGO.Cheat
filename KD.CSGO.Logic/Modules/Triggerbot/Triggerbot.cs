using KD.CSGO.Logic.Connections;

namespace KD.CSGO.Logic.Modules.Triggerbot
{
    public class Triggerbot : CheatModule, ITriggerbot
    {
        public Triggerbot(ICsgoConnector connector) :
            base(connector)
        {
        }

        protected override void DoWork(ICheatModule module)
        {
            this.HandleDoWork(module as ITriggerbot);
        }

        /// <summary>
        /// Actual handler for interacting with Triggerbot.
        /// </summary>
        /// <param name="triggerbot"></param>
        private void HandleDoWork(ITriggerbot triggerbot)
        {
        }
    }
}