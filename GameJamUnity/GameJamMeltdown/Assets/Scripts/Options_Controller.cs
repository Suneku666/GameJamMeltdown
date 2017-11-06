using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Options_Controller : MonoBehaviour {

    public Slider volumeSlider;
    public Slider difficultySlider;

    private MusicPlayer musicPlayer;
    

    // Use this for initialization
    void Start () {
        musicPlayer = FindObjectOfType<MusicPlayer>();      
    }
	
	// Update is called once per frame
	void Update () {
		
	}



    void applyChanges()
    {
        PlayerPrefManager.SetDifficulty(difficultySlider.value);
        PlayerPrefManager.SetMasterVolume(volumeSlider.value);

    }
}
