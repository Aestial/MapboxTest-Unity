namespace Claro.Map
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class ItemModalController : Singleton<ItemModalController>
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
