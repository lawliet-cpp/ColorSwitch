using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class FollowPlayer : MonoBehaviour
{
    public Transform Player;
    public Text startText;
    public Vector3 offset;
    // Update is called once per frame
    private void Start()
    {
        Time.timeScale = 0;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1;
            startText.enabled = false;
            
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (Player.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, Player.position.y, transform.position.z);
        }
    }
}
