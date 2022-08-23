using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [SerializeField] AudioClip rollSound; 
    [SerializeField] AudioClip finishSound;
    AudioSource audioSource;
    bool isCompleted = false;
    Rigidbody rb;
    [SerializeField] float veli;
    [SerializeField] ParticleSystem succesParticles;
    // Start is called before the first frame update

    private void OnCollisionStay(Collision other) 
    {
        if(isCompleted)
        {
            return;
        }
        if(other.gameObject.tag == "Floor")
        {
            if(!audioSource.isPlaying)
            {
                audioSource.PlayOneShot(rollSound);
            }
        }
        else if(other.gameObject.tag != "FINISH")
        {
            audioSource.Stop();
        }
    }
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "FINISH")
        {
            isCompleted = true;
            succesParticles.Play();
            audioSource.PlayOneShot(finishSound);
        }
    }
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        audioSource.pitch = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(isCompleted)
        {
            audioSource.pitch = 3f;
        }
        else
        {
            audioSource.pitch = Mathf.Clamp(rb.velocity.magnitude / 3, 0f, 3f);
        }
        
    }
}
