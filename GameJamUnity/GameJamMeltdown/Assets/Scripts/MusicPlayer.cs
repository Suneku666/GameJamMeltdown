using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip[] musicArray;

    private AudioSource audioSource;

    static MusicPlayer instance = null;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Debug.Log("Dont Destroy on load: " + name);
    }

    // Use this for initialization
    void Start()
    {
        AudioClip thisLevelMusic = musicArray[0];
        //play miusic on splash screen
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = thisLevelMusic;
        audioSource.Play();
    }

    void OnLevelWasLoaded(int Level)
    {
        Debug.Log("Level number is : " + Level);
        AudioClip thisLevelMusic = musicArray[Level];
        Debug.Log("Playing clip:" + musicArray[Level]);
        if (musicArray[Level])
        {
            audioSource.clip = thisLevelMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }

    
}
   /* 
    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            print("Duplicate Music Player destroying itself");
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
*/