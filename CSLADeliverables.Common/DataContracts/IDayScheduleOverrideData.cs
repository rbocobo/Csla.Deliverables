using System;
namespace CSLADeliverables.Common.DataContracts
{
    public interface IDayScheduleOverrideData
    {
        int Id { get; set; }
        int WeekScheduleId { get; set; }
        DateTime Date { get; set; }                
        DateTime EndTime { get; set; }
        DateTime StartTime { get; set; }        
    }
}
