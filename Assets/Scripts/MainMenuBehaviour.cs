using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuBehaviour : MonoBehaviour {

    // Use this for initialization


    public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
    
}
