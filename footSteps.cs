using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Super simple demo script to play sounds from an audiosource when a key or key combination is pressed. 
//In this case, this is the simple way I chose to handle footstep sounds for walking and sprinting in my demo project. 

public class footsteps : MonoBehaviour
{
    public AudioSource footstepsSound, sprintSound;

    void Update()
    {
        bool pressingKeys = Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetKey("a") || Input.GetKey("s");
        bool running = Input.GetKey(KeyCode.LeftShift);

        footstepsSound.enabled = pressingKeys && !running;
        sprintSound.enabled = pressingKeys && running;
    }
} 
