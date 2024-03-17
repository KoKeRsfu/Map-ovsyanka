using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderFix : MonoBehaviour
{
	[SerializeField] Scrollbar scroll;
    
	protected void OnEnable()
	{
		StartCoroutine("Fix");
	}

	private IEnumerator Fix() 
	{
		yield return new WaitForSeconds(0.05f);
		scroll.size = 0;
	}
}
