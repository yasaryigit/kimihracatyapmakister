using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anamenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void play()
    {
        SceneManager.LoadScene(0);
    }

    public void info()
    {
        SceneManager.LoadScene(2);
    }

    public void quit()
    {
        Application.Quit();
    }
}
