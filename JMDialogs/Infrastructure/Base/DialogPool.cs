using JMGames.JMDialogs.Pickers.DialogPickers;
using JMGames.JMDialogs.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using JMGames.Common.Enums;

namespace JMGames.JMDialogs.Infrastructure.Base
{
    /// <summary>
    /// Pool containing same type of dialogs to be selected
    /// </summary>
    public class DialogPool
    {
        public DialogTypeEnum DialogType;
        public Dialog[] Dialogs { get; set; }

        public DialogPool(DialogTypeEnum dialogType)
        {
            this.DialogType = dialogType;
        }

        public Dialog PickOne<T>() where T : IDialogPicker
        {
            return Activator.CreateInstance<T>().PickOne(this);
        }
        
        public Dialog PickOne()
        {
            return PickOne<RandomDialogPicker>();
        }
    }
}
