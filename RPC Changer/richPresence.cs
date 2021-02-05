using System;
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
        public bool hasInitialized;

        private void initializeButton_Click(object sender, EventArgs e) // Initalize Button Procedure.
        {
            try
            {
                discordClient = new DiscordRpcClient(clientBox.Text); // New Discord RPC Client using the ID provided in the box.
                discordClient.Logger = new ConsoleLogger() { Level = LogLevel.Warning }; // More or less default console logger.
                discordClient.Initialize(); // Initalize the client.
            }
            catch (Exception theError) // If any errors are caught along the way:
            {
                MessageBox.Show($"Exception Caught: {theError}"); // Show a message box with the error and throw it.
                throw;                                            // ^^^
            }
            hasInitialized = true;
        }
        private void updateButton_Click(object sender, EventArgs e) // Update Button Procedure.
        {

            if (!hasInitialized) // If client has not been initalized:
            {
                MessageBox.Show("You have not initalized your RPC Client!"); // Let user know.
                return; // Return.
            }

            discordClient.SetPresence(new RichPresence() // Set the discord clients presence status. It doesn't matter if it has already been set once or not, this will work anyway.
            {
                Details = detailsBox.Text, // Set the details as the input from the details text box.
                State = stateBox.Text, // Set the state as the input from the state text box.
                Assets = new Assets() // Set the assets as a new Asset variable with the following:
                {
                    LargeImageKey = largeImageBox.Text, // Set the large image key as the input from the large image key text box.
                    LargeImageText = largeImageTextBox.Text, // Set the large image text as the input from the large image text box.
                    SmallImageKey = smallImageBox.Text // Set the small image key as the input from the small image key text box.
                }
            });
        }
    }
}
