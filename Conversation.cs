﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Types;

namespace SkillFactory_Module11_TelegramBot
{
    public class Conversation
    {
        private Chat telegramChat;

        private List<Message> telegramMessages;

        public Conversation(Chat chat)
        {
            telegramChat = chat;
            telegramMessages = new List<Message>();
        }
        public void AddMessage(Message message)
        {
            telegramMessages.Add(message);
        }
        public List<string> GetTextMessages()
        {
            var textMessages = new List<string>();

            foreach (var message in telegramMessages)
            {
                if(message.Text != null)
                {
                    textMessages.Add(message.Text);
                }
            }
            return textMessages;
        }
        public long GetId() => telegramChat.Id;
        public string GetLastMessage() => telegramMessages[telegramMessages.Count - 1].Text;
    }
}
