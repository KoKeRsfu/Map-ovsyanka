using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ListItemExpander : MonoBehaviour
{
	private GameObject content;
	private Image numberIcon;
	private TextMeshProUGUI number;
	private TextMeshProUGUI name;
	private GameObject lineTop;
	private GameObject lineBottom;
	
	void Start()
	{
		lineTop = transform.GetChild(0).gameObject;
		lineBottom = transform.GetChild(3).gameObject;
		content = transform.GetChild(2).gameObject;
		numberIcon = transform.GetChild(1).GetChild(0).GetComponent<Image>();
		number = transform.GetChild(1).GetChild(0).GetComponentInChildren<TextMeshProUGUI>();
		name = transform.GetChild(1).GetChild(1).GetComponent<TextMeshProUGUI>();
	}


	public void Expand() 
	{
		if (content.activeSelf)
		{
			content.SetActive(false);
			lineTop.SetActive(false);
			lineBottom.SetActive(false);
			
			numberIcon.color = new Color(1,1,1,1);
			number.color = new Color(0,0,0,1);
			name.color = new Color(0,0,0,1);
		}
		else
		{
			content.SetActive(true);
			lineTop.SetActive(true);
			lineBottom.SetActive(true);
			
			numberIcon.color = new Color(0.22f,0.45f,1,1);
			number.color = new Color(1,1,1,1);
			name.color = new Color(0.22f,0.45f,1,1);
		}
		
		
		VerticalLayoutGroup contentGroup = content.GetComponent<VerticalLayoutGroup>();
		if (content.transform.childCount == 0) 
		{
			contentGroup.enabled = false;
			lineTop.SetActive(false);
			lineBottom.SetActive(false);
		}
		else  contentGroup.enabled = true;
	}

}
