using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Business.Notifications;

public class Notification
{
    public Notification(string msg)
    {
        Message = msg;
    }

    public string Message { get; }
}