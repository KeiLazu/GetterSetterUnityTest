using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetData : MonoBehaviour {

    [SerializeField]
    Text lblName, lblAge;
    
    SendText sendText;

    string _nameDisplay, _ageDisplay;

    private void Start()
    {
        //get name and age
        try
        {
            //put codes here.....


        } catch (Exception huehue) { Debug.Log(huehue); }
        //put it here
        try
        {
            lblName.text = "Da Name: " + _nameDisplay;
            lblAge.text = "Da Age: " + _ageDisplay;
        }
        catch (Exception except) { Debug.Log(except); }

    }

}
