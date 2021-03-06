﻿using UnityEngine;
using System.Collections;

public class WaveIndicator : MonoBehaviour {

    Renderer _renderer;
    Transform _transform;
    Renderer waveIncomingTextRenderer;

	// Use this for initialization
	void Start () {
        _renderer = GetComponent<Renderer>();
        _transform = gameObject.transform;
        this.waveIncomingTextRenderer = GameObject.Find("wave_incoming_text").GetComponent<Renderer>();
        _renderer.enabled = false;
        this.waveIncomingTextRenderer.enabled = false;
	}
	
	public void Indicate(WaveDirection direction)
    {
        switch (direction)
        {
            case WaveDirection.UP:
                _transform.eulerAngles = new Vector3(270, 180, 0);
                break;
            case WaveDirection.RIGHT:
                _transform.eulerAngles = new Vector3(270, 270, 0);
                break;
            case WaveDirection.DOWN:
                _transform.eulerAngles = new Vector3(270, 0, 0);
                break;
            case WaveDirection.LEFT:
                _transform.eulerAngles = new Vector3(270, 90, 0);
                break;
        }

        _renderer.enabled = true;
        waveIncomingTextRenderer.enabled = true;
    }

    public void Hide()
    {
        _renderer.enabled = false;
        this.waveIncomingTextRenderer.enabled = false;
    }
}
