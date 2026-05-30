using System;
using System.Collections.Generic;

namespace CyberSecurityBotGUI
{
    public class ChatBot
    {
        private Random random = new Random();
        private string lastTopic = "";
        private string favoriteTopic = "";

        private Dictionary<string, List<string>> responses =
            new Dictionary<string, List<string>>()
        {
            {
                "password",
                new List<string>()
                {
                    "Use strong passwords with symbols and numbers.",
                    "Avoid using personal details in passwords.",
                    "Use different passwords for every account."
                }
            },

            {
                "phishing",
                new List<string>()
                {
                    "Do not click suspicious email links.",
                    "Check email addresses carefully.",
                    "Phishing scams often pretend to be trusted companies."
                }
            },

            {
                "privacy",
                new List<string>()
                {
                    "Review your privacy settings regularly.",
                    "Use two-factor authentication.",
                    "Avoid oversharing personal information online."
                }
            },

            {
                "scam",
                new List<string>()
                {
                    "Online scams often create urgency.",
                    "Never share banking details with strangers.",
                    "Be cautious of offers that seem too good to be true."
                }
            }
        };

        public string GetResponse(string input)
        {
            input = input.ToLower();

            if (input.Contains("worried"))
            {
                return "It is understandable to feel worried. Let me help you stay safe online.";
            }

            if (input.Contains("frustrated"))
            {
                return "Cybersecurity can feel overwhelming, but learning step-by-step helps.";
            }

            if (input.Contains("curious"))
            {
                return "Curiosity is good. Learning cybersecurity improves your online safety.";
            }

            if (input.Contains("i like privacy"))
            {
                favoriteTopic = "privacy";
                return "Great! I will remember that you are interested in privacy.";
            }

            if (input.Contains("tell me more") || input.Contains("another tip"))
            {
                if (responses.ContainsKey(lastTopic))
                {
                    return GetRandomResponse(lastTopic);
                }
            }

            foreach (var keyword in responses.Keys)
            {
                if (input.Contains(keyword))
                {
                    lastTopic = keyword;
                    return GetRandomResponse(keyword);
                }
            }

            if (favoriteTopic == "privacy")
            {
                return "Since you like privacy, remember to review account security settings.";
            }

            if (input.Contains("how are you"))
            {
                return "I am functioning perfectly and ready to help.";
            }

            if (input.Contains("purpose"))
            {
                return "My purpose is to teach cybersecurity awareness.";
            }

            return "I am not sure I understand. Can you try rephrasing?";
        }

        private string GetRandomResponse(string topic)
        {
            List<string> topicResponses = responses[topic];
            int index = random.Next(topicResponses.Count);
            return topicResponses[index];
        }
    }
}