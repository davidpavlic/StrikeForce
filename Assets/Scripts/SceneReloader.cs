using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneReloader : MonoBehaviour
{
    // Method to reload the current scene
    public static void ReloadCurrentScene()
    {
        // Get the active scene's name
        string sceneName = SceneManager.GetActiveScene().name;
        
        // Load the scene with the same name
        SceneManager.LoadScene(sceneName);
    }
}
