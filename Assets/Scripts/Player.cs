using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Animation thisAnimation;
    public float Force = 100;
    private Rigidbody thisRigidbody = null;



    void Start()
    {
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
        thisRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))

            thisRigidbody.AddForce(Vector3.up * Force);
   
        thisAnimation.Play();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")

            GameManager.thisManager.GameOver();
        SceneManager.LoadScene("GameOver");
        
    }
}
