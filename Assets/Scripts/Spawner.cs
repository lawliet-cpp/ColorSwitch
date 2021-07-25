using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Circle;
    public GameObject colorChanger;
    public Vector3 colorChangerOffset;
    public Vector3 offset;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(Circle, transform.position + offset, Quaternion.identity);
        Instantiate(colorChanger, transform.position + colorChangerOffset, Quaternion.identity);
        Instantiate(gameObject, transform.position + offset, Quaternion.identity);
       
        Destroy(gameObject);

    }
}
