using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icons : MonoBehaviour
{
	public void ReverseIcons() 
	{
		for (int i=0;i<transform.childCount;i++) 
		{
			transform.GetChild(i).gameObject.SetActive(!transform.GetChild(i).gameObject.active);
		}
	}
	
	public void HideIcons() 
	{
		for (int i=0;i<transform.childCount;i++) 
		{
			transform.GetChild(i).gameObject.SetActive(false);
		}
	}
	
	public void ShowIcons() 
	{
		for (int i=0;i<transform.childCount;i++) 
		{
			transform.GetChild(i).gameObject.SetActive(true);
		}
	}
}
