using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class satiskontrolu : MonoBehaviour
{
    public int kontrol = 100;

    public int amerikaistek1;
    public int rusyaistek1;
    public int kanadaistek1;

    public int amerikaistek2;
    public int rusyaistek2;
    public int kanadaistek2;




    public TextMeshProUGUI urunistek1;
    public TextMeshProUGUI urunistek2;


    public int urunfiyat1 = 23650;
    public int urunfiyat2 = 53200;


    public GameObject buton1;
    public GameObject buton2;
  
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(satiskontrol());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator satiskontrol()
    {

        while(kontrol == 100)
        {
            
          
            amerikaistek1 = Random.Range(4,6);
            rusyaistek1 = Random.Range(4, 6);
            kanadaistek1 = Random.Range(4, 6);

            amerikaistek2 = Random.Range(4, 6);
            rusyaistek2 = Random.Range(4, 6);
            kanadaistek2 = Random.Range(4, 6);



            if (amerikaistek1 == 5)
            {
                urunistek1.text = "Amerika";
                buton1.SetActive(true);
            }
            else if (rusyaistek1 == 5)
            {
                urunistek1.text = "Rusya";
                buton1.SetActive(true);
          
            }
            else if (kanadaistek1 == 5)
            {
                urunistek1.text = "Kanada";
                buton1.SetActive(true);
            }
            else if (amerikaistek2 == 5)
            {
                urunistek2.text = "Amerika";
                buton2.SetActive(true);
            }
            else if (rusyaistek2 == 5)
            {
                urunistek2.text = "Rusya";
                buton2.SetActive(true);
            }
            else if (kanadaistek2 == 5)
            {
                urunistek2.text = "Kanada";
                buton2.SetActive(true);
            }
            else
            {
                urunistek2.text = "ÝSTEK YOK";
                buton2.SetActive(false);
                urunistek1.text = "ÝSTEK YOK";
                buton1.SetActive(false);
            }









            yield return new WaitForSeconds(5);
        }


    
    }
    public void urun1satisamerika()
    {
        if (amerikaistek1 == 5)
        {
            general.sermaye += urunfiyat1;
        }
    }

    public void urun1satisrusya()
    {
        if (rusyaistek1 == 5)
        {
            general.sermaye += urunfiyat1;
        }
    }

    public void urun1satiskanada()
    {
        if (kanadaistek1 == 5)
        {
            general.sermaye += urunfiyat1;
        }
    }

    public void urun2satisamerika()
    {
        if (amerikaistek2 == 5)
        {
            general.sermaye += urunfiyat2;
        }
    }

    public void urun2satisrusya()
    {
        if (rusyaistek2 == 5)
        {
            general.sermaye += urunfiyat2;
        }
    }

    public void urun2satiskanada()
    {
        if (kanadaistek2 == 5)
        {
            general.sermaye += urunfiyat2;
        }
    }
}
