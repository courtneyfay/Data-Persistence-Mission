using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("hitting start");
        // ColorPicker.Init();
        // // this will call the NewColorSelected function when the color picker has a color button clicked
        // ColorPicker.onColorChanged += NewColorSelected;
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void NewNameInputted(string name)
    {
        MainManager.Instance.PlayerName = name;
        Debug.Log(name);
    }

    public void Exit()
    {

        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
}
