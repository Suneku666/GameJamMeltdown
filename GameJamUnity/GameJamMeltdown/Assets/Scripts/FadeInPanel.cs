using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInPanel : MonoBehaviour {

    public float fadeInTime = 1.5f;

    private Image fadePanel;
    private Color CurrentColor = Color.black;

	// Use this for initialization
	void Start () {
        fadePanel = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.timeSinceLevelLoad < fadeInTime)
        {
            //Fade in
            float alphaChange = Time.deltaTime / fadeInTime;
            CurrentColor.a -= alphaChange;
            fadePanel.color = CurrentColor;
        }
        else
        {
            gameObject.SetActive(false);
        }
	}
}
