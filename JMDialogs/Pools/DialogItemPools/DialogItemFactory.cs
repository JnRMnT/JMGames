using JMGames.Common.Enums;
using JMGames.JMDialogs.Infrastructure.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JMGames.JMDialogs.Pools.DialogItemPools
{
    /// <summary>
    /// Main factory that selects and generates dialog item pools depending on type
    /// </summary>
    public static class DialogItemFactory
    {
        public static DialogItemPool GetDialogItemPool(DialogItemTypeEnum type)
        {
            switch (type)
            {
                case DialogItemTypeEnum.Greeting:
                    return new GreetingDialogItemsPool();
                case DialogItemTypeEnum.Acceptance:
                    return new AcceptanceDialogItemsPool();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
