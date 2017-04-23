using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SetInfoControl : MonoBehaviour
{
    private string _name;
    private int _phoneNumber;

    [Header("Data Holder")]
    [SerializeField]
    protected InputField Name;

    [SerializeField]
    protected InputField PhoneNumber;

    public void Sending()
    {
        if (Name.text.Trim().Equals("") || PhoneNumber.text.Trim().Equals(""))
        {
            Debug.Log("Field is Empty");
        }
        else
        {
            _name = Name.text;
            _phoneNumber = int.Parse(PhoneNumber.text);

            GetInfoControl.control.Getset_Name = _name;
            GetInfoControl.control.Getset_phoneNumber = _phoneNumber;

            SceneManager.LoadScene(3);
        }
    }
}