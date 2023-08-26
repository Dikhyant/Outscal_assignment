using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dikhyant.Outscal {
    public class CharacterMovementInfo : ICharacterMovementInfo
    {
        public float WalkSpeed {get; set;}

        public float RunningSpeed {get; set;}

        public float JumpHeight {get; set;}
    }

}
