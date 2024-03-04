using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapController : MonoBehaviour
{
	
	[SerializeField] List<Sprite> mapSprites;
	
	private int currentSprite = 0;
    
	public void NextSprite() 
	{
		if (currentSprite < (mapSprites.Count - 1)) 
		{
			currentSprite += 1;	
		}
		else 
		{
			currentSprite = 0;
		}
		
		UpdateSprite();
	}
	
	public void PrevSprite() 
	{
		if (currentSprite > 0) 
		{
			currentSprite -= 1;	
		}
		else 
		{
			currentSprite = (mapSprites.Count - 1);
		}
		
		UpdateSprite();
	}
	
	private void UpdateSprite() 
	{
		transform.GetChild(0).GetComponent<Image>().sprite = mapSprites[currentSprite];
	}
    
}
