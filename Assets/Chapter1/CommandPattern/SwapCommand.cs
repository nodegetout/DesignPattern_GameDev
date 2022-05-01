using UnityEngine;

namespace Chapter1.CommandPattern
{
    public class SwapCommand : ICommand
    {
        public void Execute(GameActor actor)
        {
            actor.Swap();
        }
    }
}