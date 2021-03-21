using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Add : MonoBehaviour
{
    public InputField inputField1;
    public InputField inputField2;
    public Text message;
    public Text sumText;

    public bool num1 = true;
    public bool num2 = true;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void AddInputFields()
    {
        float n1Float = 0;
        float n2Float = 0;

        string errorMsg = "Geben Sie eine gültige Zahl ein";

        try
        {
            n1Float = float.Parse(inputField1.text);
            num1 = true;
            inputField1.image.color = Color.white;
            message.text = "";
        }
        catch (System.Exception)
        {
            message.text = errorMsg;
            inputField1.image.color = Color.red;
            num1 = false;
        }

        try
        {
            n2Float = float.Parse(inputField2.text);
            inputField2.image.color = Color.white;
            num2 = true;
        }

        catch (System.Exception)
        {
            message.text = errorMsg;
            inputField2.image.color = Color.red;
            num2 = false;
        }

        if (num1 == true && num2 == true)
        {
            sumText.text = (n1Float + n2Float).ToString();
        }
    }
}
