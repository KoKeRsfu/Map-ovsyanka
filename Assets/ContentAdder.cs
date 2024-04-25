	using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using TMPro;
using UnityEngine.UI;

public class ContentAdder : MonoBehaviour
{
	[SerializeField] TextAsset contentText;
	public Transform outlines;

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
		    	Debug.Log("текущая строка - " + current);
		    	currentItem.GetComponent<ListItemExpander>().iconId = int.Parse(current);
		    	
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
	    			currentItem.transform.GetChild(1).GetChild(2).GetComponent<TextMeshProUGUI>().text = current;
		    			break;
	    		case 4:
	    			if (current != "") 
	    			{
	    				currentItem.transform.GetChild(2).GetComponentInChildren<TextMeshProUGUI>().text = current;
	    			}
	    			else Destroy(currentItem.transform.GetChild(2).GetChild(1).gameObject);
		    		break;
	    		case 5:
		    		if (current[0] == plus[0]) 
		    		{
			    		string photoPath = "Ovsyanka_Map/Photos/" + currentItem.transform.GetChild(1).GetComponentInChildren<TextMeshProUGUI>().text;
			    		currentItem.transform.GetChild(2).GetChild(0).GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>(photoPath);
		    		}
		    		else Destroy(currentItem.transform.GetChild(2).GetChild(0).gameObject);
	    			break;
	    		}
	    		current = "";
	    	}
	    	else
	    	{
	    		current = current + content[i];		
	    	}
	    }
	    	
	    currentItem.GetComponent<ListItemExpander>().iconId = int.Parse(current);	
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
	
	public void CloseAll(int a) 
	{
		for (int i=0;i<transform.childCount;i++) 
		{
			if (i == a) {
				if (outlines.GetChild(i).GetChild(0).GetComponent<Image>().color.a == 1) 
				{
					outlines.GetChild(i).GetChild(0).GetComponent<Image>().color = new Color(1,1,1,0);
					outlines.GetChild(i).GetComponent<Image>().enabled = false;
				}
				else 
				{
					outlines.GetChild(i).GetChild(0).GetComponent<Image>().color = new Color(1,1,1,1);
					outlines.GetChild(i).GetComponent<Image>().enabled = true;
				}
				if (transform.GetChild(i).gameObject.TryGetComponent<ListItemExpander>(out ListItemExpander exp))
				{
					exp.Expand(0);
				}
				continue;
			}
			if (transform.GetChild(i).gameObject.TryGetComponent<ListItemExpander>(out ListItemExpander expander))
			{
				expander.Expand(-1);
			}
			if (outlines.GetChild(i).childCount == 0) continue;
			outlines.GetChild(i).GetChild(0).GetComponent<Image>().color = new Color(1,1,1,0);
			outlines.GetChild(i).GetComponent<Image>().enabled = false;
		}
	}
}
