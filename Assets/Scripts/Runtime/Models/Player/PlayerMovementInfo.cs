using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dikhyant.Outscal {
    [CreateAssetMenu(menuName = "Player Movement Info")]
    public class PlayerMovementInfo : ScriptableObject, IPlayerMovementInfo
    {
        [SerializeField]
        private float walkSpeed;

        [SerializeField]
        private float runningSpeed;

        [SerializeField]
        private float jumpHeight;

        public float WalkSpeed { 
            get {
                return walkSpeed;
            }
         }
        public float RunningSpeed { 
            get {
                return runningSpeed;
            }
         }
        public float JumpHeight { 
            get {
                return jumpHeight;
            }
         }
    }

}

