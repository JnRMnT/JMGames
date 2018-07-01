using JMGames.Common;
using JMGames.JMDialogs.Infrastructure.Base;
using JMGames.JMDialogs.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JMGames.JMDialogs.Pickers.DialogPickers
{
    public class RandomDialogPicker : IDialogPicker
    {
        public Dialog PickOne(DialogPool pool)
        {
            if (pool.Dialogs == null || pool.Dialogs.Length == 0)
            {
                return null;
            }
            else
            {
                int randomIndex = GlobalSettings.RandomGenerator.Next(0, pool.Dialogs.Length);
                return pool.Dialogs[randomIndex];
            }
        }
    }
}
