using UnityEngine;

public class SceneManager : MonoBehaviour
{

    // PREFACE: scriptet assumer at den første scene er den med index 0 (main menu formentligt) -
    // hvis det er ikke, så skal vi lige ændre nogle ting.
    private int _currentSceneIndex = 0;
    private int _nextSceneIndex = 0;
    
    // dont mind de lange parametrer, det er basically bare en måde at få fat i scenenavnet fra indexen.
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // når den her bliver called så skifter den til næste scene baseret på den nuværende scenes index.
    // virker også når vi er i mini games, da de bliver called seperat fra main scenes.
    // desuden skifter den bare tilbage til scenen med index 0 når den bliver called ved sidste scene.
    public void LoadNextMainScene() 
    {
        _currentSceneIndex = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
        if (_currentSceneIndex == UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings - 1) {
            Debug.LogWarning("No more scenes to load. Loading first scene.");
            LoadScene(UnityEngine.SceneManagement.SceneManager.GetSceneByBuildIndex(0).name);
            return;
        }
        
        _nextSceneIndex = (_currentSceneIndex + 1) % UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings;

        LoadScene(UnityEngine.SceneManagement.SceneManager.GetSceneByBuildIndex(_nextSceneIndex).name);
    }

    // den der faktisk ændrer scenen - den her skal vi call med mini game navnene når vi når dertil.
    public void LoadScene(string sceneName) // 
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}