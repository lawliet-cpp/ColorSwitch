using UnityEngine;

public class Rotator : MonoBehaviour
{
   
    public float rotationForce;
   
    
    // Update is called once per frame
    void Update()
    {

        transform.Rotate(Vector3.forward, rotationForce * Time.deltaTime);
    }
}
