using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetInfoControl : MonoBehaviour {

    [SerializeField]
    public static GetInfoControl control;

    //this is a data container, i'll serialize it so i can see the data
    [Header("Data Container")]
    [SerializeField]
    private string _name;
    [SerializeField]
    private int _phoneNumber;
    //release the serializeField and Header after use

    public string Getset_Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int Getset_phoneNumber
    {
        get { return _phoneNumber; }
        set { _phoneNumber = value; }
    }
    

    //hold this so this object isn't blow himself up
    private void Awake()
    {
        if(control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        } else if (control != this)
        {
            Destroy(gameObject);
        }
    }

}
