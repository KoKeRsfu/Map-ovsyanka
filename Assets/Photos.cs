using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Photos : MonoBehaviour
{
    
	public void ChangePhoto(int id) 
	{
		string photoload_path = "Ovsyanka_Map/Photos/photo_" + id;
		Sprite photoload_sprite = Resources.Load<Sprite>(photoload_path);
		this.transform.GetChild(0).GetComponent<Image>().sprite = photoload_sprite;
	}
}
