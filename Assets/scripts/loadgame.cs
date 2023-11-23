using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loadgame : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("game");
    }
    public void PlaysingleGame()
    {
        SceneManager.LoadScene("Singleplayer game");
    }
    public void loadcustomization()
    {
        SceneManager.LoadScene("customization");
    }
    public void loadextras()
    {
        SceneManager.LoadScene("extras");
    }
    public void loadchains()
    {
        SceneManager.LoadScene("chained");
    }
    public void loadice()
    {
        SceneManager.LoadScene("ice game");
    }
}
