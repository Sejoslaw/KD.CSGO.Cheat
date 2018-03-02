using KD.CSGO.Logic.Configs;
using KD.CSGO.Logic.Connections;
using KD.CSGO.Logic.Utilities;
using System;
using System.Threading;

namespace KD.CSGO.Logic.Modules.Triggerbot
{
    public class Triggerbot : CheatModule, ITriggerbot
    {
        public int ShootingDelayMilliseconds { get; set; }
        public int EntityLoopDistance { get; set; }

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
            int client = triggerbot.Connector.ClientAddress.ToInt32();
            int localPlayer = Memory.ReadMemory(triggerbot.Connector.OpennedProcessHandle, client + Signatures.dwLocalPlayer); //Memory.Read<int>(client + Signatures.dwLocalPlayer);
            int crossHairIndex = Memory.ReadMemory(triggerbot.Connector.OpennedProcessHandle, localPlayer + Offsets.m_iCrosshairId); //Memory.Read<int>(localPlayer + Offsets.m_iCrosshairId); // Player In Cross - unique number of player

            if (crossHairIndex > 0 && crossHairIndex < 65) // Up to 64 available players on server
            {
                int crossHairEntity = Memory.ReadMemory(triggerbot.Connector.OpennedProcessHandle, client + Signatures.dwEntityList + (crossHairIndex - 1) * triggerbot.EntityLoopDistance); //Memory.Read<int>(client + Signatures.dwEntityList + (crossHairIndex - 1) * triggerbot.EntityLoopDistance); // Player at whom we are looking
                int myTeam = Memory.ReadMemory(triggerbot.Connector.OpennedProcessHandle, localPlayer + Offsets.m_iTeamNum); //Memory.Read<int>(localPlayer + Offsets.m_iTeamNum); // Our team
                int entityInCrossHairTeam = Memory.ReadMemory(triggerbot.Connector.OpennedProcessHandle, crossHairEntity + Offsets.m_iTeamNum); //Memory.Read<int>(crossHairEntity + Offsets.m_iTeamNum); // Team of Entity in our crosshair
                int entityHP = Memory.ReadMemory(triggerbot.Connector.OpennedProcessHandle, crossHairEntity + Offsets.m_iHealth); //Memory.Read<int>(crossHairEntity + Offsets.m_iHealth); // Target Entity HP

                if ((myTeam != entityInCrossHairTeam) && // Don't shoot teammates !!!
                    (entityInCrossHairTeam > 1) && // Not a spectator
                    (entityHP > 0))
                {
                    Thread.Sleep(triggerbot.ShootingDelayMilliseconds);
                    Memory.WriteMemory(triggerbot.Connector.OpennedProcessHandle, Signatures.dwForceAttack, 1);  //Memory.Write(Signatures.dwForceAttack, 1); // Start
                    Thread.Sleep(1);
                    Memory.WriteMemory(triggerbot.Connector.OpennedProcessHandle, Signatures.dwForceAttack, 4); //Memory.Write(Signatures.dwForceAttack, 4); // Stop
                }
            }
            Thread.Sleep(10);
        }
    }
}