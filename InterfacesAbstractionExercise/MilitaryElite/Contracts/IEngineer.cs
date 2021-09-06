using System;
using System.Collections.Generic;
using System.Text;
using MilitaryElite.Contracts.NewFolder;

namespace MilitaryElite.Contracts
{
    public interface IEngineer : ISpecialisedSoldier
    {
        IReadOnlyCollection<IRepair> Repairs { get; }

        void AddRepair(IRepair repair);
    }
}
