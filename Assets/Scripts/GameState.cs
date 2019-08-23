using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{
    public bool fail;
    public GameObject failScreen;
    public GameObject restartButton;

    // Start is called before the first frame update
    void Start()
    {
        fail = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (fail) {
            
            StartCoroutine(WaitForBallDestroy());
            
        }
    }

    IEnumerator WaitForBallDestroy()
    {
        yield return new WaitForSeconds(1);
        failScreen.SetActive(true);
        restartButton.SetActive(true);
    }

}
