using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public EnergyBar _EnergyBar;
    public Portal _Portal;
    public ParticleSystem Explosion;
    public CameraControl _Camera;
    public Animator PlayerAnimator;
    public Player _Player;
    public GameObject StartButtonGameObject;
    
    public Transform PlayerTransform;
    public Vector3 PlayerInPortalVector;
  

    // Start is called before the first frame update
    void Start()
    {
        Explosion.Stop(true);
        StartButtonGameObject.SetActive(true);
      
       
    }
   
    public  void StartButton()
    {
        Explosion.Play(true);
        PlayerAnimator.SetTrigger("Start");
        StartButtonGameObject.SetActive(false);


    }
    public void ButtonDown()
    {
        _EnergyBar.PlayerInPortal();

         _Camera.InPortal = true;


         _Portal.PlayerInPortal();


        _Player.Inportal();
         
      


       
        



    }
    public void ButtonUP()
    {
        _EnergyBar.PlayerOutPortal();
       _Camera.InPortal = false;
        _Portal.PlayerOutPortal();


        _Player.OutPortal();
       PlayerAnimator.speed = 1;
      
       
     


    }
  
    

    // Update is called once per frame
    void Update()
    {
       
        
    }
}
