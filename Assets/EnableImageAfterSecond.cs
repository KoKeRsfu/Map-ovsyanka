using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableImageAfterSecond : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
	{
		this.GetComponent<Button>().onClick.AddListener(EnableImg);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
	public void EnableImg() 
	{
		StartCoroutine("EnableImage");
	}
    
	public IEnumerator EnableImage()
	{
		this.transform.parent.parent.GetComponent<OutlinestoContent>().DisableOutlineImages();
		yield return new WaitForSeconds(0.01f);
		this.transform.parent.GetComponent<Image>().enabled = true;
		this.transform.parent.parent.GetComponent<OutlinestoContent>().Outline();
	}
}
