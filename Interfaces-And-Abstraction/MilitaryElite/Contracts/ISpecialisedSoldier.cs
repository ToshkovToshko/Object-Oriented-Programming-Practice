using MilitaryElite.Enums;

namespace MilitaryElite.Contracts
{
    interface ISpecialisedSoldier : IPrivate
    {
        Corps Corps { get; }
    }
}
