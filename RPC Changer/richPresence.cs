using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Logging;

namespace RPC_Changer
{
    public partial class discordPresenceChanger : Form
    {
        public discordPresenceChanger()
        {
            InitializeComponent();
        }

        public DiscordRpcClient discordClient;

        private void initializeButton_Click(object sender, EventArgs e)
        {
            try
            {
                discordClient = new DiscordRpcClient(clientBox.Text);
                discordClient.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
                discordClient.Initialize();
            }
            catch (Exception theError)
            {
                MessageBox.Show($"Exception Caught: {theError}");
                throw;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            discordClient.SetPresence(new RichPresence()
            {
                Details = detailsBox.Text,
                State = stateBox.Text,
                Assets = new Assets()
                {
                    LargeImageKey = largeImageBox.Text,
                    LargeImageText = largeImageTextBox.Text,
                    SmallImageKey = smallImageBox.Text
                }
            });
        }
    }
}
