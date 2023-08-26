using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dikhyant.Outscal {
    public class IdleState : ICharacterMovementState
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
            if( Math.Abs(characterMovementStateMachine._Rigidbody2D.velocity.x) > 0 ) {
                characterMovementStateMachine.ChangeState(characterMovementStateMachine.WalkState);
            }
        }


    }

}
