using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;
using TMPro;

public class MobileSettings : MonoBehaviour
{
	
	[SerializeField] Camera cam;
    
	public void onSlider(float value) 
	{
		cam.orthographicSize = value;
	}
    
}
