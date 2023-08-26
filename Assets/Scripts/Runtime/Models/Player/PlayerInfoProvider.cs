using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dikhyant.Outscal {
    public class PlayerInfoProvider : Singleton<PlayerInfoProvider>
    {
        [SerializeField]
        private PlayerHealthInfo playerHealthInfo;

        public PlayerHealthInfo _PlayerHealthInfo {
            get {
                return playerHealthInfo;
            }
        }

        [SerializeField]
        private PlayerMovementInfo playerMovementInfo;
        public PlayerMovementInfo _PlayerMovementInfo {
            get {
                return playerMovementInfo;
            }
        }
        
        
    }
}

