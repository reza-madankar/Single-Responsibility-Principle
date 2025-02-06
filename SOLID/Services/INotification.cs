using SOLID.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Services
{
    public interface INotification
    {
        void SendOrderConfirmation(Order order);
    }
}
