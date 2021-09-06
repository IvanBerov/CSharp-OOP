﻿using System;
using System.Collections.Generic;
using System.Text;
using MilitaryElite.Enums;

namespace MilitaryElite.Contracts
{
    public interface IMission
    {
        string CodeName { get; }

        MissionState MissionState { get; }

        void CompleteMission();
    }
}
