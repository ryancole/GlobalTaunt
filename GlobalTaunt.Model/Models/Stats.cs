using System.Collections.Generic;

namespace GlobalTaunt.Model
{
    public class PlayerStatsSummaryList
    {
        #region Properties

        public long SummonerId { get; set; }

        public List<PlayerStatsSummary> PlayerStatSummaries { get; set; }

        #endregion
    }

    public class PlayerStatsSummary
    {
        #region Properties

        public int Losses { get; set; }

        public long ModifyDate { get; set; }

        public string PlayerStatSummaryType { get; set; }

        public int Wins { get; set; }

        public PlayerAggregatedStats AggregatedStats { get; set; }

        #endregion
    }

    public class PlayerAggregatedStats
    {
        #region Properties

        public int totalChampionKills { get; set; }
        public int totalTurretsKilled { get; set; }
        public int totalAssists { get; set; }
        public int? totalMinionKills { get; set; }
        public int? totalNeutralMinionsKilled { get; set; }
        public int? maxChampionsKilled { get; set; }
        public int? averageNodeCapture { get; set; }
        public int? averageNodeNeutralize { get; set; }
        public int? averageTeamObjective { get; set; }
        public int? averageTotalPlayerScore { get; set; }
        public int? averageCombatPlayerScore { get; set; }
        public int? averageObjectivePlayerScore { get; set; }
        public int? averageNodeCaptureAssist { get; set; }
        public int? averageNodeNeutralizeAssist { get; set; }
        public int? maxNodeCapture { get; set; }
        public int? maxNodeNeutralize { get; set; }
        public int? maxTeamObjective { get; set; }
        public int? maxTotalPlayerScore { get; set; }
        public int? maxCombatPlayerScore { get; set; }
        public int? maxObjectivePlayerScore { get; set; }
        public int? maxNodeCaptureAssist { get; set; }
        public int? maxNodeNeutralizeAssist { get; set; }
        public int? totalNodeNeutralize { get; set; }
        public int? totalNodeCapture { get; set; }
        public int? averageChampionsKilled { get; set; }
        public int? averageNumDeaths { get; set; }
        public int? averageAssists { get; set; }
        public int? maxAssists { get; set; }

        #endregion
    }

    public enum StatsSeason
    {
        SEASON3,
        SEASON4
    }
}
