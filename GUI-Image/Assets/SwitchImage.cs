﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SwitchImage : MonoBehaviour {


    Image m_Image;
    // Use this for initialization
    public Sprite m_Sprite;

    bool changeA = false;
   
	void Start ()
    {
        m_Image = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            m_Image.sprite = m_Sprite;
        }
    }
}
