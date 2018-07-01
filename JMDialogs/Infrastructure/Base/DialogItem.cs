using JMGames.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace JMGames.JMDialogs.Infrastructure.Base
{
    /// <summary>
    /// One item within a dialog for a specific type
    /// </summary>
    [Serializable]
    public class DialogItem
    {
        [SerializeField]
        public string Title { get; set; }
        [SerializeField]
        public string Content { get; set; }
        [SerializeField]
        public DialogItemTypeEnum Type { get; set; }
        [SerializeField]
        public List<DialogResponseItem> AvailableResponses { get; set; }

        public DialogItem(string title, string content, DialogItemTypeEnum type)
        {
            this.Title = title;
            this.Content = content;
            this.Type = type;
            this.AvailableResponses = new List<DialogResponseItem>();
        }

        public void AddAvailableResponse(DialogResponseItem item)
        {
            this.AvailableResponses.Add(item);
        }
    }
}
