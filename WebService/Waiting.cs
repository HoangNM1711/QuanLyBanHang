﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Waiting" in both code and config file together.
    public class Waiting : IWaiting
    {
        public bool IsConnected()
        {
            return true;
        }
    }
}
