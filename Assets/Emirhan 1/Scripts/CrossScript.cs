using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossScript : MonoBehaviour
{
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    int playCount = 0;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        if(QTE2.FinalFalses==1)
        {
            image1.SetActive(true);
            if(playCount==0)
            {
                audioSource.Play();
                playCount++;             
            }
        }

        if (QTE2.FinalFalses == 2)
        {
            
            image2.SetActive(true);           
            if (playCount == 1)
            {
                audioSource.Play();
                playCount++;
            }
        }

        if (QTE2.FinalFalses == 3)
        {
            
            image3.SetActive(true);
            if (playCount == 2)
            {
                audioSource.Play();
                playCount++;
            }
        }


    }
}
