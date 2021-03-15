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

    public Color rot = Color.red;
    public Color weiss = Color.white;

    public float n1Float;
    public float n2Float;

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
        try
        {
            n1Float = float.Parse(inputField1.text);
            inputField1.image.color = weiss;
            message.text = "";
        }
        catch (System.Exception)
        {
            message.text = "Geben Sie eine gültige Zahl ein";
            inputField1.image.color = rot;
        }

        try
        {
            n2Float = float.Parse(inputField2.text);
            inputField2.image.color = weiss;
        }

        catch (System.Exception)
        {
            message.text = "Geben Sie eine gültige Zahl ein";
            inputField2.image.color = rot;
        }

        sumText.text = (n1Float + n2Float).ToString();
        Debug.Log("Die Addition ergibt: " + sumText.text);
    }
}
