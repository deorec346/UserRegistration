﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Registration
{
    internal class InvalidInputException :Exception
    {
        public InvalidInputException(string Message) : base(Message)
        {

        }
    }
}
     