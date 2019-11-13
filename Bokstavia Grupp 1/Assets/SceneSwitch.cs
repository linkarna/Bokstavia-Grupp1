using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject Start;
    public void GoToMenuScene()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Additive);

        Start.SetActive(false);

    }

    public void GoToFriend()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void GoToStatics()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

    public void GoToMedals()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void GoToBack()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Additive);
    }
}
