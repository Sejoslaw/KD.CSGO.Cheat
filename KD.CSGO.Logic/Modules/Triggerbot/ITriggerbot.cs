namespace KD.CSGO.Logic.Modules.Triggerbot
{
    /// <summary>
    /// Triggerbot logic.
    /// </summary>
    public interface ITriggerbot : ICheatModule
    {
        /// <summary>
        /// Delay of which triggerbot will start shooting.
        /// </summary>
        int ShootingDelayMilliseconds { get; set; }
        /// <summary>
        /// Distance at which Entities are seen for Triggerbot.
        /// </summary>
        int EntityLoopDistance { get; set; }
    }
}