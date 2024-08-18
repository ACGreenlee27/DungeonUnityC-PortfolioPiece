using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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