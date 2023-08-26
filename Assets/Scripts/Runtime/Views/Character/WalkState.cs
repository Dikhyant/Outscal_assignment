using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dikhyant.Outscal {
    public class WalkState : ICharacterMovementState
    {
        private ICharacterMovementStateMachine characterMovementStateMachine;
        public ICharacterMovementStateMachine _CharacterMovementStateMachine {
            set {
                characterMovementStateMachine = value;
            }
            get {
                return characterMovementStateMachine;
            }
        }

        public void Entry()
        {
           
        }

        public void Exit()
        {
            
        }

        public void Update()
        {
            
        }
    }
}

