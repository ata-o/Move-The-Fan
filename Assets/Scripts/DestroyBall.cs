using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBall : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) {
        Debug.Log(other.tag);
        if (other.tag == "Ball") {
            Destroy(other.gameObject);
        }
    }
}
