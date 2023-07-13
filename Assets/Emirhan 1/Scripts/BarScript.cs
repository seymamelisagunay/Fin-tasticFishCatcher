using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarScript : MonoBehaviour
{
    public ProgressBar Pb;
    public int value = 0;
    int trueCheck = 1;
    int falseCheck = 1;

    

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    void Update()
    {
        if(trueCheck==QTE2.FinalTrues)
        {
            audioSource.Play();
            trueCheck++;
        }

        value = QTE2.FinalTrues * 10;

        Pb.BarValue = value;

    }
}
