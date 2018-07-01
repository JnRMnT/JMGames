using JMGames.Common;
using JMGames.JMDialogs.Infrastructure.Base;
using JMGames.JMDialogs.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JMGames.JMDialogs.Pickers.ResponseItemPickers
{
    public class RandomResponseItemPicker : IResponseItemPicker
    {
        public DialogResponseItem PickOne(ResponseItemPool pool)
        {
            if (pool.Items == null || pool.Items.Length == 0)
            {
                return null;
            }
            else
            {
                int randomIndex = GlobalSettings.RandomGenerator.Next(0, pool.Items.Length);
                return pool.Items[randomIndex];
            }
        }
    }
}
