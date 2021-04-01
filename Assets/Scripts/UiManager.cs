using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public GameObject WinnerPanel,GameOverPanel;
    
    // Oyunun balangicinda panelleri gosterme
    void Start()
    {
        GameOverPanel.SetActive(false);
        WinnerPanel.SetActive(false);
    }
    // Restart butonuna basildiginde oyunu yeniden baslat
    public void RestartButton()
    {
        SceneManager.LoadScene("MainScene");
    }
    // Kazanma panelinini ac
    public void WinnerPanelOpen()
    {
        WinnerPanel.SetActive(true);
       
    }
    // Kaybetme panelinini ac
    public void GameOverPanelOpen()
    {
        GameOverPanel.SetActive(true);

    }

  
}
