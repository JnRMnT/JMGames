using JMGames.Common.Constants.Enums;
using JMGames.Common.Entities;
using JMGames.JMEvents.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JMGames.JMEvents.Infrastructure.Base
{
    public class Event
    {
        private List<IFinishConditionProvider> finishConditions;
        public object[] RelatedObjects;
        private bool isActive;
        public static string NameResourceKey { get; set; }
        public static string TitleResourceKey { get; set; }
        public Reward[] Rewards { get; set; }
        public int RequiredAmount { get; set; }

        public Event()
        {
            this.finishConditions = new List<IFinishConditionProvider>();
            this.isActive = false;
        }

        public bool IsCompleted()
        {
            bool isCompleted = true;
            foreach (IFinishConditionProvider provider in finishConditions)
            {
                isCompleted = isCompleted && provider.IsFulfilled(this);
            }

            return isCompleted;
        }

        public void Trigger()
        {
            this.isActive = true;
        }

        public void Deactivate()
        {
            this.isActive = false;
            if (IsCompleted())
            {
                GiveRewards();
            }
        }

        private void GiveRewards()
        {

        }

        public void RecordEventAction(EventTriggerType eventTrigger, params object[] triggerParams)
        {
            foreach (IFinishConditionProvider provider in finishConditions)
            {
                provider.RecordEventAction(eventTrigger, triggerParams);
            }
        }
    }
}
