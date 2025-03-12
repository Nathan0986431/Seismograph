using System;
using Unity.VisualScripting;
using UnityEngine;

public class KeyInputCroshair : MonoBehaviour
{
    public float Speed = 3f;
    public KeyCode UpDirection;
    public KeyCode DownDirection;
    public KeyCode LeftDirection;
    public KeyCode RightDirection;
    public float Xlimit = 16f;
    public float Ylimit = 16f;
   
    void Start()
    {
       
    }


    void Update()
    {
        if (GameBehavior.Instance.State == Utilities.GameplayState.Play)
        {
            float Xmovement = 0f;
            float Ymovement = 0f;
        

            if (Input.GetKey(UpDirection))
            {
                Ymovement += Speed;
            }

            if (Input.GetKey(DownDirection) && transform.position.y < Ylimit)
            {
                Ymovement -= Speed;
            }

            if (Input.GetKey(LeftDirection) && transform.position.x > -Xlimit)
            {
                Xmovement -= Speed;
            }

            if (Input.GetKey(RightDirection) && transform.position.x < Xlimit)
            {
                Xmovement += Speed;
            }

            transform.position += new Vector3(Xmovement, Ymovement, 0) * Time.deltaTime;
        }
    }


//     private void OnTriggerEnter2D(Collider2D other)
//     {
//         
//         if (other.gameObject.CompareTag("Bounds"))
//         {
//             Speed = 0f;
//         }
//     }
}
