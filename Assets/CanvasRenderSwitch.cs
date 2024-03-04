using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasRenderSwitch : MonoBehaviour
{
    void Start()
    {
	    this.gameObject.GetComponent<Canvas>().renderMode = RenderMode.WorldSpace;
    }
}
