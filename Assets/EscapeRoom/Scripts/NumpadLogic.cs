using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;
using TMPro;

public class NumpadLogic : MonoBehaviour {

    public string winCode = "4236";
    protected string currentCode = "0000";
    public UnityEvent onWin;
    public TextMeshProUGUI display;


    void Awake() {
        currentCode = display.text;
    }

    public void ButtonPressed(int val) {
        currentCode = currentCode.Substring(1) + val.ToString();
        display.text = currentCode;

        if (currentCode == winCode) {
            Debug.Log("WINNER!");
            if (onWin != null) {
                onWin.Invoke();
            }
        }
    }
}
