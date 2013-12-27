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

        #endregion
    }
}
