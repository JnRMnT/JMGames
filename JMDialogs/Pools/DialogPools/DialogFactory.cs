using JMGames.Common.Enums;
using JMGames.JMDialogs.Infrastructure.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JMGames.JMDialogs.Pools.DialogPools
{
    /// <summary>
    /// Main factory that selects and generates dialog pools depending on type
    /// </summary>
    public static class DialogFactory
    {
        public static DialogPool GetDialogPool(DialogTypeEnum type)
        {
            switch (type)
            {
                case DialogTypeEnum.Greeting:
                    return new WelcomeDialogsPool();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
