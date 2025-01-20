using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] float ballSpeed;
    public void MoveBall(Vector2 input){
        Vector3 inputXYZPlane = new(input.x,0,input.y);
        sphereRigidbody.AddForce(inputXYZPlane*ballSpeed);
    }
}
