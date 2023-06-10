using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour {
	// Update is called once per frame
		    public GameObject menu;
            public Timer timer;
     private bool isShowing;
	 public int correct;
 
     void Update() {
         if (correct==12) {
			correct=0;
            timer.timerIsRunning=false;
             isShowing = !isShowing;
             menu.SetActive(isShowing);
         }
		// Debug.Log(correct);
}
}
