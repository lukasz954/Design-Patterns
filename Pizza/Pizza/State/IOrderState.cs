using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.State
{
    public interface IOrderState
    {
        string SetProgress();
    }
}
