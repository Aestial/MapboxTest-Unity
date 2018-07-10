namespace Claro.Map
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class CamSceneManager : Singleton<CamSceneManager>
    {

        void Start()
        {

        }

        public void RemoveScene()
        {
            ItemManager.Instance.RemoveCameraScene();
        }

    }
   
}