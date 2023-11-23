using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loadmainmenu : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("title");
    }
    public void loadgame()
    {
        SceneManager.LoadScene("game");
    }
    public void loadcustomization()
    {
        SceneManager.LoadScene("customization");
    }
}
