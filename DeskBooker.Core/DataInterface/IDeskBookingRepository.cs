using System;
using System.Collections.Generic;
using System.Text;
using DeskBooker.Core.Domain;

namespace DeskBooker.Core.DataInterface
{
    public interface IDeskBookingRepository
    {
        void Save(DeskBooking deskBooking);
    }
}
