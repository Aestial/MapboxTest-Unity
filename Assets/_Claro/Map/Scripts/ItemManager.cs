namespace Claro.Map
{
    using UnityEngine;
    using UnityEngine.SceneManagement;

    public class ItemManager : Singleton<ItemManager>
    {
        [SerializeField] private string CamSceneName;

        public Item current;

        public Item Current
        {
            get { return current; }
            set 
            { 
                this.Display(false);
                this.current = value;
                this.Display(true);
            }
        }

        private void Display(bool display)
        {
            if (this.current != null)
                ItemModalController.Instance.EnableModal(display);
                //this.current.Display(display);
        }

        public void AddCameraScene()
        {
            SceneManager.LoadSceneAsync(this.CamSceneName, LoadSceneMode.Additive);
        }

        public void RemoveCameraScene()
        {
            SceneManager.UnloadSceneAsync(this.CamSceneName);
        }
    }
}
