using UnityEngine;

namespace Chapter1.CommandPattern
{
    public class GameActor
    {
        public void Jump()
        {
            Debug.Log($"Jump");
        }

        public void Fire()
        {
            Debug.Log($"Fire");
        }

        public void Lurch()
        {
            Debug.Log($"Lurch");
        }

        public void Swap()
        {
            Debug.Log($"Swap");
        }
        
        public void DoNothing()
        {
            Debug.Log($"DoNothing");
        }
    }
}