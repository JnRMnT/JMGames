using JMGames.Common;
using JMGames.Common.Enums;
using JMGames.JMDialogs.Infrastructure.Base;
using JMGames.JMDialogs.Pools.ResponseItemPools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JMGames.JMDialogs.DefinedItems.DialogItems.Acceptance
{
    public class Okay : DialogItem
    {
        public Okay(bool isResponseItem) :
            base(string.Empty, GlobalSettings.GetResource("DIALOG_OKAY", "Okay"), DialogItemTypeEnum.Acceptance)
        {
            if (!isResponseItem)
            {
                this.AddAvailableResponse(ResponseItemFactory.GetResponseItemPool(DialogItemTypeEnum.Acceptance).PickOne());
            }
        }

        public Okay() : this(false)
        {
        }
    }
}
