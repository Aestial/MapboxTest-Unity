using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed;

    private Transform t;

    private float angle = 0.0f;

    public float Angle
    {
        get { return angle; }
        set { angle = value; }
    }

    void Start () 
    {
        t = GetComponent<Transform>();
	}
	
	void Update () 
    {
        angle = angle + speed * Time.deltaTime;
        t.eulerAngles = new Vector3(0.0f, angle, 0.0f);
	}
}
