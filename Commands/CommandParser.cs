using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_Module11_TelegramBot.Commands
{
    public class CommandParser
    {
        private List<IChatCommand> Commands;
        public CommandParser()
        {
            Commands = new List<IChatCommand>();
        }
    }
}
