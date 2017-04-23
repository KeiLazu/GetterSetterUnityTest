using UnityEngine;
using UnityEngine.UI;

public class GetFromControl : MonoBehaviour
{
    [Header("Output")]
    [SerializeField]
    private Text lblName;

    [SerializeField]
    private Text lblPhone;

    private void Start()
    {
        lblName.text = "Name: " + GetInfoControl.control.Getset_Name;
        lblPhone.text = "Phone Number: " + GetInfoControl.control.Getset_phoneNumber.ToString();
    }
}