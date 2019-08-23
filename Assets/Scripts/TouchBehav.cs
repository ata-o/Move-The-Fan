using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchBehav : MonoBehaviour
{
    public GameObject ui;
    public GameObject fan;
    private FanRotate rotScript;
    public Vector3 currentTouchPosition;

    // Start is called before the first frame update
    void Start()
    {
        rotScript = fan.GetComponent<FanRotate>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Moved || Input.GetTouch(i).phase == TouchPhase.Stationary)
            {
                ui.transform.position = Input.GetTouch(i).position;
                currentTouchPosition = Input.GetTouch(i).position;
                rotScript.activeRotate = true;
                }
            else if (Input.GetTouch(i).phase == TouchPhase.Ended) {
                rotScript.activeRotate = false;
            }
        }
    }
}
