using Project202;
using System;
namespace AssemblyCSharp
{
    public interface IScoreSubject
    {
        void Attach(IScoreObserver ob);
        void Detach(IScoreObserver ob);
        void NotifyObservers();

    }
}
