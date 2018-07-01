using JMGames.JMDialogs.Infrastructure.Base;
using JMGames.JMDialogs.DefinedItems.DialogItems.Greeting;
using System.Collections.Generic;
using JMGames.Common.Enums;

namespace JMGames.JMDialogs.Pools.ResponseItemPools
{
    public class GreetingResponseItemsPool : ResponseItemPool
    {
        public GreetingResponseItemsPool() : base(DialogItemTypeEnum.Greeting)
        {
            List<DialogResponseItem> items = new List<DialogResponseItem>();
            items.Add(new DialogResponseItem(new HelloThere(true)));
            this.Items = items.ToArray();
        }
    }
}
