using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dikhyant.Outscal {
    public interface ICharacterMovementStateMachine 
    {
        public ICharacterMovementInfo _CharacterMovementInfo {get; set;}
        public ICharacterMovementState IdleState {get; set;}
        public ICharacterMovementState WalkState {get; set;}
        public ICharacterMovementState RunState {get; set;}
        public ICharacterMovementState JumpState {get; set;}
        public Rigidbody2D _Rigidbody2D {get; set;}

        public void ChangeState(ICharacterMovementState state);
    }

}
