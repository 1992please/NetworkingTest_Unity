using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StarterSceneManager : MonoBehaviour {

    public string TerminalScene;
    public string ServerScene;

    public void OpenServerScene()
    {
        SceneManager.LoadScene(ServerScene);
    }

    public void OpenTerminalScene()
    {
        SceneManager.LoadScene(TerminalScene);
    }
}
