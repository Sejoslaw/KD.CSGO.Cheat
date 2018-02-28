using KD.CSGO.Logic.Connections;
using System.Threading;

namespace KD.CSGO.Logic.Modules
{
    public abstract class CheatModule : ICheatModule
    {
        /// <summary>
        /// By default all modules should be disabled.
        /// </summary>
        public bool IsOn { get; protected set; }

        public ICsgoConnector Connector { get; private set; }

        protected Thread workingThread;

        public CheatModule(ICsgoConnector connector)
        {
            this.Connector = connector;
        }

        public virtual void TurnOff()
        {
            this.IsOn = false;
            this.workingThread?.Abort();
            this.workingThread = null;
        }

        public virtual void TurnOn()
        {
            this.IsOn = true;
            this.workingThread = new Thread(() => this.StartCheatModule(this));
            this.workingThread.Start();
        }

        private void StartCheatModule(ICheatModule module)
        {
            while (Thread.CurrentThread.IsAlive)
            {
                this.DoWork(module);
            }
        }

        protected abstract void DoWork(ICheatModule module);
    }
}