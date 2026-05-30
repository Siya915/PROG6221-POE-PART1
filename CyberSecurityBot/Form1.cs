using System;
using System.Windows.Forms;

namespace CyberSecurityBotGUI
{
    public partial class Form1 : Form
    {
        ChatBot bot = new ChatBot();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AudioPlayer.PlayGreeting();

            richTextBoxChat.AppendText("🤖 Cybersecurity Awareness Bot\n\n");
            richTextBoxChat.AppendText("Type 'exit' to close the chatbot.\n");
            richTextBoxChat.AppendText("Topics: password, privacy, phishing, scam\n\n");
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please enter a message.");
                return;
            }

            richTextBoxChat.AppendText("You: " + input + "\n");

            if (input.ToLower() == "exit")
            {
                Application.Exit();
                return;
            }

            string response = bot.GetResponse(input);

            richTextBoxChat.AppendText("Bot: " + response + "\n\n");

            textBoxInput.Clear();
        }
    }
}