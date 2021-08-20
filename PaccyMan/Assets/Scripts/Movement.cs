using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    Rigidbody2D Main_pac;
    float travel = 5.0f;
    public Score ScoreLabel;
    public GameObject Replayer;
    public GameObject Ttl;
    public GameObject Quit;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        Main_pac = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Main_pac.velocity = Vector2.up * travel;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.CompareTag("Entire Wall")) {
            ScoreLabel.Check_Score();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Floor")) {
            Time.timeScale = 0;
            Replayer.SetActive(true);
            Ttl.SetActive(true);
            Quit.SetActive(true);
        }
        if (collision.gameObject.CompareTag("Wall")) {
            Time.timeScale = 0;
            Replayer.SetActive(true);
            Ttl.SetActive(true);
            Quit.SetActive(true);
        }
    }

    public void Replay() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame() {
        Application.Quit();
    }
}
