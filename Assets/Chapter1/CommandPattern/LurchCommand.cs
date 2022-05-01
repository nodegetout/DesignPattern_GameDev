using UnityEngine;

namespace Chapter1.CommandPattern
{
    public class LurchCommand : ICommand
    {
        public void Execute()
        {
            Debug.Log($"lurch");
        }
    }
}