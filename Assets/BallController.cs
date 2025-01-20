using System.Numerics;
using Unity.VisualScripting.InputSystem;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Rigidbody sphereRigidbody;
    public float ballSpeed = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.Vector2 inputVector = UnityEngine.Vector2.zero;
        if(Input.GetKey(KeyCode.W)){
            inputVector += UnityEngine.Vector2.up;
        }
        if(Input.GetKey(KeyCode.S)){
            inputVector += UnityEngine.Vector2.down;
        }
        if(Input.GetKey(KeyCode.D)){
            inputVector += UnityEngine.Vector2.right;
        }
        if(Input.GetKey(KeyCode.A)){
            inputVector += UnityEngine.Vector2.left;
        }
        UnityEngine.Vector3 inputXYZPlane = new UnityEngine.Vector3(inputVector.x,0,inputVector.y);
        sphereRigidbody.AddForce(inputXYZPlane*ballSpeed);
        
    }
}
