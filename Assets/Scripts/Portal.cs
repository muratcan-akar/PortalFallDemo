using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform Portal_;
    public GameObject OutPortal, InPortal;
    public Animator PortalAnimator;
    
    public Vector3 CreatInPortal;
    public Transform PlayerTransform;
    
   
  //Oyuncunun portal icine girmesi icin icine girecegi portali ac oyuncun y pozisyonuna getir portalin animasyonunu calistir
    public void PlayerInPortal ()
    {
        InPortal.SetActive(true);
        InPortal.transform.position = new Vector3(transform.position.x, PlayerTransform.position.y, transform.position.z);
        PortalAnimator.speed = 1;
    }

    //Oyuncu portaldan cikarken portali durdur  girdigi potali kapat
    public void PlayerOutPortal()
    {
        InPortal.SetActive(false);
        PortalAnimator.speed = 0;
        
    }
    // portalin sonra sonraki engele gitme fonksiyonu 1 saniye sonra calistir
    public void PortalNextObsticle()
    {
        Invoke("GoNextObsticle", 1f);
        
    }
    //Portali 25 birim assagiya diger engelin yanýna al,  portalin hareket animasyonunu oynat ve Portali oyuncu gelene kadar gösterme 
    public void GoNextObsticle()
    {

        Portal_.position = new Vector3(Portal_.position.x, Portal_.position.y - 25, Portal_.position.z);
        OutPortal.SetActive(false);
        PortalAnimator.speed = 1;


    }


   
}
