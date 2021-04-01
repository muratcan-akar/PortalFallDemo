using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{
    public Scrollbar _EnergyBar;
    public Player _Player;
    public GameManager _GameManager;
    public bool InPortal;
    //Baslangicta oyuncu portalin icinde degil 
    void Start()
    {
        InPortal = false;
       

    }
    //Oyuncu portalin icine girdigi zaman inportali true yap ve enerji bosaltici yi calistir
    public void PlayerInPortal()
    {
        InPortal = true;
        StartCoroutine(BarFull());
    }
    //Oyuncu portalin icinden ciktigi zaman inportali false yap
    public void PlayerOutPortal()
    {
        InPortal = false;
       
    }
    //enerji bar yöneticisi
    IEnumerator BarFull()
    {
        yield return new WaitForSeconds(0.1f);
        //inportal true ise(oyuncu portalin icinde ise ) bari doldur
        if (InPortal)
        {
            _EnergyBar.size = _EnergyBar.size - 0.01f;
            StartCoroutine(BarFull());
        }
        //inportal false ise(oyuncu portalin icinde degil ise ) bari bosalt
        if (!InPortal)
        {
            _EnergyBar.size = _EnergyBar.size + 0.01f;
            StartCoroutine(BarFull());

        }
       
    }

    // eger bar tamamen bosaldi ise portaldan cýkma kodunu calistir
    void Update()
    {
        if (_EnergyBar.size == 0)
        {
           
           
            _GameManager.ButtonUP();

        }
    }
}
