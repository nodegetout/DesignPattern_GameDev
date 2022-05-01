using UnityEngine;

namespace Chapter1.CommandPattern
{
    public class FireCommand : ICommand
    {
        public void Execute()
        {
            Debug.Log($"fire");
        }
    }
}