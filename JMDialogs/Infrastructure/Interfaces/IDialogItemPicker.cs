using JMGames.JMDialogs.Infrastructure.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JMGames.JMDialogs.Infrastructure.Interfaces
{
    public interface IDialogItemPicker
    {
        DialogItem PickOne(DialogItemPool pool);
    }
}