using JMGames.Common.Enums;
using JMGames.JMDialogs.Pickers.DialogPickers;
using JMGames.JMDialogs.Pools.DialogPools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace JMGames.JMDialogs.Infrastructure.Base
{
    /// <summary>
    /// The dialog itself, containing a flow of dialog items
    /// </summary>
    [Serializable]
    public class Dialog
    {
        [SerializeField]
        public DialogTypeEnum Type;
        public List<DialogItem> Items { get; set; }

        public Dialog(DialogTypeEnum type)
        {
            this.Type = type;
            this.Items = new List<DialogItem>();
        }

        public void AddItem(DialogItem item)
        {
            this.Items.Add(item);
        }
    }
}
