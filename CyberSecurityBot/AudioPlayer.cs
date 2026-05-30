using System.Media;

namespace CyberSecurityBotGUI
{
    public static class AudioPlayer
    {
        public static void PlayGreeting()
        {
            SystemSounds.Asterisk.Play();
        }
    }
}