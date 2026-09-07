using UnityEngine;
using UnityEngine.SceneManagement;

public class UITittleScript : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
