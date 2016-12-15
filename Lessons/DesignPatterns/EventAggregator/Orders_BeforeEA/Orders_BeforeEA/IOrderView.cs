using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_BeforeEA
{
    public interface IOrderView
    {
        void OnOrderSelected();
        void OnOrderSaved();
    }
}
