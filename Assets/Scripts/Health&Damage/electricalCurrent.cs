using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class electricalCurrent : MonoBehaviour
{
    public AudioSource electricalCurrentStopped;
    private void OnDestroy() {
       // electricalCurrentStopped.Play();
    }
}
