using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour
{

    private AudioSource CheckpointSound;
    private bool levelCompleted = false;

    void Start()
    {
        CheckpointSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name =="Player" && !levelCompleted)
        {
            CheckpointSound.Play();
            levelCompleted = true;
            Invoke("CompleteLevel", 2f);
            
        }
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
