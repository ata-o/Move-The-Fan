using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Success : MonoBehaviour
{
    public bool levelOver;
    public GameObject NextLevelButton;
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        levelOver = false;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Ball") {
            levelOver = true;
            Debug.Log("Level Success.");
            NextLevelButton.SetActive(true);
            canvas.SetActive(true);
        }
        
    }
}
