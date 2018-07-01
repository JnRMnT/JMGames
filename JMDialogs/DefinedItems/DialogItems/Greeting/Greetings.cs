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
    public class Greetings : DialogItem
    {
        public Greetings(bool isResponseItem):
            base(string.Empty, GlobalSettings.GetResource("DIALOG_GREETINGS", "Greetings, traveler."), DialogItemTypeEnum.Greeting)
        {
            if (!isResponseItem)
            {
                this.AddAvailableResponse(ResponseItemFactory.GetResponseItemPool(DialogItemTypeEnum.Greeting).PickOne());
            }
        }

        public Greetings() : this(false)
        {
        }
    }
}
