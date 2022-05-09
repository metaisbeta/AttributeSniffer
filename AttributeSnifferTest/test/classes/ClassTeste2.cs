﻿using AttributeSniffer.example.customAttribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeSniffer.example.classes
{
    [Attribute1]
    class ClassTeste2
    {
        [Attribute2]
        [Attribute2]
        public void teste1()
        {
        }

        [Attribute2]
        public void teste2()
        {
        }
    }
    [Attribute1]
    class ClassTeste1
    {
        [Attribute2]
        [Attribute2]
        public void teste3()
        {
        }

        [Attribute2]
        public void teste4()
        {
        }
    }
}
