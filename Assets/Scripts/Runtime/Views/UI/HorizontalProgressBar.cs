using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

namespace Dikhyant.Outscal {
    public class HorizontalProgressBar : MonoBehaviour, IProgressBar
    {
        [SerializeField]
        private Image foreGround;

        private float progressAmount;
        public float ProgressAmount {
            get {
                return progressAmount;
            }

            set {
                progressAmount = value > 0 ? value < 1 ? value : 1 : 0;
                ChangeProgressAmount(progressAmount);
            }
        }

        void Awake() {
            if(foreGround == null) {
                Debug.LogError("Foreground not found");
            }
        }

        void ChangeProgressAmount(float progressAmount) {
            if(foreGround == null) return;
            foreGround.fillAmount = progressAmount;
        }
    }

}

