using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetData : MonoBehaviour
{

    [SerializeField]
    Text lblName, lblAge;

    SendText sendText;

    static string _nameDisplay, _ageDisplay;
    static string nameDisplay
    {
        get { return _nameDisplay; }
        set { _nameDisplay = value; }
    }

    static string ageDisplay
    {
        get { return _ageDisplay; }
        set { _ageDisplay = value; }
    }

    private void Start()
    {
        //get name and age

        //put codes here.....
        nameDisplay = SendText.sendingText.NameIs;
        ageDisplay = SendText.sendingText.AgeIs;

        //put it here
        lblName.text = "Da Name: " + _nameDisplay;
        lblAge.text = "Da Age: " + ageDisplay;

        //waow, success....

    }

}
