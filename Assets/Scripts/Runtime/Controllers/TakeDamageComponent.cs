using UnityEngine;

namespace Dikhyant.Outscal {
    public class TakeDamageComponent : MonoBehaviour, ITakeDamage, IHealth
    {
        private float health;
        private IPlayerHealthInfo playerHealthInfo;

        public float MaxHealth {
            get {
                return playerHealthInfo.MaxHealth;
            }
        }

        public float Health {
            get {
                return health;
            }
        }

        void Awake() {
            playerHealthInfo = PlayerInfoProvider.Instance._PlayerHealthInfo;
            health = playerHealthInfo.MaxHealth;
        }
        public void TakeDamage(float damageAmount)
        {
            health -= damageAmount;
            health = health < 0 ? 0 : health;
            CustomEvents.DispatchOnTakingDamage(this.gameObject);
        }
    }

}
