using System;
namespace AssemblyCSharp
{
    public interface IPlayerState
    {
        void DoAction(PlayerStateContext stateContext);
        string ToString();

    }
}