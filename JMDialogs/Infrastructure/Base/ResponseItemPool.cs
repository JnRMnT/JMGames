using JMGames.JMDialogs.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using JMGames.JMDialogs.Pickers.ResponseItemPickers;
using JMGames.Common.Enums;

namespace JMGames.JMDialogs.Infrastructure.Base
{
    /// <summary>
    /// Pool containing same type of dialog items to be selected
    /// </summary>
    public class ResponseItemPool
    {
        public DialogItemTypeEnum ItemTypes;
        public DialogResponseItem[] Items { get; set; }

        public ResponseItemPool(DialogItemTypeEnum type)
        {
            this.ItemTypes = type;
        }

        public DialogResponseItem PickOne<T>() where T : IResponseItemPicker
        {
            return Activator.CreateInstance<T>().PickOne(this);
        }

        public DialogResponseItem PickOne()
        {
            return PickOne<RandomResponseItemPicker>();
        }
    }
}
