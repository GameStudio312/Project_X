using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // добавит SceneManagement для управоения сценами

public class Start_Game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // При нажатии в любом месте переходит на экран Логина
        if (Input.GetMouseButtonDown(0))
         {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);  // загружает сцену под индексом следующим после текущей

         }

        
    }
}
