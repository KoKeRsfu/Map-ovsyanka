using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icons : MonoBehaviour
{
	public void HideIcons() 
	{
		for (int i=0;i<transform.childCount;i++) 
		{
			transform.GetChild(i).gameObject.SetActive(!transform.GetChild(i).gameObject.active);
		}
	}
}
