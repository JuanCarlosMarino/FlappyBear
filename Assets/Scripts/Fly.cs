using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public GameManager gameManager;
    
    [Header("Velocity of flight: ")]
    [Tooltip("This field is velocity in unity units")]
    [SerializeField] public float velocity = 1;

    private AudioSource audio;
    private Rigidbody2D _rigidbody2D;
    [SerializeField] public AudioClip clic;
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _rigidbody2D.velocity = Vector2.up * velocity;
            source.PlayOneShot(clic);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
        audio.Stop();
    }

    private AudioSource source
    {
        get
        {
            return GetComponent<AudioSource>();
        }
    }

}
