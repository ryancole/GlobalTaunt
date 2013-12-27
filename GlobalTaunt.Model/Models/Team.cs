using System.Collections.Generic;

namespace GlobalTaunt.Model
{
    public class Team
    {
        #region Properties

        public long CreateDate { get; set; }

        public string FullId { get; set; }

        public long LastGameDate { get; set; }

        public long LastJoinDate { get; set; }

        public long LastJoinedRankedTeamQueueDate { get; set; }

        public long ModifyDate { get; set; }

        public string Name { get; set; }

        public long SecondLastJoinDate { get; set; }

        public string Status { get; set; }

        public string Tag { get; set; }

        public long ThirdLastJoinDate { get; set; }

        public TeamRoster Roster { get; set; }

        public TeamMessageOfDay MessageOfDay { get; set; }

        public TeamStatSummary TeamStatSummary { get; set; }

        public List<TeamMatchHistory> MatchHistory { get; set; }

        #endregion
    }

    public class TeamMatchHistory
    {
        #region Properties

        public int Assists { get; set; }

        public int Deaths { get; set; }

        public long GameId { get; set; }

        public string GameMode { get; set; }

        public bool Invalid { get; set; }

        public int Kills { get; set; }

        public GameMap MapId { get; set; }

        public int OpposingTeamKills { get; set; }

        public string OpposingTeamName { get; set; }

        public bool Win { get; set; }

        #endregion
    }

    public class TeamMessageOfDay
    {
        #region Properties

        public long CreateDate { get; set; }

        public string Message { get; set; }

        public int Version { get; set; }

        #endregion
    }

    public class TeamRoster
    {
        #region Properties

        public long OwnerId { get; set; }

        public List<TeamRosterMemberInfo> MemberList { get; set; }

        #endregion
    }

    public class TeamRosterMemberInfo
    {
        #region Properties

        public long InviteDate { get; set; }

        public long JoinDate { get; set; }

        public long PlayerId { get; set; }

        public string Status { get; set; }

        #endregion
    }

    public class TeamStatSummary
    {
        #region Properties

        public string FullId { get; set; }

        public List<TeamStatDetail> TeamStatDetails { get; set; }

        #endregion
    }

    public class TeamStatDetail
    {
        #region Properties

        public int AverageGamesPlayed { get; set; }

        public string FullId { get; set; }

        public int Losses { get; set; }

        public string TeamStatType { get; set; }

        public int Wins { get; set; }

        #endregion
    }
}
