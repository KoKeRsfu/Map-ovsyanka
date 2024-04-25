using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonSpriteChanger : MonoBehaviour
{
	private Image buttonSprite;
	
	private bool clicked = false;
	[SerializeField] Sprite sprite1;		
	[SerializeField] Sprite sprite2;
	[SerializeField] Sprite sprite3;
	
	protected void Start()
	{
		clicked = true;
		buttonSprite = this.GetComponent<Image>();
		//a
	}
	
	public void ChangeSprite(int a) 
	{
		switch (a)
		{
		case 0:
			buttonSprite.sprite = sprite1;
			clicked = true;
			break;
		case 1:
			buttonSprite.sprite = sprite2;
			clicked = false;
			break;
		case 2:
			buttonSprite.sprite = sprite3;
			break;
		case -1:		
			if (clicked) buttonSprite.sprite = sprite2;
			else buttonSprite.sprite = sprite1;
			clicked = !clicked;
			break;
		}
	}
		
}
