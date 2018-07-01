using JMGames.JMDialogs.Pickers.DialogItemPickers;
using JMGames.JMDialogs.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using JMGames.Common.Enums;

namespace JMGames.JMDialogs.Infrastructure.Base
{
    /// <summary>
    /// Pool containing same type of dialog items to be selected
    /// </summary>
    public class DialogItemPool
    {
        public DialogItemTypeEnum ItemTypes;
        public DialogItem[] DialogItems { get; set; }

        public DialogItemPool(DialogItemTypeEnum type)
        {
            this.ItemTypes = type;
        }

        public DialogItem PickOne<T>() where T : IDialogItemPicker
        {
            return Activator.CreateInstance<T>().PickOne(this);
        }

        public DialogItem PickOne()
        {
            return PickOne<RandomDialogItemPicker>();
        }
    }
}
