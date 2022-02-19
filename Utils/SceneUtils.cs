using UnityEngine.SceneManagement;

public static class SceneUtils {
    static public void ReloadScene() { LoadScene(SceneManager.GetActiveScene().name); }
    static public void LoadScene(string sceneName) { SceneManager.LoadScene(sceneName); }
    static public void LoadScene (int sceneIndex) { SceneManager.LoadScene(sceneIndex); }
}
