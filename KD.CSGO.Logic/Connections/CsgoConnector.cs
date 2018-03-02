using KD.CSGO.Logic.Configs;
using KD.CSGO.Logic.Utilities;
using System;
using System.Diagnostics;
using System.Linq;

namespace KD.CSGO.Logic.Connections
{
    public class CsgoConnector : ICsgoConnector
    {
        public Process CsgoProcess { get; private set; }
        public int OpennedProcessHandle { get; private set; }

        public ProcessModule Client { get; private set; }

        public IntPtr ClientAddress { get; private set; }

        public void ConnectToCsgo()
        {
            Process[] processes = Process.GetProcesses().Where(proc => proc.ProcessName.Equals(Settings.ProcessName)).ToArray();
            if (processes.Length == 1)
            {
                this.CsgoProcess = processes[0];
                this.OpennedProcessHandle = Memory.OpenProcess(Memory.PROCESS_ALL_ACCESS, false, this.CsgoProcess.Id);

                foreach (ProcessModule module in this.CsgoProcess.Modules)
                {
                    if (module.ModuleName.Equals(Settings.ClientModule))
                    {
                        this.Client = module;
                        this.ClientAddress = this.Client.BaseAddress;
                    }
                }
            }
            else
            {
                // TODO: What if multiple instancess of CS:GO are running ??? Maybe let user choose to which to connect ???
            }
        }
    }
}