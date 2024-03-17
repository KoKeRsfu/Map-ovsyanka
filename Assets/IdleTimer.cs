using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleTimer : MonoBehaviour
{
	
 float idle_lim = 60.0f;
 float last_ui = 0.0f;
 bool idle = false;

 void FixedUpdate() 
 { 
	 if (Input.anyKeyDown) 
		 {
		 if (idle) 
		 {
			 idle = false;
		 } 
		 last_ui = Time.time;
		}
	 if ( ( Time.time - last_ui ) > idle_lim ) { 
		 idle = true;
		 this.GetComponent<FrameManager>().SetFrame(0);
	 } 
 }
 
}
