using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanRotate : MonoBehaviour
{
    public float rpm;

    public float vertForce;
    public float ballThrust;
    public bool activeRotate;
    public GameObject target;
    public GameObject inputImage;
    protected TouchBehav touchScript;
    public GameObject GameInteractions;
    public Camera mainCamera;
    public GameObject Ball;

    private Rigidbody rbBall;
    // Start is called before the first frame update
    void Start() {
        activeRotate = false;
        touchScript = GameInteractions.GetComponent<TouchBehav>();
        rbBall = Ball.GetComponent<Rigidbody>();
    }
    public GameObject particle;
    // Update is called once per frame
    void Update() {
        if (activeRotate) {
            particle.SetActive(true);
            
             Ray ray = Camera.main.ScreenPointToRay(touchScript.currentTouchPosition);
             RaycastHit hit;

             if (Physics.Raycast(ray, out hit)) {
                 Debug.Log(hit.point.ToString());
             }

            var mouseWorldSpacePosition = hit.point;
            // move the fan in an arc
            Vector3 targetPos = Vector3.zero;
            targetPos.x = mouseWorldSpacePosition.x;
            float xSqrd = targetPos.x * targetPos.x;
            targetPos.y = 0.62f + (xSqrd / 4); // would give us the arc, 0.62 is the current y position of the fan
            targetPos.z = 3.9f;
            transform.position = targetPos;
            // rotate so that the fan always look at the center of the screen
            transform.rotation = Quaternion.Euler(0.0f, 0.0f, 45 * (transform.position.x));

            
        }
        else {
           particle.SetActive(false);
        }
    }

    void FixedUpdate() {
        // physics should be in fixedupdate

        if (activeRotate) {

            rbBall.AddForce(-1 * Time.deltaTime * transform.rotation.z * ballThrust * vertForce, Time.deltaTime * ballThrust * rpm, 0);
            

        }
    }
}

        