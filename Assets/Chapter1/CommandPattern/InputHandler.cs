using System;
using UnityEngine;

namespace Chapter1.CommandPattern
{
    public class InputHandler : MonoBehaviour
    {
        private JumpCommand m_CommandButtonX = new JumpCommand();
        private FireCommand m_CommandButtonY = new FireCommand();
        private LurchCommand m_CommandButtonA = new LurchCommand();
        private SwapCommand m_CommandButtonB = new SwapCommand();
        
        
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                m_CommandButtonX.Execute();
            }else if (Input.GetKeyDown(KeyCode.Y))
            {
                m_CommandButtonY.Execute();
            }else if (Input.GetKeyDown(KeyCode.A))
            {
                m_CommandButtonA.Execute();
            }else if (Input.GetKeyDown(KeyCode.B))
            {
                m_CommandButtonB.Execute();
            }
        }
    }
}