using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideIconsButton : MonoBehaviour
{
	public int currentState = 0;
	//0 - открытые иконки, 1 - открытые улицы, 2 - открыт дом, 3 - ничего не открыто
	
	bool iconsWereActive = false;
	
	[SerializeField] GameObject icons;
	[SerializeField] GameObject iconPanels;
	[SerializeField] GameObject iconsButton;
	[SerializeField] GameObject streetsButton;
	[SerializeField] GameObject streets;
	
	
	public void HeaderButton() 
	{
		switch (currentState) 
		{
		case 2:
			iconsButton.GetComponent<Button>().interactable = true;
			streetsButton.GetComponent<Button>().interactable = true;
			icons.GetComponent<Icons>().ShowIcons();
			currentState = 0;
			break;
		
		default:
			streetsButton.GetComponent<buttonSpriteChanger>().ChangeSprite(0);
			iconsButton.GetComponent<buttonSpriteChanger>().ChangeSprite(0);
			iconsButton.GetComponent<Button>().interactable = false;
			streetsButton.GetComponent<Button>().interactable = false;
			icons.GetComponent<Icons>().HideIcons();
			streets.SetActive(false);
			currentState = 2;
			break;
		
		
		}
	}
	
	public void StreetsButton() 
	{
		switch (currentState) 
		{
		case 0:
			streetsButton.GetComponent<buttonSpriteChanger>().ChangeSprite(1);
			iconsButton.GetComponent<buttonSpriteChanger>().ChangeSprite(1);
			streets.SetActive(true);
			icons.GetComponent<Icons>().HideIcons();
			currentState = 1;
			break;
		case 1:
			streetsButton.GetComponent<buttonSpriteChanger>().ChangeSprite(0);
			iconsButton.GetComponent<buttonSpriteChanger>().ChangeSprite(0);
			streets.SetActive(false);
			icons.GetComponent<Icons>().ShowIcons();
			currentState = 0;
			break;
		case 3:
			currentState = 0;
			StreetsButton();
			break;
		}
	}
	
	public void IconsButton() 
	{
		switch (currentState) 
		{
		case 0:
			iconsButton.GetComponent<buttonSpriteChanger>().ChangeSprite(1);
			icons.GetComponent<Icons>().HideIcons();
			currentState = 3;
			break;
		case 1:
			streetsButton.GetComponent<buttonSpriteChanger>().ChangeSprite(0);
			iconsButton.GetComponent<buttonSpriteChanger>().ChangeSprite(0);
			streets.SetActive(false);
			icons.GetComponent<Icons>().ShowIcons();
			currentState = 0;
			break;
		case 3:
			currentState = 1;
			IconsButton();
			break;
		}
	}
}
