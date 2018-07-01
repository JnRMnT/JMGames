using JMGames.JMDialogs.Infrastructure.Base;
using JMGames.JMDialogs.DefinedItems.DialogItems.Acceptance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using JMGames.Common.Enums;

namespace JMGames.JMDialogs.Pools.DialogItemPools
{
    public class AcceptanceDialogItemsPool : DialogItemPool
    {
        public AcceptanceDialogItemsPool() : base(DialogItemTypeEnum.Acceptance)
        {
            List<DialogItem> items = new List<DialogItem>();
            items.Add(new Okay());
            this.DialogItems = items.ToArray();
        }
    }
}
