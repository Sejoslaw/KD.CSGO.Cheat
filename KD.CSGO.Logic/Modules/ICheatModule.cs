using KD.CSGO.Logic.Connections;

namespace KD.CSGO.Logic.Modules
{
    /// <summary>
    /// Describes the single module of cheat.
    /// For instance: Wallhack, Aimbot, Triggerbot, etc.
    /// </summary>
    public interface ICheatModule
    {
        /// <summary>
        /// Connector used to get into CS:GO process.
        /// </summary>
        ICsgoConnector Connector { get; }
        /// <summary>
        /// Indicates whether the module is running.
        /// </summary>
        bool IsOn { get; }

        /// <summary>
        /// Describes what should happen when the module is turned on.
        /// </summary>
        void TurnOn();
        /// <summary>
        /// Describes what should happen when the module is turned off.
        /// </summary>
        void TurnOff();
    }
}