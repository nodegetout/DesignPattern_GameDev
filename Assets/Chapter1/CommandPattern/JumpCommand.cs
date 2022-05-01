using UnityEngine;

namespace Chapter1.CommandPattern
{
    public class JumpCommand : ICommand
    {
        public void Execute(GameActor actor)
        {
            actor.Jump();
        }
    }
}