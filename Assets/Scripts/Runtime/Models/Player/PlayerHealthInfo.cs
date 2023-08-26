using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dikhyant.Outscal {
    [CreateAssetMenu(menuName = "Player Health Info")]
    public class PlayerHealthInfo : ScriptableObject, IPlayerHealthInfo
    {
        [SerializeField]
        private float maxHealth;
        public float MaxHealth {
            get {
                return maxHealth;
            }
        }
    }

}
