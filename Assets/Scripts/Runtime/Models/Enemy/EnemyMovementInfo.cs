using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dikhyant.Outscal {
    [CreateAssetMenu(menuName = "Enemy Movement Info")]
    public class EnemyMovementInfo : ScriptableObject, IEnemyMovementInfo
    {
        [SerializeField]
        private float walkSpeed;
        public float WalkSpeed {
            get {
                return walkSpeed;
            }
        }
    }

}
