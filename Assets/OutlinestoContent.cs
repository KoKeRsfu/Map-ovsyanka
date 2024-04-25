using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutlinestoContent : MonoBehaviour
{

	[SerializeField] ScrollRect scroller;
	[SerializeField] RectTransform contentPanel;

	[SerializeField] GameObject Content;

	public void Outline() 
	{
		for (int i=0;i<transform.childCount;i++) 
		{
			if (transform.GetChild(i).childCount == 0) continue;
			
			if (transform.GetChild(i).GetComponent<Image>().enabled)
			{
				Content.GetComponent<HideIconsButton>().HouseClick();
				Content.GetComponent<ContentAdder>().CloseAll(i);
				SnapTo(Content.transform.GetChild(i-1).GetComponent<RectTransform>());
				return;
			}
		}
	}
	
	public void SnapTo(RectTransform target)
	{
		Canvas.ForceUpdateCanvases();

		var contentPos = (Vector2)scroller.transform.InverseTransformPoint(scroller.content.position );
		var childPos = (Vector2)scroller.transform.InverseTransformPoint(target.position);
		var endPos = contentPos - childPos;
		endPos.x = scroller.content.anchoredPosition.x;
		contentPanel.anchoredPosition = endPos;
	}

}
