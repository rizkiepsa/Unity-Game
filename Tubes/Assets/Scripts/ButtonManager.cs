using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource buttonSound;

    public void button()
    {
        buttonSound.PlayOneShot(buttonSound.clip);
    }
}
