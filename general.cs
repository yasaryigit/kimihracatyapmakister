using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.UI;

public class general : MonoBehaviour
{ 
    public float dolar = 1.0f;   //dolar de�eri
    public float euro = 1.0f;    //euro de�eri

    public float degisimdolar;      //dolardaki anl�k de�i�im
    public float degisimeuro;      //eurodaki anl�k de�i�im

    private int kontrol = 100;     //while d�ng�s�n� kontrol eder  degisim()
    private int kontroldolar = 0;   //dolar de�erinin art�p yada azalaca��n� kontrol eder
    private int kontroleuro = 0;   //euro de�erinin art�p yada azlaca��n� kontrol eder

    public TextMeshProUGUI tmpdolar;  //dolar� ekrana yazd�ran de�i�ken
    public TextMeshProUGUI tmpeuro;   //euroyu ekrana yazd�ran de�i�ken


    public static int sermaye;


    public TextMeshProUGUI sermayeyazi;

   
    public static int urun1_fiyat = 12500;
    public static int urun2_fiyat = 23450;               //amerika �r�n fiyatlar�
    public static int urun3_fiyat = 34570;

    public static int urun4_fiyat = 13453;
    public static int urun5_fiyat = 68321;              //rusya �r�n fiyatlar�
    public static int urun6_fiyat = 987231;

    public static int urun7_fiyat = 10000;
    public static int urun8_fiyat = 21000;              //kanada �r�n fiyatlar�
    public static int urun9_fiyat = 31000;

    public static int urun1_sayi;
    public static int urun2_sayi;                  //amerika �r�n say�lar�
    public static int urun3_sayi;

    public static int urun4_sayi;
    public static int urun5_sayi;                  //rusya �r�n say�lar�
    public static int urun6_sayi;

    public static int urun7_sayi;
    public static int urun8_sayi;                  //kanada �r�n say�lar�
    public static int urun9_sayi;


    public static int anlikdolar;
    public static int anlikeuro;
    
    public string sermayeerroryazi = "L�tfen Borcunuzu �deyiniz...";
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
                    }                                            //bu karar yap�s� dolar de�i�imini kontrol eder
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

                        euro -= degisimeuro;                      //Bu karar yap�s� euro de�i�imini kontrole eder
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
            tmpdolar.text = dolar.ToString();            //dolar� ekrana yazd�r�r
            tmpeuro.text = euro.ToString();              //euroyu ekrana yazd�r�r
            yield return new WaitForSeconds(5);                 //dolar ve euro de�erinin ne s�kl�kla de�i�ece�ini kontrol eder
            continue;
        }
    }
}

