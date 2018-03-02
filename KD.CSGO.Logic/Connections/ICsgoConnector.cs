using System;
using System.Diagnostics;

namespace KD.CSGO.Logic.Connections
{
    /// <summary>
    /// Used to connect to CS:GO Process.
    /// </summary>
    public interface ICsgoConnector
    {
        /// <summary>
        /// CS:GO Process.
        /// </summary>
        Process CsgoProcess { get; }
        /// <summary>
        /// Id of CSGO process after it has been opened
        /// </summary>
        int OpennedProcessHandle { get; }
        /// <summary>
        /// Handler to client.dll
        /// </summary>
        ProcessModule Client { get; }
        /// <summary>
        /// Client base address.
        /// </summary>
        IntPtr ClientAddress { get; }

        /// <summary>
        /// Connect to CS:GO.
        /// </summary>
        void ConnectToCsgo();
    }
}