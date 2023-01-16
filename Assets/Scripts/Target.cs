using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Target : MonoBehaviour
{
    private GameManager _GameManagerScript;
    public int pointValue;
    public ParticleSystem explosionParticle;
    public AudioClip targetHitSound;

    private Rigidbody targetRb;
    private float minSpeed = 12;
    private float maxSpeed = 16;
    private float maxTorque = 10;
    private float xRange = 4;
    private float ySpawnPos = -2;

    public void MouseInterScript()
    {
        if (_GameManagerScript.gameIsActive)
        {
            _GameManagerScript.playerAudio.PlayOneShot(targetHitSound, 1.0f);
            Destroy(gameObject);
            // print($"New InputSystem on left mouse click called on {this.name}!");
            _GameManagerScript.UpdateScore(pointValue);
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        _GameManagerScript = GameObject.Find("Game Manager").GetComponent<GameManager>();
        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        transform.position = RandomSpawnPosition();
    }

    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }

    Vector3 RandomSpawnPosition()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
    }

    //private void OnMouseDown() // Not functionning with the new Input system
    //{
    //    Destroy(gameObject);
    //}

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if (!gameObject.CompareTag("Bad"))
        {
            _GameManagerScript.GameOver();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
