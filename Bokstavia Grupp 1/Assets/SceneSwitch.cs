using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void GoToMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GoToFriend()
    {
        SceneManager.LoadScene("Friends");
    }

    public void GoToStatics()
    {
        SceneManager.LoadScene("Static");
    }

    public void GoToMedals()
    {
        SceneManager.LoadScene("Medals");
    }
}
