using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform PortalTransform;
    public Transform _PLAYER;
    public Vector3 DeserdPosition;

    public bool InPortal;
  //baslangicta oyuncu potalýn icinde degil
    void Start()
    {
        InPortal = false;
    }

    // Kamera oyuncu portalin icinde olmadigi surece kameranin y eksenini sürekli onu takip edecek, portal dan cikinca da hizlica onun y eksenine gidecek sekilde ayarlanmasi
    void Update()
    {
        if (!InPortal)
        { 
            DeserdPosition = new Vector3(transform.position.x, _PLAYER.position.y-1f, transform.position.z);
            transform.position = Vector3.MoveTowards
               (transform.position, DeserdPosition, 20f * Time.deltaTime);
        }
       
    }
}
