﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAudioVolumeToScriptVolume : MonoBehaviour
{
	public AudioSource audioSource;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		audioSource.volume = xa.soundVolume;
	}
}
