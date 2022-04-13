using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ekrangameover : MonoBehaviour
{
    // Start is called before the first frame update


    public TextMeshProUGUI topskor;

    void Awake()
    {
        topskor.text = general.sermaye.ToString();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cikis()
    {
        Application.Quit();
    }

    public void anamenu()
    {
        SceneManager.LoadScene(1);
        general.sermaye = 1000000;
    }
}
