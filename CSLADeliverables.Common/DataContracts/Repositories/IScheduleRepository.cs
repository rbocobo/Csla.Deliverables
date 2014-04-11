using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLADeliverables.Common.DataContracts.Repositories
{
    public interface IScheduleRepository : IRepository
    {
        IWeekScheduleData CreateWeekSchedule();
        void AddWeekSchedule(IWeekScheduleData weekSchedule);
        IWeekScheduleData GetWeekSchedule(int designerId, DateTime weekStartDate);
        void UpdateWeekSchedule(IWeekScheduleData weekSchedule);

        IDayScheduleOverrideData CreateDayScheduleOverride();
        void AddDayScheduleOverride(IDayScheduleOverrideData daySchedule);
        IDayScheduleOverrideData GetDayScheduleOverride(int designerId, DateTime date);
        void UpdateDayScheduleOverride(IDayScheduleOverrideData daySchedule);        

        void SaveChanges();
    }
}
