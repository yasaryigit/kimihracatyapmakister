using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class gameover : MonoBehaviour
{   public float sure;
    public TextMeshProUGUI sureyazi;
    public int sure2;
    // Start is called before the first frame update
    void Start()
    {
        sure = 5;
    }

    // Update is called once per frame
    void Update()
    {
       
        sure -= Time.deltaTime;
        sureyazi.text = sure.ToString();
        if (sure <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}
