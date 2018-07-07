using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEvent : MonoBehaviour 
{
	// Use this for initialization
	void OnMouseDown () 
	{
		Debug.Log ("Clicked coin");
		Destroy (transform.parent.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
