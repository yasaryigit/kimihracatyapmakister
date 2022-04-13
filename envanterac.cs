using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class envanterac : MonoBehaviour
{
    public GameObject envanter;


   
    
    // Start is called before the first frame update
    void Start()
    {
       envanter.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void envanterac1()
    {
        envanter.SetActive(true);
    }
}
