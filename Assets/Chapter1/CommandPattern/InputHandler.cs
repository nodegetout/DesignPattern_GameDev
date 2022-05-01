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

        private GameActor m_GameActor = new GameActor();
        
        void Update()
        {
            ICommand command = HandleInput();
            command?.Execute(m_GameActor);
        }

        ICommand HandleInput()
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                return m_CommandButtonX;
            }
            if (Input.GetKeyDown(KeyCode.Y))
            {
                return m_CommandButtonY;
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                return m_CommandButtonA;
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                return m_CommandButtonB;
            }

            return null;
        }
    }
}