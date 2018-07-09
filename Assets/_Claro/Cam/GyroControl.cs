using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroControl : MonoBehaviour {

    private bool gyroEnabled;
    private Gyroscope gyro;

    private GameObject camContainer;
    private Quaternion rot;

    public GameObject cube;

	private void Start()
	{
        camContainer = new GameObject("camContainer");
        camContainer.transform.position = transform.position;
        transform.SetParent(camContainer.transform);
        gyroEnabled = EnableGyro();
	}

    private bool EnableGyro()
    {
        if(SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;

            camContainer.transform.rotation = Quaternion.Euler(90f, 90f, 0f);
            rot = new Quaternion(0, 0, 1, 0);

            return true;
        }

        else{
            Application.Quit();
            return false;
        }
       
    }

	private void Update()
	{
        if(gyroEnabled)
        {
            this.transform.localRotation = gyro.attitude * rot;
            cube.transform.rotation = gyro.attitude * rot;
        }
	}
}
