using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapController : MonoBehaviour
{
	[SerializeField] GameObject streets;
	
	public void ChangeStreets() 
	{
		streets.SetActive(!streets.activeSelf);
	}
    
}
