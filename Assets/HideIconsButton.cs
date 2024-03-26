using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideIconsButton : MonoBehaviour
{
	bool iconsWereActive = false;
	
	[SerializeField] GameObject icons;
	[SerializeField] GameObject iconPanels;
	[SerializeField] GameObject iconsButton;
	[SerializeField] GameObject streetsButton;
	[SerializeField] GameObject streets;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
	public void Outlines() 
	{
		Transform outlines = this.GetComponent<ContentAdder>().outlines;
		for (int i=0;i<outlines.childCount;i++) 
		{
			if (outlines.GetChild(i).gameObject.active) 
			{
				streetsButton.GetComponent<Button>().interactable = false;
				streetsButton.GetComponent<buttonSpriteChanger>().ChangeSprite(0);
				streets.SetActive(false);
				HideIcons();
				return;
			}
		} 
		streetsButton.GetComponent<Button>().interactable = true;
		iconsWereActive = false;
		ShowIcons();
	}
    
	public void Streets() 
	{
		if (iconsButton.GetComponent<Button>().IsInteractable()) 
		{
			HideIcons();
		}
		else 
		{
			ShowIcons();
		}
	}
	
	private void HideIcons() 
	{
		if (icons.transform.GetChild(0).gameObject.active) 
		{
			iconsWereActive = true;
			icons.GetComponent<Icons>().HideIcons();
		}
		else iconsWereActive = false;
		iconsButton.GetComponent<Button>().interactable = false;
		iconPanels.SetActive(false);
	}
	
	private void ShowIcons()
	{
		iconsButton.GetComponent<Button>().interactable = true;
		if (iconsWereActive) icons.GetComponent<Icons>().HideIcons();
		iconPanels.SetActive(true);
	}
}
