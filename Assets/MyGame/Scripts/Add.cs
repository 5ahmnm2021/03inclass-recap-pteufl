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

    //public Color rot = Color.red;
    //public Color weiss = Color.white;

    public float n1Float;
    public float n2Float;
    public bool num1 = true;
    public bool num2 = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddInputFields()
    {
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

        Debug.Log("a" + n1Float + "b" + n2Float);

        if (num1 == true && num2 == true)
        {
            sumText.text = (n1Float + n2Float).ToString();
            Debug.Log("Die Addition ergibt: " + sumText.text);
        }
    }
}
