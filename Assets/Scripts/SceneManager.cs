using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    void Start()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }

    public void LoadScene() 
    {
        int currentSceneIndex = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = (currentSceneIndex + 1);

        if (nextSceneIndex == UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings) {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
            currentSceneIndex = 0;
            Debug.LogWarning("No more scenes to load. Loading MainMenu.");
            return;
            }

        UnityEngine.SceneManagement.SceneManager.LoadScene(nextSceneIndex);
    }
}
