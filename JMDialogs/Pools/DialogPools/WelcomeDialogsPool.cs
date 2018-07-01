using JMGames.JMDialogs.Infrastructure.Base;
using JMGames.JMDialogs.DefinedItems.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using JMGames.Common.Enums;

namespace JMGames.JMDialogs.Pools.DialogPools
{
    /// <summary>
    /// Dialog pool for welcoming
    /// </summary>
    public class WelcomeDialogsPool : DialogPool
    {
        public WelcomeDialogsPool() : base(DialogTypeEnum.Greeting)
        {
            List<Dialog> dialogs = new List<Dialog>();
            dialogs.Add(new WelcomeDialog());
            this.Dialogs = dialogs.ToArray();
        }
    }
}
