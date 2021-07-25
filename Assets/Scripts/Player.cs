using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public float jumpForce = 10f;    
    public Rigidbody2D rb;
    public string currentColor;
    public SpriteRenderer sr;
    public Color Cyan;
    public Color Pink;
    public Color Magenta;
    public Color Yellow;
    public Text gameOver;
    public Text retryText;



    private void Start()
    {
        SetRandomColor();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0)){
            rb.velocity = Vector2.up * jumpForce;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag != currentColor && collision.tag!="Changer" && collision.tag!="Spawner"  )
        {
            gameObject.active = false;
            gameOver.enabled = true;
            retryText.enabled = true;



        }
        if (collision.tag == "Changer")
        {
            Color[] colors = { Cyan, Pink, Magenta, Yellow };
            string[] colorsString = { "Cyan", "Pink", "Magenta", "Yellow" };

            int index = Random.Range(0, 4);
            sr.color = colors[index];
            currentColor = colorsString[index];
            Destroy(collision.gameObject);

        }
    }
    void SetRandomColor()
    {
        int index = Random.Range(0, 4);
        string[] colors = { "Pink", "Magenta", "Cyan", "Yellow" };
        currentColor = colors[index];
        if(currentColor == "Pink")
        {
            sr.color = Pink;
        }
        if (currentColor == "Cyan")
        {
            sr.color = Cyan;
        }
        if (currentColor == "Yellow")
        {
            sr.color = Yellow;
        }
        if (currentColor == "Magenta")
        {
            sr.color = Magenta;
        }

    }
}
