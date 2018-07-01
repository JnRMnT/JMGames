using JMGames.JMDialogs.Infrastructure.Base;
using JMGames.JMDialogs.Pools.DialogItemPools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using JMGames.JMDialogs.Pools.ResponseItemPools;
using JMGames.Common.Enums;

namespace JMGames.JMDialogs.DefinedItems.Dialogs
{
    public class WelcomeDialog : Dialog
    {
        public WelcomeDialog() : base(DialogTypeEnum.Greeting)
        {
            this.AddItem(DialogItemFactory.GetDialogItemPool(DialogItemTypeEnum.Greeting).PickOne());
        }
    }
}
