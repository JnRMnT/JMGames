using JMGames.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JMGames.JMDialogs.Infrastructure.Base
{
    [Serializable]
    public class DialogResponseItem : DialogItem
    {
        public DialogResponseItem(string title, string content, DialogItemTypeEnum type) : base(title, content, type)
        {
        }

        public DialogResponseItem(DialogItem item) : base(item.Title, item.Content, item.Type)
        {

        }
    }
}
