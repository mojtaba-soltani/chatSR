﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace ChatExample_SignalR.Hubs
{
    public class chatHub : Hub
    {
        public void send(string name, string message)
        {
            //Clients.Client("8543a371-9cdd-41f8-80a7-dd32dd520b80").send();
            Clients.All.addNewMessage(name, message);
        }
    }
}