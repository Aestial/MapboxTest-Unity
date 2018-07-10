using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleCanvas : MonoBehaviour 
{
    [SerializeField] private Toggle toggle;

    private Canvas canvas;

    void Awake()
    {
        this.canvas = GetComponent<Canvas>();    
    }

    void Start () 
    {
        this.canvas.enabled = this.toggle.isOn;    	
	}
}
