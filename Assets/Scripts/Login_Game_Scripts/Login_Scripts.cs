using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // добавит SceneManagement для управоения сценами

public class Login_Scripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void login()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);  // загружает сцену под индексом следующим после текущей


    }
}
