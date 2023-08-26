using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dikhyant.Outscal {
    public class CharacterStateMachineInitializer : MonoBehaviour
    {
        [SerializeField]
        private CharacterMovementStateMachine characterMovementStateMachine;
        void Awake() {
            characterMovementStateMachine._Rigidbody2D = GetComponent<Rigidbody2D>();

            // Using player movement info for now. May change later
            CharacterMovementInfo charMovInfo = new CharacterMovementInfo();
            charMovInfo.WalkSpeed = PlayerInfoProvider.Instance._PlayerMovementInfo.WalkSpeed;
            charMovInfo.RunningSpeed = PlayerInfoProvider.Instance._PlayerMovementInfo.RunningSpeed;
            charMovInfo.JumpHeight = PlayerInfoProvider.Instance._PlayerMovementInfo.JumpHeight;

            characterMovementStateMachine._CharacterMovementInfo = charMovInfo;

            IdleState idleState = new IdleState();
            idleState._CharacterMovementStateMachine = characterMovementStateMachine;
            characterMovementStateMachine.IdleState = idleState;

            WalkState walkState = new WalkState();
            walkState._CharacterMovementStateMachine = characterMovementStateMachine;
            characterMovementStateMachine.WalkState = walkState;
        }
    }

}
