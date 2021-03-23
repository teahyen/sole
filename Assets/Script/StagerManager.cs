using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StagerManager : MonoBehaviour
{
    public GameObject cImage;
    private AudioSource Audio;
    [SerializeField]
    public AudioClip Is_Audio;

    public void Start()
    {
        cImage.SetActive(false);
        this.Audio = this.gameObject.AddComponent<AudioSource>();
        this.Audio.clip = this.Is_Audio;
        this.Audio.loop = false;
    }
    public void StartStage(int clickedStage)
    {
        if (GameManager.Instance.currentStage >=clickedStage)
        {
            SceneManager.LoadScene("Stage" + clickedStage);
            GameManager.Instance.currentStage =clickedStage;
            this.Audio.Play();
            Debug.Log("음악");
            GameManager.Instance.AJump =1 + GameManager.Instance.AJump;
        }
    }
}
