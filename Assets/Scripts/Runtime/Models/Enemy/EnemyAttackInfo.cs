using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dikhyant.Outscal {
    [CreateAssetMenu(menuName = "Enemy Attack Info")]
    public class EnemyAttackInfo : ScriptableObject , IEnemyAttackInfo
    {
        [SerializeField]
        private float damageAmount;
        public float DamageAmount {
            get {
                return damageAmount;
            }
        }

    }
}

