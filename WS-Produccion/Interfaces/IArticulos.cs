﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WS_Produccion
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IArticulos" in both code and config file together.
    [ServiceContract]
    public interface IArticulos
    {
        [OperationContract]
        void DoWork();
    }
}
