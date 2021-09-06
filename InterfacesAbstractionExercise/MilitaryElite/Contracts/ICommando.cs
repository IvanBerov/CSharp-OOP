using System;
using System.Collections.Generic;
using System.Text;
using MilitaryElite.Contracts.NewFolder;

namespace MilitaryElite.Contracts
{
    public interface ICommando : ISpecialisedSoldier
    {
        IReadOnlyCollection<IMission> Missions { get; }

        void AddMission(IMission mission);
    }
}
