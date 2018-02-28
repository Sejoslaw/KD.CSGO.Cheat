using KD.CSGO.Logic;
using KD.CSGO.Logic.Modules;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KD.CSGOCheat
{
    public partial class MainForm : Form
    {
        private ICsgoCheatLogic Logic { get; set; }

        public MainForm(ICsgoCheatLogic logic)
        {
            InitializeComponent();

            this.Logic = logic;
        }

        private void B_ConnectToCsgo_Click(object sender, EventArgs e)
        {
            this.Logic.Connector.ConnectToCsgo();
            if (this.Logic.Connector.CsgoProcess != null)
            {
                this.B_ConnectToCsgo.Enabled = false;

                this.TB_ConnectionStatus.ForeColor = Color.Green;
                this.TB_ConnectionStatus.Text = "Connected";
            }
            else
            {
                MessageBox.Show($"Can't connect to CS:GO process.");
            }
        }

        private void CB_Triggerbot_Active_CheckedChanged(object sender, EventArgs e)
        {
            this.StartStopModule(sender as CheckBox, this.Logic.Triggerbot);
        }

        /// <summary>
        /// Used to Start / Stop single cheat module.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="module"></param>
        private void StartStopModule(CheckBox sender, ICheatModule module)
        {
            if ((sender as CheckBox).Checked)
            {
                module.TurnOn();
            }
            else
            {
                module.TurnOff();
            }
        }
    }
}