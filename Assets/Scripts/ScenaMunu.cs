using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenaMunu : MonoBehaviour
{
    public void OnPlay()
    {
        SceneManager.LoadScene(1);
    }

    public void OnExit()
    {
        Application.Quit();
    }

    public void OnMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void OnRestart()
    {
        SceneManager.LoadScene(2);
    }

    public void OnLevel2()
    {
        SceneManager.LoadScene(3);
    }

    public void OnLevel3()
    {
        SceneManager.LoadScene(4);
    }


}
