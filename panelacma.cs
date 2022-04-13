using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelacma : MonoBehaviour
{
    public GameObject amerikapanel;
    public GameObject rusyapanel;
    public GameObject kanadapanel;
    public GameObject trpanel;
    // Start is called before the first frame update
    void Start()
    {
        amerikapanel.SetActive(false);
        rusyapanel.SetActive(false);
        kanadapanel.SetActive(false);
        trpanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void amerikapaneliac()
    {
        amerikapanel.SetActive(true);
    }

    public void rusyapaneliac()
    {
        rusyapanel.SetActive(true);
    }

    public void kanadapaneliac()
    {
        kanadapanel.SetActive(true);
    }

    public void amerikapanelikapa()
    {
        amerikapanel.SetActive(false);
    }

    public void rusyapanelikapa()
    {
        rusyapanel.SetActive(false);
    }

    public void kanadapanelikapa()
    {
        kanadapanel.SetActive(false);
    }

    public void trpaneliac()
    {
        trpanel.SetActive(true);
    }
    
    public void trpanelikapa()
    {
        trpanel.SetActive(false);
    }
}
