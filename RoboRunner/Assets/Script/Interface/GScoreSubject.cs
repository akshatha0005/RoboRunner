using System;
namespace Project202
{
    public interface GScoreSubject
    {
        void Attach(IScoreObserver ob);
        void Detach(IScoreObserver ob);
        void NotifyObservers();

    }
}



