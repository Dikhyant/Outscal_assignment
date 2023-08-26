using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dikhyant.Outscal {
    public class CharacterMovementStateMachine : MonoBehaviour , ICharacterMovementStateMachine
    {
        private ICharacterMovementState currentState;
        private ICharacterMovementState idleState;
        public ICharacterMovementState IdleState {
            set {
                idleState = value;
            }
            get {
                return idleState;
            }
        }

        private ICharacterMovementState walkState;
        public ICharacterMovementState WalkState {
            set {
                walkState = value;
            }
            get {
                return walkState;
            }
        }

        private ICharacterMovementState runState;
        public ICharacterMovementState RunState {
            set {
                runState = value;
            }
            get {
                return runState;
            }
        }

        private ICharacterMovementState jumpState;
        public ICharacterMovementState JumpState {
            set {
                jumpState = value;
            }
            get {
                return jumpState;
            }
        }

        private new Rigidbody2D rigidbody2D;
        public Rigidbody2D _Rigidbody2D {
            set {
                rigidbody2D = value;
            }
            get {
                return rigidbody2D;
            }
        }

        private ICharacterMovementInfo characterMovementInfo;
        public ICharacterMovementInfo _CharacterMovementInfo {
            set {
                characterMovementInfo = value;
            }
            get {
                return characterMovementInfo;
            }
        }

        public void ChangeState(ICharacterMovementState state) {
            
            if(currentState != null) {
                currentState.Exit();
            }

            currentState = state;
            currentState.Entry();
        }

        void Update() {
            if(currentState != null) {
                currentState.Update();
            }
        }
    }

}
