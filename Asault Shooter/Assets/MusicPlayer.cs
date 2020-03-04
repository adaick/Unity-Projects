using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadSceneOne", 2f);
    }

    // Update is called once per frame
    void LoadSceneOne()
    {
        SceneManager.LoadScene(1);
    }
}
