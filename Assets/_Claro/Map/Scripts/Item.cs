namespace Claro.Map
{
    using UnityEngine;

    public class Item : MonoBehaviour
    {
        //[SerializeField] private Canvas canvas;

        public void SetCurrent()
        {
            ItemManager.Instance.Current = this;
        }

        public void SetNull()
        {
            ItemManager.Instance.Current = null;
        }

        //public void Display(bool display)
        //{
        //    this.canvas.enabled = display;
        //}

        //public void ActiveCamera()
        //{
        //    ItemManager.Instance.AddCameraScene();
        //}

        //void Start()
        //{
        //    this.Display(false);
        //}
    }
}

    