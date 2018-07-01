using JMGames.Common;
using JMGames.JMDialogs.Infrastructure.Base;
using JMGames.JMDialogs.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JMGames.JMDialogs.Pickers.DialogItemPickers
{
    public class RandomDialogItemPicker : IDialogItemPicker
    {
        public DialogItem PickOne(DialogItemPool pool)
        {
            if (pool.DialogItems == null || pool.DialogItems.Length == 0)
            {
                return null;
            }
            else
            {

                int randomIndex = GlobalSettings.RandomGenerator.Next(0, pool.DialogItems.Length);
                return pool.DialogItems[randomIndex];
            }
        }
    }
}
