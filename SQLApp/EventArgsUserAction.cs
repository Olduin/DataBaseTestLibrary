using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLApp
{   
    public enum FormUserAction { Save, Cansel}

    public class EventArgsUserAction : EventArgs
    {
        public FormUserAction Action {get; set;}

        public EventArgsUserAction(FormUserAction formUserAction) 
        {
            Action = formUserAction;
        }


    }
}
