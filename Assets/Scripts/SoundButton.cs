﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour {

	public Sprite soundSprite;
    public Sprite muteSprite;
    private Image image;

	// Use this for initialization
	void Start () {
        image = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		if (GameController.instance.mute) {
			image.sprite = muteSprite;
		} else {
			image.sprite = soundSprite;
		}
	}
}