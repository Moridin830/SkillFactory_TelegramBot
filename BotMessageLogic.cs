using System;
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
    internal class BotMessageLogic
    {
        private ITelegramBotClient botClient;
        private Dictionary<long, Conversation> chatList;
        private Messenger messenger;
        public BotMessageLogic(ITelegramBotClient botClient)
        {
            Messenger messenger = new Messenger();
            this.chatList = new Dictionary<long, Conversation>();
            this.botClient = botClient;
        }
        public async Task Response(MessageEventArgs e)
        {
            var Id = e.Message.Chat.Id;

            if (!chatList.ContainsKey(Id))
            {
                var newchat = new Conversation(e.Message.Chat);

                chatList.Add(Id, newchat);
            }

            var chat = chatList[Id];

            chat.AddMessage(e.Message);

            await SendTextMessage(chat);

        }
        private async Task SendTextMessage(Conversation chat)
        {
            var text = messenger.CreateTextMessage(chat);

            await botClient.SendTextMessageAsync(
            chatId: chat.GetId(), text: text);
        }
    }
}
