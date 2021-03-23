using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public void StartScenes()
    {
        SceneManager.LoadScene("StarScenes");
        Screen.SetResolution(2960, 1440, true);
    }
    public void MainStage()
    {
        SceneManager.LoadScene("MainStage");
        Screen.SetResolution(2960, 1440, true);
    }
    /*public void Stage()
    {
        SceneManager.LoadScene("InGame");
    }*/
    public void Shop()
    {
        SceneManager.LoadScene("Shop");
        Screen.SetResolution(2960, 1440, true);
    }
    public void GoOut()
    {
        Application.Quit();
    }
    public void Resoulution()    //해상도 설정 
    {
        Screen.SetResolution(2960, 1440, true);
    }
}
