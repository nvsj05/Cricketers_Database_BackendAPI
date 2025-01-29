using System.ComponentModel.DataAnnotations.Schema;


namespace Cricketers_FinalProject_BackendAPI.Models
{


    [Table("Cricketers")]
    public class Cricketer
    {
        public int CricketerId { get; set; }
        public string CricketerName { get; set; }
        public string CricketerType { get; set; }
        public int JerseyNumber { get; set; }
        public int TotalRuns { get; set; }
        public int TotalWickets { get; set; }
        public int TestRuns { get; set; }
        public int ODIRuns { get; set; }
        public int T20Runs { get; set; }
        public int TestWickets { get; set; }
        public int ODIWickets { get; set; }
        public int T20Wickets { get; set; }
        public DateTime DebutDate { get; set; }
    }


}
