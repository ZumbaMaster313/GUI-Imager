using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotate : MonoBehaviour {

    public Button yourButton;

    public Transform Image;

    int speed = -5;

    // Use this for initialization
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        Image.transform.Rotate(0, 0, speed);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

