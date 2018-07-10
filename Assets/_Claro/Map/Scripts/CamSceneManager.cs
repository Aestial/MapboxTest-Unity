namespace Claro.Map
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class CamSceneManager : Singleton<CamSceneManager>
    {

        // Use this for initialization
        void Start()
        {

        }

        public void RemoveScene()
        {
            ItemManager.Instance.RemoveCameraScene();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
   
}