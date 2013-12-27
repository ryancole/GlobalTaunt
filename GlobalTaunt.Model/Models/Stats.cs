﻿using System.Collections.Generic;

namespace GlobalTaunt.Model
{
    public class PlayerRankedStats
    {
        #region Properties

        public long ModifyDate { get; set; }

        public long SummonerId { get; set; }

        public List<PlayerRankedChampionStats> Champions { get; set; }

        #endregion
    }

    public class PlayerRankedChampionStats
    {
        #region Properties

        public int Id { get; set; }

        public string Name { get; set; }

        public PlayerRankedChampionAggregatedStats Stats { get; set; }

        #endregion
    }

    public class PlayerRankedChampionAggregatedStats
    {
        #region Properties

        public int totalSessionsPlayed { get; set; }
        public int totalSessionsLost { get; set; }
        public int totalSessionsWon { get; set; }
        public int totalChampionKills { get; set; }
        public int totalDamageDealt { get; set; }
        public int totalDamageTaken { get; set; }
        public int mostChampionKillsPerSession { get; set; }
        public int totalMinionKills { get; set; }
        public int totalDoubleKills { get; set; }
        public int totalTripleKills { get; set; }
        public int totalQuadraKills { get; set; }
        public int totalPentaKills { get; set; }
        public int totalUnrealKills { get; set; }
        public int totalGoldEarned { get; set; }
        public int mostSpellsCast { get; set; }
        public int totalTurretsKilled { get; set; }
        public int totalPhysicalDamageDealt { get; set; }
        public int totalMagicDamageDealt { get; set; }
        public int totalFirstBlood { get; set; }
        public int totalAssists { get; set; }
        public int maxChampionsKilled { get; set; }
        public int? killingSpree { get; set; }
        public int? totalNeutralMinionsKilled { get; set; }
        public int? totalHeal { get; set; }
        public int? maxLargestKillingSpree { get; set; }
        public int? maxLargestCriticalStrike { get; set; }
        public int? maxTimePlayed { get; set; }
        public int? maxTimeSpentLiving { get; set; }
        public int? normalGamesPlayed { get; set; }
        public int? rankedSoloGamesPlayed { get; set; }
        public int? rankedPremadeGamesPlayed { get; set; }
        public int? botGamesPlayed { get; set; }

        #endregion
    }

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
