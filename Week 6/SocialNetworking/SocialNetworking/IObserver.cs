﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworking
{
    public interface IObserver
    {
        void Update(string status);
        void Display();
    }
}
