using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Dikhyant.Outscal {
    public class PlayerCharacterMovementController : Singleton<PlayerCharacterMovementController>
    {
        [SerializeField]
        private CustomCharacterController customCharacterController;

        private PlayerInputs playerInputs;
        private DefaultInputActions inputActions;

        void OnEnable() {
            inputActions.Player.Move.performed += OnMove;
            // playerInputs.Gameplay.Move.performed += OnMove;
        }

        void OnDisable() {
            inputActions.Player.Move.performed -= OnMove;
            // playerInputs.Gameplay.Move.performed -= OnMove;
        }

        void Awake() {
            playerInputs = new PlayerInputs();
            inputActions = new DefaultInputActions();
        }

        void OnMove(InputAction.CallbackContext context) {
            Vector2 inputData = context.ReadValue<Vector2>();
            Debug.Log(inputData);
            if(inputData.x == 0) {
                customCharacterController.Stop();
                return;
            }
            if(inputData.x > 0) {
                customCharacterController.WalkRight();
                return;
            }
            if(inputData.x < 0) {
                customCharacterController.WalkLeft();
                return;
            }
        }
    }

}
