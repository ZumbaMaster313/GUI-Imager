﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ImageSelector : MonoBehaviour {

    public Button yourButton;

    // Use this for initialization
    void Start ()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
       
    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}
