namespace Claro.Map
{
    using Mapbox.Utils;
    using UnityEngine.UI;
    using Mapbox.Unity.Map;
    using UnityEngine;
    using System;
    using System.Collections;

    public class CenterPosition : MonoBehaviour
    {
        Camera _camera;
        Vector3 _cameraStartPos;
        AbstractMap _map;

        [SerializeField]
        string LatitudeLongitude;

        double _x, _y;

        Coroutine _reloadRoutine;

        WaitForSeconds _wait;

        void Awake()
        {
            _camera = Camera.main;
            _cameraStartPos = _camera.transform.position;
            _map = FindObjectOfType<AbstractMap>();
            _wait = new WaitForSeconds(.3f);
        }

        void Start()
        {
            double.TryParse(LatitudeLongitude.Split(',')[0], out _x);
            double.TryParse(LatitudeLongitude.Split(',')[1], out _y);
            Debug.Log(_x);
            Debug.Log(_y);
        }

        public void UpdateMap()
        {
            _camera.transform.position = _cameraStartPos;
            _map.UpdateMap(new Vector2d(_x, _y), _map.Zoom);
        }
    }
}