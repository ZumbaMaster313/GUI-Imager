using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChnageColor : MonoBehaviour
{

    public Button yourButton;

    public Transform Image;


    // Use this for initialization
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        Renderer rend = GetComponent<Renderer>();
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        Image.GetComponent<Renderer>().material.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {

    }
}