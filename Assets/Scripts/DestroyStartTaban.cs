using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyStartTaban : MonoBehaviour
{
    public GameObject taban;

    private void OnTriggerEnter(Collider other) {
        Destroy(taban);
    }
}
