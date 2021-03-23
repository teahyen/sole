using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField]
    public GameObject menuSet;
    // Start is called before the first frame update
    private void Start()
    {
        menuSet.SetActive(false);
    }
    public void Setting()
    {
        if (menuSet.activeSelf)
        {
            menuSet.SetActive(false);
            Time.timeScale = 1;
        }
        else
        {
            menuSet.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void Twich()
    {
        Application.OpenURL("https://www.twitch.tv/gumonji");
    }
    public void Bugalarm(string testToCopy)
    {
        TextEditor editor = new TextEditor
        {
            text = testToCopy
        };
        editor.SelectAll();
        editor.Copy();
    }
}
