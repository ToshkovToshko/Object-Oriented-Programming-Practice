using MilitaryElite.Contracts;
using MilitaryElite.Enums;

namespace MilitaryElite.Models
{
    class Mission : IMission
    {
        public Mission(string codeName, MissionStates missionState)
        {
            this.CodeName = codeName;
            this.MissionStates = missionState;
        }

        public string CodeName { get; private set; }

        public MissionStates MissionStates { get; private set; }

        public void CompleteMission()
        {
            this.MissionStates = MissionStates.Finished;
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.MissionStates}";
        }
    }
}
