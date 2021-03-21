using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Switch : MonoBehaviour
{
    public Image imageColor;
    private int count = 0;

    void Start()
    {
        imageColor.color = new Color(102 / 255f, 47 / 255f, 84 / 255f);
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (count == 0)
            {
                imageColor.color = new Color(255 / 255f, 205 / 255f, 25 / 255f);
            }

            if (count == 1)
            {
                imageColor.color = new Color(95 / 255f, 34 / 255f, 0);
            }
            if (count == 2)
            {
                imageColor.color = new Color(207 / 255f, 63 / 255f, 21 / 255f);
            }
            if (count == 3)
            {
                imageColor.color = new Color(102 / 255f, 47 / 255f, 84 / 255f);
            }

            count++;

            if (count == 4)
            {
                count = 0;
            }

        }
    }
}