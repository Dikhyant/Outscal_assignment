using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dikhyant.Outscal {
    public class CustomEvents : Singleton<CustomEvents>
    {
        public static Action<GameObject> OnTakingDamage;

        public static void DispatchOnTakingDamage(GameObject gameObject) {
            OnTakingDamage?.Invoke(gameObject);
        }
    }
}

