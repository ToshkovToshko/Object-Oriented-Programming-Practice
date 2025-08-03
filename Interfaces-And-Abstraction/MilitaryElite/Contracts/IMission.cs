using MilitaryElite.Enums;

namespace MilitaryElite.Contracts
{
    interface IMission
    {
        string CodeName { get; }

        MissionStates MissionStates { get; }

        void CompleteMission();
    }
}
