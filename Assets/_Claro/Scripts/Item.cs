using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Claro.Map
{
    public class Item : MonoBehaviour
    {
        [SerializeField] private Canvas canvas;

        public void SetCurrent()
        {
            ItemManager.Instance.Current = this;
        }

        public void Display(bool display)
        {
            this.canvas.enabled = display;
        }

        void Start()
        {
            this.Display(false);
        }

    }
}

    