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
	
	protected void Start()
	{
		clicked = true;
		buttonSprite = this.GetComponent<Image>();
	}
	
	public void ChangeSprite() 
	{
		if (clicked) buttonSprite.sprite = sprite2;
		else buttonSprite.sprite = sprite1;
		
		clicked = !clicked;
	}
		
}
