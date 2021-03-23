using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
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
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            cImage.SetActive(true);
            this.Audio.Play();
            Debug.Log("음악");
        }
    }
    public void GoMain()
    {
        if (GameManager.Instance.currentStage - 1 >= GameManager.Instance.clear)
        {
            SceneManager.LoadScene("MainStage");
            GameManager.Instance.CS[GameManager.Instance.clear] = true;
            GameManager.Instance.clear++;
        }
        else
        {
            SceneManager.LoadScene("MainStage");
        }
        if (GameManager.Instance.currentStage - 1 <= GameManager.Instance.clear)
        {
            GameManager.Instance.currentStage = GameManager.Instance.clear + 1;
        }
    }
}

