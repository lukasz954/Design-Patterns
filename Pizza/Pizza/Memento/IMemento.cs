using Pizza;
using Pizza.Singleton;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Memento
{
    public interface IMemento
    {
        DateTime Date { get; }
        string State { get; }
    }

}
