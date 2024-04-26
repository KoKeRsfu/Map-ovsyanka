using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideIconsButton : MonoBehaviour
{
	
	public int currentState = 0;
	//0 - открытые иконки, 1 - открытые улицы, 2 - открыт дом
	
	bool iconsWereActive = false;
	
	[SerializeField] Button mapSlider;
	
	[SerializeField] GameObject closeHousesButton;
	[SerializeField] GameObject icons;
	[SerializeField] GameObject iconPanels;

	[SerializeField] GameObject streets;
	
	
	public void MapSlider()
	{
		switch (currentState) 
		{
		case 0:
			streets.SetActive(true);
			icons.GetComponent<Icons>().HideIcons();
			mapSlider.GetComponent<buttonSpriteChanger>().ChangeSprite(1);
			currentState = 1;
			break;
		case 1:
			streets.SetActive(false);
			icons.GetComponent<Icons>().ShowIcons();
			mapSlider.GetComponent<buttonSpriteChanger>().ChangeSprite(0);
			currentState = 0;
			break;
		}
	}
	
	public void CloseHousesButton() 
	{
		Debug.Log("Фон");
		
			closeHousesButton.SetActive(false);

			streets.SetActive(false);
		icons.GetComponent<Icons>().ShowIcons();
			
		mapSlider.GetComponent<buttonSpriteChanger>().ChangeSprite(0);
		mapSlider.interactable = true;
			
			currentState = 0;

		this.GetComponent<ContentAdder>().CloseAll(-1);
	}
	
	public void HeaderButton(int a) 
	{
		switch (a) 
		{
		case 1:
			closeHousesButton.SetActive(false);

			streets.SetActive(false);
			icons.GetComponent<Icons>().ShowIcons();
			
			mapSlider.GetComponent<buttonSpriteChanger>().ChangeSprite(0);
			mapSlider.interactable = true;
			
			currentState = 0;
			break;
		
		case 0:
			closeHousesButton.SetActive(true);

			mapSlider.interactable = false;
			mapSlider.GetComponent<buttonSpriteChanger>().ChangeSprite(2);

			streets.SetActive(false);
			icons.GetComponent<Icons>().HideIcons();
			currentState = 2;
			break;

		}
	}
	
	public void HouseClick() 
	{
		
		closeHousesButton.SetActive(true);

		mapSlider.interactable = false;
		mapSlider.GetComponent<buttonSpriteChanger>().ChangeSprite(2);

		streets.SetActive(false);
		icons.GetComponent<Icons>().HideIcons();
		currentState = 2;
	}
}
