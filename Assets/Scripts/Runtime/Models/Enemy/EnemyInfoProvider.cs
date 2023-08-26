using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dikhyant.Outscal {
    public class EnemyInfoProvider : Singleton<EnemyInfoProvider>
    {
        [SerializeField]
        private EnemyAttackInfo enemyAttackInfo;

        public EnemyAttackInfo _EnemyAttackInfo {
            get {
                return enemyAttackInfo;
            }
        }
    }
}

