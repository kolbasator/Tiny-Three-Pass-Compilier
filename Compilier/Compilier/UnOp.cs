﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Compilier
{
    public class UnOp : Ast
    { 
        public int Value;
        public UnOp(string status,int value)
        {
            Status = status;
            Value = value;
        }
    }
}