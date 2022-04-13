using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.UI;

public class general : MonoBehaviour
{ 
    public float dolar = 1.0f;   //dolar deðeri
    public float euro = 1.0f;    //euro deðeri

    public float degisimdolar;      //dolardaki anlýk deðiþim
    public float degisimeuro;      //eurodaki anlýk deðiþim

    private int kontrol = 100;     //while döngüsünü kontrol eder  degisim()
    private int kontroldolar = 0;   //dolar deðerinin artýp yada azalacaðýný kontrol eder
    private int kontroleuro = 0;   //euro deðerinin artýp yada azlacaðýný kontrol eder

    public TextMeshProUGUI tmpdolar;  //dolarý ekrana yazdýran deðiþken
    public TextMeshProUGUI tmpeuro;   //euroyu ekrana yazdýran deðiþken


    public static int sermaye;


    public TextMeshProUGUI sermayeyazi;

   
    public static int urun1_fiyat = 12500;
    public static int urun2_fiyat = 23450;               //amerika ürün fiyatlarý
    public static int urun3_fiyat = 34570;

    public static int urun4_fiyat = 13453;
    public static int urun5_fiyat = 68321;              //rusya ürün fiyatlarý
    public static int urun6_fiyat = 987231;

    public static int urun7_fiyat = 10000;
    public static int urun8_fiyat = 21000;              //kanada ürün fiyatlarý
    public static int urun9_fiyat = 31000;

    public static int urun1_sayi;
    public static int urun2_sayi;                  //amerika ürün sayýlarý
    public static int urun3_sayi;

    public static int urun4_sayi;
    public static int urun5_sayi;                  //rusya ürün sayýlarý
    public static int urun6_sayi;

    public static int urun7_sayi;
    public static int urun8_sayi;                  //kanada ürün sayýlarý
    public static int urun9_sayi;


    public static int anlikdolar;
    public static int anlikeuro;
    
    public string sermayeerroryazi = "Lütfen Borcunuzu Ödeyiniz...";
    public TextMeshProUGUI sermayeerror;
    private void Awake()
    {
        sermaye = 1000000;
        
    }
    void Start()
    {
        StartCoroutine(degisim());
    
    }

    void Update()
    {
       sermayeyazi.text = sermaye.ToString();
       anlikdolar = (int)dolar;
       anlikeuro = (int)euro;

        if (anlikdolar == 0)
        {
            anlikdolar = 1;

        }
       if (anlikeuro == 0)
        {
            anlikeuro =1;
        }

        if (sermaye < 0)
        {
            sermayeerror.text = sermayeerroryazi;
        }
        else
        {
            sermayeerror.text = "";
        }
    }
    IEnumerator degisim()
    {
        while (kontrol == 100)
        {
            degisimdolar = Random.Range(0.1f, 0.9f);
            degisimeuro = Random.Range(0.2f, 0.9f);
            kontroldolar = Random.Range(0,2);
            kontroleuro = Random.Range(0,2);
            
            if (dolar > 0)
            {
                if (dolar > degisimdolar)
                {
                    if (kontroldolar == 0)
                    {
                        dolar -= degisimdolar;
                    }                                            //bu karar yapýsý dolar deðiþimini kontrol eder
                    else if (kontroldolar == 1)
                    {
                        dolar += 3*degisimdolar;
                    }
                }
                else if (dolar < degisimdolar)
                {
                    if (kontroldolar == 0)
                    {
                        dolar -= degisimdolar - 0.5f;
                    }                                            
                    else if (kontroldolar == 1)
                    {
                        dolar += 2*degisimdolar;
                    }
                }
            }

            
            
            if (euro > 0)
            {
                if (euro > degisimeuro)
                {
                    if (kontroleuro == 0)
                    {

                        euro -= degisimeuro;                      //Bu karar yapýsý euro deðiþimini kontrole eder
                    }
                    else if (kontroleuro == 1)
                    {
                        euro += 2*degisimeuro;
                    }
                }
                else if (euro < degisimeuro)
                {
                    if (kontroleuro == 0)
                    {

                        euro -= degisimeuro - 0.5f;                      
                    }
                    else if (kontroleuro == 1)
                    {
                        euro += 2*degisimeuro;
                    }
                }
            }


            Debug.Log(dolar);
            Debug.Log(euro);
            //Debug.Log(anlikdolar);
            //Debug.Log(anlikeuro);
            tmpdolar.text = dolar.ToString();            //dolarý ekrana yazdýrýr
            tmpeuro.text = euro.ToString();              //euroyu ekrana yazdýrýr
            yield return new WaitForSeconds(5);                 //dolar ve euro deðerinin ne sýklýkla deðiþeceðini kontrol eder
            continue;
        }
    }
}

