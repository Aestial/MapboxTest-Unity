namespace Claro.Map
{
    using UnityEngine;

    public enum Axis
    {
    	x,
    	y,
    	z
    }

    public class Rotator : MonoBehaviour
    {
        public Axis axis;
        public float speed;


        private Transform t;
        private float angle = 0.0f;

        public float Angle
        {
            get { return angle; }
            set { angle = value; }
        }

        void Start()
        {
            t = GetComponent<Transform>();
        }

        void Update()
        {
            angle = angle + speed * Time.deltaTime;
            switch (axis)
            {
                case Axis.x:
                    t.eulerAngles = new Vector3(angle, 0.0f, 0.0f);
                    break;
                case Axis.y:
                    t.eulerAngles = new Vector3(0.0f, angle, 0.0f);
                    break;
                case Axis.z:
                    t.eulerAngles = new Vector3(0.0f, 0.0f, angle);
                    break;
            }

        }
    }
}
