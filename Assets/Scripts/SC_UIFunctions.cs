using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SC_UIFunctions : MonoBehaviour
{
    public GameObject rightFrame;
    public bool isEnabled = true;

    public void HideFrame()
    {
        isEnabled = !isEnabled;
        rightFrame.SetActive(isEnabled);
    }
    public void ButtonPointed ()
    {
        isEnabled = !isEnabled;
        rightFrame.SetActive(isEnabled);
    }

    public void ButtonUnpointed()
    {
        isEnabled = !isEnabled;
        rightFrame.SetActive(isEnabled);
    }
    public void LoadScene (string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Exit()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }
    
}
