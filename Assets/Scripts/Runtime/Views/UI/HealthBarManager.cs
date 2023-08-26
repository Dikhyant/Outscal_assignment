using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dikhyant.Outscal {
    public class HealthBarManager : MonoBehaviour
    {
        private GameObject targetGameObject;
        public GameObject TargetGameObject {
            set {
                targetGameObject = value;
            }
        }

        private IProgressBar progressBar;
        void OnEnable() {
            CustomEvents.OnTakingDamage += OnTakingDamage;
        }

        void OnDisable() {
            CustomEvents.OnTakingDamage -= OnTakingDamage;
        }

        void OnTakingDamage(GameObject gameObject) {
            IHealth health = gameObject.GetComponent<IHealth>();
            if(targetGameObject == gameObject && health != null) {
                progressBar.ProgressAmount = health.Health / health.MaxHealth;
            }
        }
    }

}
