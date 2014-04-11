using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLADeliverables.Common.DataContracts.Repositories
{
    public interface IAppointmentRepository : IRepository
    {
        IAppointmentData BuildAppointment(int customerId, int specialtyId, bool isFullDesigner, IList<DateTimeRange> dateTimeRanges);
        decimal CancelAppointment(int appointmentId); // returns the charges
        IEnumerable<IAppointmentData> GetDesignerActiveAppointments(int designerId);
        IEnumerable<IAppointmentData> GetCustomerActiveAppointments(int customerId);
    }
}