using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_Module11_TelegramBot.Commands
{
    public interface IChatCommand
    {
        bool CheckMessage(string message);
    }
}
