	using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using TMPro;

public class ContentAdder : MonoBehaviour
{
	[SerializeField] TextAsset contentText;

    void Start()
    {
        
	    string content = contentText.text;
	    string current = "";
	    string lineEnd = "\n";
	    string tab = "\t";
	    string plus = "+";
	    
	    string prevStreet = "";
	    int content_n = 0;
        
	    GameObject currentItem = CreateItem();
        
	    for (int i = 0; i<content.Length; i++) 
	    {
	    	if (content[i] == lineEnd[0]) 
	    	{
	    		if (current[0] == plus[0]) 
	    		{
	    				
	    		}
	    		else Destroy(currentItem.transform.GetChild(2).GetChild(0).gameObject);
	    		
	    		content_n = 0;
	    		current = "";
	    		
	    		currentItem = CreateItem();
	    	}
	    	else if (content[i] == tab[0]) 
	    	{
	    		content_n += 1;
	    		switch (content_n) 
	    		{
	    		case 1:
	    				currentItem.transform.GetChild(1).GetComponentInChildren<TextMeshProUGUI>().text = current;
		    			break;
	    		case 2:
	    			if (current != prevStreet) CreateHeader(current);
	    			prevStreet = current;
		    			break;
	    		case 3:
	    			currentItem.transform.GetChild(1).GetChild(1).GetComponent<TextMeshProUGUI>().text = current;
		    			break;
	    		case 4:
	    			if (current != "") 
	    			{
	    				currentItem.transform.GetChild(2).GetComponentInChildren<TextMeshProUGUI>().text = current;
	    			}
	    			else Destroy(currentItem.transform.GetChild(2).GetChild(1).gameObject);
		    			break;
	    		}
	    		current = "";
	    	}
	    	else
	    	{
	    		current = current + content[i];		
	    	}
	    }
    }
    
	private GameObject CreateItem() 
	{
		return Instantiate(Resources.Load<GameObject>("Ovsyanka_Map/Prefabs/List_Item"), this.transform);
	}
	
	private void CreateHeader(string name)
	{
		GameObject temp = Instantiate(Resources.Load<GameObject>("Ovsyanka_Map/Prefabs/List_Header"), this.transform);
		temp.GetComponent<TextMeshProUGUI>().text = name;
		
		temp.transform.SetSiblingIndex(this.transform.childCount - 2);
	}
}
