using UnityEngine;

namespace Claro
{
    public class ShareModalController : Singleton<ShareModalController>
    {
        [SerializeField] private bool enabledOnStart;
        private Canvas canvas;

        void Awake()
        {
            this.canvas = GetComponent<Canvas>(); 
        }

        void Start()
        {
            this.EnableModal(enabledOnStart);    
        }

        public void EnableModal(bool enabled)
        {
            this.canvas.enabled = enabled;
        }

    }
}
