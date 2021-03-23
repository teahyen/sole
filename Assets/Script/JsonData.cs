using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JsonData : MonoBehaviour
{
    public PlayerData playerData;
    [ContextMenu("To Json")]
    public void SaveData()//저장 버튼
    {
        GameManager.Instance.clear = playerData.Jclear;
        GameManager.Instance.CS = playerData.JCS;
        string jsonData = JsonUtility.ToJson(playerData, true);
        string path = Application.persistentDataPath + "/playerData.json";
        File.WriteAllText(path, jsonData);
        Debug.Log("저장되었습니다.");
        
    }
    [ContextMenu("From Json")]
    public void LoadData() //데이터 불러오기
    {
        string path = Application.persistentDataPath + "/playerData.json";
        string jsonData = File.ReadAllText(path);
        playerData = JsonUtility.FromJson<PlayerData>(jsonData);
        Debug.Log("불러왔습니다.");
        playerData.JCS = GameManager.Instance.CS;
        playerData.Jclear = GameManager.Instance.clear;
    }
    public void OnApplicationQuit()
    {
        string path = Application.persistentDataPath + "/playerData.json";
        string jsonData = File.ReadAllText(path);
        playerData = JsonUtility.FromJson<PlayerData>(jsonData);
        Debug.Log("불러왔습니다.");
        GameManager.Instance.clear = playerData.Jclear;
        GameManager.Instance.CS = playerData.JCS;
    }
    public void OnApplicationFocus(bool focus)
    {
        playerData.JCS = GameManager.Instance.CS;
        playerData.Jclear = GameManager.Instance.clear;
        string jsonData = JsonUtility.ToJson(playerData, true);
        string path = Application.persistentDataPath + "/playerData.json";
        File.WriteAllText(path, jsonData);
        Debug.Log("저장되었습니다.");
    }

    [System.Serializable]
    public class PlayerData
    {
        //클리어 여부 2
        public int Jclear;
        //클리어 여부
        public List<bool> JCS = new List<bool>(0);
    }
}
