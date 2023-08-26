using UnityEngine;

namespace Dikhyant.Outscal
{
    public abstract class Singleton<T> : MonoBehaviour
    {
        private static T instance;
        public static T Instance {
            get {
                if(instance == null || Equals(instance, null)) {
                    instance = FindObjectOfType<Singleton<T>>().GetComponent<T>();
                }
                return instance;
            }
        }

        void Awake() {
            if(instance == null) {
                instance = GetComponent<T>();
            }
            else {
                Destroy(this);
                return;
            }
        }
    }

}

