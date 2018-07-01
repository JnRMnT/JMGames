using JMGames.JMDialogs.Infrastructure.Base;
using JMGames.JMDialogs.DefinedItems.DialogItems.Greeting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using JMGames.Common.Enums;

namespace JMGames.JMDialogs.Pools.DialogItemPools
{
    public class GreetingDialogItemsPool : DialogItemPool
    {
        public GreetingDialogItemsPool() : base(DialogItemTypeEnum.Greeting)
        {
            List<DialogItem> items = new List<DialogItem>();
            items.Add(new GenericWelcome());
            items.Add(new Greetings());
            items.Add(new HelloThere());
            this.DialogItems = items.ToArray();
        }
    }
}
