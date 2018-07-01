using JMGames.Common.Enums;
using JMGames.JMDialogs.Infrastructure.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JMGames.JMDialogs.Pools.ResponseItemPools
{
    /// <summary>
    /// Main factory that selects and generates dialog item pools depending on type
    /// </summary>
    public class ResponseItemFactory
    {
        public static ResponseItemPool GetResponseItemPool(DialogItemTypeEnum type)
        {
            switch (type)
            {
                case DialogItemTypeEnum.Greeting:
                    return new GreetingResponseItemsPool();
                case DialogItemTypeEnum.Acceptance:
                    return new AcceptanceResponseItemsPool();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
