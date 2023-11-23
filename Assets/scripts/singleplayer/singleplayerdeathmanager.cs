using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class singleplayerdeathmanager : MonoBehaviour
{
    
    [SerializeField] Text scoretext;
    public p1health p1health;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(p1health.health == 0)
        {
                loadscene();
        }
    }

    public void loadscene()
    {
        string datatokeep = scoretext.text;
        staticdata.valuetokeep = datatokeep;
        SceneManager.LoadScene("singleplayer end");
    }
}
