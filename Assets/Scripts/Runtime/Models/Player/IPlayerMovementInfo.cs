using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dikhyant.Outscal {
    public interface IPlayerMovementInfo 
    {
        public float WalkSpeed {get;}
        public float RunningSpeed {get;}
        public float JumpHeight {get;}
    }
}

