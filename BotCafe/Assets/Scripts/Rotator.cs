using UnityEngine;
using System.Collections;
 
 public class Rotator : MonoBehaviour {

    void OnMouseDown()

    {

        //transform.localScale *= 1.1f;

    }

     float f_lastX = 0.0f;
     float f_difX = 0.5f;
     float f_steps = 0.0f;
     int i_direction = 1;
 
     // Use this for initialization
     void Start () 
     {
         
     }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("mouse pressed");
            f_difX = Random.Range(-10f, 10f);

            transform.Rotate(Vector3.up, f_difX);
        } else
        {
            if (f_difX > 0.5f) f_difX -= 0.01f;
            if (f_difX < -0.5f) f_difX += 0.01f;

            transform.Rotate(Vector3.up, f_difX);
        }
    }

    void OldRotation () 
     {
         if (Input.GetMouseButtonDown(0))
         {
             f_difX = 0.0f;
         }
         else if (Input.GetMouseButton(0))
         {
             f_difX = Mathf.Abs(f_lastX - Input.GetAxis ("Mouse X"));
 
             if (f_lastX < Input.GetAxis ("Mouse X"))
             {
                 i_direction = -1;
                 transform.Rotate(Vector3.up, -f_difX);
             }
 
             if (f_lastX > Input.GetAxis ("Mouse X"))
             {
                 i_direction = 1;
                 transform.Rotate(Vector3.up, f_difX);
             }
 
             f_lastX = -Input.GetAxis ("Mouse X");
         }
         else 
         {
             if (f_difX > 0.5f) f_difX -= 0.05f;
             if (f_difX < 0.5f) f_difX += 0.05f;
 
             transform.Rotate(Vector3.up, f_difX * i_direction);
         }
     }
 }