using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SendText : MonoBehaviour {

    [SerializeField]
    InputField inpName, inpAge;

    protected string _Name, _Age;

    //for neater way
    protected string testNeat
    {
        get { return testNeat; }
        set { this.testNeat = value; }
    }
    //only a test.....above

    //getter-setter start
    public string NameIs
    {
        get { return _Name; }
        set { _Name = value; }
    }

    public string AgeIs
    {
        get { return _Age; }
        set { _Age = value; }
    }
    //getter-setter end
	
    //send data to sky
    public void SendData()
    {
        /*
         * so i was learning things about getter and setter in the other day (in Android Studio),
         * and i was curious about "send something from getter-setter and normally -send it directly to variable(s)-"
         * and to learn that in a better way, i made this.....
         */

        _Name = inpName.text.Trim().ToString(); 
        AgeIs = inpAge.text.Trim().ToString();

        if (!_Name.Equals("") && !_Age.Equals(""))
        {
            //show this to log
            Debug.Log("Name: " + _Name +
                "\nAge: " + AgeIs);

            //move to scene 1
            SceneManager.LoadScene(1);

        } else { Debug.Log("OUI!, YOU SHALL NOT PASS O_O"); }

        //success

    }

}
