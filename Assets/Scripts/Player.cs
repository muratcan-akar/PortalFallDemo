using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject PortalOut;
   
    public Vector3 InPortalVector;
    public Animator PlayerAnimator;
    public Portal _Portal;
    public GameObject ControlButton;
    public GameManager Game_Manager;
    public UiManager Ui_Manager;
   

    public float Speed;
    public bool GameStart=false;
    // Oyunun baslangicinda kontrol etme butonunu kapat oyuncunun gelene kadar gosterme
   
    void Start()
    {
        ControlButton.SetActive(false);
       
        PortalOut.SetActive(false);
    }
    //carpma tepkimeleri
    private void OnTriggerEnter(Collider other)
    {
        //Oyuncu portalý acan tetige carptýgýnda portalý ve kontrol tusunu ac
        if (other.gameObject.tag == "Trigger")
        {
            PortalOut.SetActive(true);
            ControlButton.SetActive(true);
        }
        // oyuncu engele cartiginda oyuncunun yanma animasyonunu calistir ui yoneticisinin paneli acma fonksiyonunu calistir 
        if (other.gameObject.tag == "Obstacle")
        {
            PlayerAnimator.SetTrigger("GameOver");
            Debug.Log("Engele Carptý");
            Ui_Manager.GameOverPanelOpen();
        }

        //Oyuncu tranboline carptiginda oyuncunun oyunu bitirme animasyonunu calistir ui yötecisine kazanma panelini acma fonksiyonunu calistir
        if (other.gameObject.tag == "Finish")
        {

           
            Debug.Log("Oyun Bitti");
            PlayerAnimator.SetTrigger("FinishGame");
            Ui_Manager.WinnerPanelOpen();
        }
       
    }
    //Oyuncu portalin icindeyken oyuncunun animasyonunu durdur dusme hizini durdur vectorunu portalin icinde iken sahne disina gotur
    public void Inportal()
    {
        PlayerAnimator.speed = 0;
        Speed = 0;
       transform.position = InPortalVector;

    }
    // oyuncu portal dan cikacagi zaman oyuncunun vectorunu cikis potalýna getir control butonunu kapat ve portali sonraki engele göturecek fonkisyonu calýstýr
    public void OutPortal()
    {
        transform.position = PortalOut.transform.position;
        _Portal.PortalNextObsticle();
        ControlButton.SetActive(false);
       

    }
    

    // oyuncunun dusme hýzý
    void Update()
    {
      
            transform.Translate(0, Speed*Time.deltaTime, 0);
    }
}
