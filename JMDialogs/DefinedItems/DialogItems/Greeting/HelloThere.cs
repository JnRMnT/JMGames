using JMGames.Common;
using JMGames.Common.Enums;
using JMGames.JMDialogs.Infrastructure.Base;
using JMGames.JMDialogs.Pools.ResponseItemPools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JMGames.JMDialogs.DefinedItems.DialogItems.Greeting
{
    public class HelloThere : DialogItem
    {
        public HelloThere(bool isResponseItem):
            base(string.Empty, GlobalSettings.GetResource("DIALOG_HELLOTHERE", "Well, hello there."), DialogItemTypeEnum.Greeting)
        {
            if (!isResponseItem)
            {
                this.AddAvailableResponse(ResponseItemFactory.GetResponseItemPool(DialogItemTypeEnum.Greeting).PickOne());
            }
        }

        public HelloThere() : this(false)
        {
        }
    }
}
