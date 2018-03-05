using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlay : MonoBehaviour {

    public VideoClip[] VideoClips;

    public int VideoClipIndex;

    private VideoPlayer VideoPlayer;

    private void Awake()
    {
        VideoPlayer = GetComponent<VideoPlayer>();
    }



    // Use this for initialization
    void Start () {
        //VideoClipIndex = VideoClipIndex % VideoClips.Length; 
        VideoClipIndex = 0;
        VideoPlayer.clip = VideoClips[VideoClipIndex];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
