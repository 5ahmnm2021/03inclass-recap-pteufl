using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    void Start()
    {
       
    }

    void Update()
    {
        
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("01ColorScene");
    }

    public void ChangeScene2()
    {
        SceneManager.LoadScene("02NumberScene");
    }

    public void ChangeScene3()
    {
        SceneManager.LoadScene("00WelcomeScene");
    }
}
