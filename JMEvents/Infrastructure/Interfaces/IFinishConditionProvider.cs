using JMGames.Common.Constants.Enums;
using JMGames.JMEvents.Infrastructure.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JMGames.JMEvents.Infrastructure.Interfaces
{
    interface IFinishConditionProvider
    {
        /// <summary>
        /// Checks if finish condition is fullfilled or not
        /// </summary>
        /// <param name="relatedEvent">Instance of the related event</param>
        /// <returns>If finish condition is fullfilled</returns>
        bool IsFulfilled(Event relatedEvent);

        /// <summary>
        /// Gets Progress Information to be shown on UI
        /// </summary>
        /// <returns>an informational text such as 9/10</returns>
        string GetProgressInformation();

        /// <summary>
        /// Updates condition provider state for an event action
        /// </summary>
        /// <param name="eventTrigger">Type of event trigger happened</param>
        /// <param name="triggerParams">Params for specific event type</param>
        void RecordEventAction(EventTriggerType eventTrigger, params object[] triggerParams);
    }
}
