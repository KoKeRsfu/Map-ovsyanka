﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
	[SerializeField] FrameManager fm;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
	public void NextFrame() 
	{
		fm.NextFrame();
	}
	
	public void PrevFrame()
	{
		fm.PrevFrame();
	}
}
