using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dikhyant.Outscal {
    public class DamageProviderComponent : MonoBehaviour
    {
        private IEnemyAttackInfo enemyAttackInfo;

        void Awake() {
            enemyAttackInfo = EnemyInfoProvider.Instance._EnemyAttackInfo;
        }

        void OnCollisionStay2D(Collision2D collision) {
            ITakeDamage takeDamage = collision.gameObject.GetComponent<ITakeDamage>();
            if(takeDamage != null && enemyAttackInfo != null) {
                takeDamage.TakeDamage(enemyAttackInfo.DamageAmount);
            }
        }
    }
}


