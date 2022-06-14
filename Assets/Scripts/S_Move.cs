using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class S_Move : MonoBehaviour
{
    public float speed;
    private float speedIni;

    private Animator animator;

    private Vector3 up = Vector3.zero;
    private Vector3 right = new Vector3(0,90,0);
    private Vector3 down = new Vector3(0, 180, 0);
    private Vector3 left = new Vector3(0, 270, 0);
    private Vector3 current = Vector3.zero;

    private Vector3 initialPosition;

    private bool isMoving;
    private bool isDead;
    public int lifes;
    private int coins;
    public int numberOfCoins; //1169
    public Text coinsRecollected;
    public Text lifesLeft;

    public AudioSource audioSpecialCoin;
    public AudioSource audioCoin;
    public AudioSource audioDeath;


    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
        speedIni = speed;
        animator = GetComponent<Animator>();
        coins = 0;
        lifesLeft.text = "Lifes: " + lifes;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            audioDeath.Play();
            animator.SetBool("isDead", true);
        } else if (other.gameObject.tag == "Wall")
        {
            animator.SetBool("isMoving", false);
            isMoving = false;
        } 
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            other.gameObject.SetActive(false);
            audioCoin.Play();
            coins++;
            coinsRecollected.text = "Coins: " + coins;
            if (coins == numberOfCoins)
            {
                SceneManager.LoadScene("Win");
            }
        } else if (other.gameObject.tag == "SpecialCoin")
        {
            other.gameObject.SetActive(false);
            audioSpecialCoin.Play();
            coins++;
            speed += 2;
            coinsRecollected.text = "Coins: " + coins;
            if (coins == numberOfCoins)
            {
                SceneManager.LoadScene("Win");
            }
        } else if (other.gameObject.tag == "Trap")
        {
            audioDeath.Play();
            animator.SetBool("isDead", true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        isDead = animator.GetBool("isDead");

        if (isDead) {
            isMoving = false;
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            current = up;
            isMoving = true;
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            current = down;
            isMoving = true;
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            current = right;
            isMoving = true;
        }
        else if (Input.GetAxis("Vertical") > 0)
        {
            current = left;
            isMoving = true;
        }
        animator.SetBool("isMoving", true);

        transform.localEulerAngles = current;
        if (isMoving)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

    }

    public void Reset()
    {
        if (lifes == 0)
        {
            SceneManager.LoadScene("GameOver");
        } else
        {
            speed = speedIni;
            transform.position = initialPosition;
            animator.SetBool("isDead", false);
            animator.SetBool("isMoving", false);
            current = left;
        } 
    }
}
