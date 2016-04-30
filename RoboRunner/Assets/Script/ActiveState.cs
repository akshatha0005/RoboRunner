using System;
namespace AssemblyCSharp
{
    public class ActiveState : IPlayerState
    {
        public ActiveState()
        {

        }

        public void DoAction(PlayerStateContext context)
        {
            context.SetState(this);
        }

        public string ToString()
        {
            return "active";
        }
    }
}

