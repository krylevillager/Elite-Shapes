using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathmanager : MonoBehaviour
{
    public p1health p1health;
    public p2health p2health;

    public string winner = "none";
    
    string sceneName;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene ();

        string sceneName = currentScene.name;
        
        Debug.Log("Active Scene is '" + sceneName + "'.");
        if(p1health.health == 0)
        {
            if(sceneName == "game")
            {
                winner = "player 2";
                SceneManager.LoadScene("player 2 wins");
            }else if(sceneName == "ice game")
            {
                SceneManager.LoadScene("player 2 wins ice");
            }else if(sceneName == "chained")
            {
                SceneManager.LoadScene("player 2 wins chained");
            }
        }else if(p2health.health == 0)
        {
            if(sceneName == "game")
            {
                winner = "player 1";
                SceneManager.LoadScene("player 1 wins");
            }else if(sceneName == "ice game")
            {
                SceneManager.LoadScene("player 1 wins ice");
            }else if(sceneName == "chained")
            {
                SceneManager.LoadScene("player 1 wins chained");
            }
        }else{
            winner = "none";
        }
    }
}
