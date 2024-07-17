﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IFlyingRobot : IRobot
    {
        public new string GetRobotType() 
        { 
            return "I am a flying robot.";
        }
    }
}
