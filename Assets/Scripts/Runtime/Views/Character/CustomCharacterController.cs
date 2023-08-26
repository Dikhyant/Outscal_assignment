using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dikhyant.Outscal {
    public class CustomCharacterController : MonoBehaviour
    {
        [SerializeField]
        private CharacterMovementStateMachine characterMovementStateMachine;

        public void WalkRight() {
            float speed = characterMovementStateMachine._CharacterMovementInfo.WalkSpeed;
            characterMovementStateMachine._Rigidbody2D.velocity = new Vector2(
                speed, characterMovementStateMachine._Rigidbody2D.velocity.y );
        }

        public void WalkLeft() {
            float speed = -characterMovementStateMachine._CharacterMovementInfo.WalkSpeed;
            characterMovementStateMachine._Rigidbody2D.velocity = new Vector2(
                speed, characterMovementStateMachine._Rigidbody2D.velocity.y );
        }

        public void Stop() {
            characterMovementStateMachine._Rigidbody2D.velocity = new Vector2(
                0, characterMovementStateMachine._Rigidbody2D.velocity.y
            );
        }
    }

}
