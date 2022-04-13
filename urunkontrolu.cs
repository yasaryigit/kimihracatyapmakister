using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class urunkontrolu : MonoBehaviour
{
    
    public TextMeshProUGUI urun1sayiyazi;
    public TextMeshProUGUI urun2sayiyazi;
    public TextMeshProUGUI urun3sayiyazi;

    public TextMeshProUGUI urun4sayiyazi;
    public TextMeshProUGUI urun5sayiyazi;
    public TextMeshProUGUI urun6sayiyazi;

    public TextMeshProUGUI urun7sayiyazi;
    public TextMeshProUGUI urun8sayiyazi;
    public TextMeshProUGUI urun9sayiyazi;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        urun1sayiyazi.text = general.urun1_sayi.ToString();
        urun2sayiyazi.text = general.urun2_sayi.ToString();
        urun3sayiyazi.text = general.urun3_sayi.ToString();

        urun4sayiyazi.text = general.urun4_sayi.ToString();
        urun5sayiyazi.text = general.urun5_sayi.ToString();
        urun6sayiyazi.text = general.urun6_sayi.ToString();

        urun7sayiyazi.text = general.urun7_sayi.ToString();
        urun8sayiyazi.text = general.urun8_sayi.ToString();
        urun9sayiyazi.text = general.urun9_sayi.ToString();
    }
    public void urunal1()
    {
        if (general.sermaye > 0)
        {
            general.sermaye -=general.anlikdolar*general.urun1_fiyat;
            general.urun1_sayi +=1;
        }
    }

    public void urunsat1()
    {
        if (general.urun1_sayi > 0)
        {
            general.sermaye += general.anlikdolar*general.urun1_fiyat;
            general.urun1_sayi -= 1;
        }
    }

    public void urunal2()
    {
        if (general.sermaye > 0)
        {
            general.sermaye -=general.anlikdolar*general.urun2_fiyat;
            general.urun2_sayi += 1;
        }
    }

    public void urunsat2()
    {
        if (general.urun2_sayi > 0)
        {
            general.sermaye += general.anlikdolar*general.urun2_fiyat;
            general.urun2_sayi -= 1;
        }
    }

    public void urunal3()
    {
        if (general.sermaye > 0)
        {
            general.sermaye -=general.anlikdolar*general.urun3_fiyat;
            general.urun3_sayi += 1;
        }
    }

    public void urunsat3()
    {
        if (general.urun3_sayi > 0)
        {
            general.sermaye += general.anlikdolar*general.urun3_fiyat;
            general.urun3_sayi -= 1;
        }
    }

    public void urunal4()
    {
        if (general.sermaye > 0)
        {
            general.sermaye -= general.anlikdolar * general.urun4_fiyat;
            general.urun4_sayi += 1;
        }
    }

    public void urunsat4()
    {
        if (general.urun4_sayi > 0)
        {
            general.sermaye += general.anlikdolar * general.urun4_fiyat;
            general.urun4_sayi -= 1;
        }
    }

    public void urunal5()
    {
        if (general.sermaye > 0)
        {
            general.sermaye -= general.anlikdolar * general.urun5_fiyat;
            general.urun5_sayi += 1;
        }
    }

    public void urunsat5()
    {
        if (general.urun5_sayi > 0)
        {
            general.sermaye += general.anlikdolar * general.urun5_fiyat;
            general.urun5_sayi -= 1;
        }
    }

    public void urunal6()
    {
        if (general.sermaye > 0)
        {
            general.sermaye -= general.anlikdolar * general.urun6_fiyat;
            general.urun6_sayi += 1;
        }
    }

    public void urunsat6()
    {
        if (general.urun6_sayi > 0)
        {
            general.sermaye += general.anlikdolar * general.urun6_fiyat;
            general.urun6_sayi -= 1;
        }
    }

    public void urunal7()
    {
        if (general.sermaye > 0)
        {
            general.sermaye -= general.anlikdolar * general.urun7_fiyat;
            general.urun7_sayi += 1;
        }
    }

    public void urunsat7()
    {
        if (general.urun7_sayi > 0)
        {
            general.sermaye += general.anlikdolar * general.urun7_fiyat;
            general.urun7_sayi -= 1;
        }
    }

    public void urunal8()
    {
        if (general.sermaye > 0)
        {
            general.sermaye -= general.anlikdolar * general.urun8_fiyat;
            general.urun8_sayi += 1;
        }
    }

    public void urunsat8()
    {
        if (general.urun8_sayi > 0)
        {
            general.sermaye += general.anlikdolar * general.urun8_fiyat;
            general.urun8_sayi -= 1;
        }
    }

    public void urunal9()
    {
        if (general.sermaye > 0)
        {
            general.sermaye -= general.anlikdolar * general.urun9_fiyat;
            general.urun9_sayi += 1;
        }
    }

    public void urunsat9()
    {
        if (general.urun9_sayi > 0)
        {
            general.sermaye += general.anlikdolar * general.urun9_fiyat;
            general.urun9_sayi -= 1;
        }
    }
}
