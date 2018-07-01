using JMGames.JMDialogs.Infrastructure.Base;
using JMGames.JMDialogs.DefinedItems.DialogItems.Acceptance;
using System.Collections.Generic;
using JMGames.Common.Enums;

namespace JMGames.JMDialogs.Pools.ResponseItemPools
{
    public class AcceptanceResponseItemsPool : ResponseItemPool
    {
        public AcceptanceResponseItemsPool() : base(DialogItemTypeEnum.Acceptance)
        {
            List<DialogResponseItem> items = new List<DialogResponseItem>();
            items.Add(new DialogResponseItem(new Okay(true)));
            this.Items = items.ToArray();
        }
    }
}
