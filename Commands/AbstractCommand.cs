using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_Module11_TelegramBot.Commands
{
    public class AbstractCommand : IChatCommand
    {
        /// <summary>
        /// 
        /// </summary>
        public string CommandText;
        public bool CheckMessage(string message)
        {
            return message == CommandText;
        }
    }
}
