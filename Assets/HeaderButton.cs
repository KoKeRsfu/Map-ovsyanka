using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeaderButton : MonoBehaviour
{
	private void Awake()
	{
		this.GetComponent<Button>().onClick.AddListener(OnClick);
	}

	private void OnClick()
	{
		transform.parent.parent.GetComponent<HideIconsButton>().HeaderButton();
	}
	
}
