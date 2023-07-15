using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QTE2 : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI DisplayBox;
    [SerializeField] public TextMeshProUGUI PassBox;

    public int QTEGenner;
    public int WaitingForKey;
    public int CorrectKey;
    public int CountingDown;
    public int Trues = 0;
    public int Falses= 0;
    public static int FinalTrues;
    public static int FinalFalses;




    // Update is called once per frame
    void Update()
    {
        if(EndMiniGame.gameOver)
        {

        if (WaitingForKey == 0)
        {
            QTEGenner = Random.Range(1, 4);
            CountingDown = 1;
            StartCoroutine(CountDown());

            if (QTEGenner == 1)
            {
                WaitingForKey = 1;
                DisplayBox.text = "D";
            }

            if (QTEGenner == 2)
            {
                WaitingForKey = 1;
                DisplayBox.text = "F";
            }

            if (QTEGenner == 3)
            {
                WaitingForKey = 1;
                DisplayBox.text = "G";
            }
        }

        if (QTEGenner == 1)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.D))
                {
                    CorrectKey = 1;
                    StartCoroutine(KeyPressing());
                }
                else
                {
                    CorrectKey = 2;
                    StartCoroutine(KeyPressing());
                }
            }
        }

        if (QTEGenner == 2)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    CorrectKey = 1;
                    StartCoroutine(KeyPressing());
                }
                else
                {
                    CorrectKey = 2;
                    StartCoroutine(KeyPressing());
                }
            }
        }

        if (QTEGenner == 3)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.G))
                {
                    CorrectKey = 1;
                    StartCoroutine(KeyPressing());
                }
                else
                {
                    CorrectKey = 2;
                    StartCoroutine(KeyPressing());
                }
            }
        }


        
    }


    IEnumerator KeyPressing()
    {
        QTEGenner = 4;
        if (CorrectKey == 1)
        {
            CountingDown = 2;
            PassBox.text = "PASS!";
            Trues++;
            FinalTrues = Trues;
            yield return new WaitForSeconds(0.65f);
            CorrectKey = 0;
            PassBox.text = "";
            DisplayBox.text = "";
            yield return new WaitForSeconds(0.65f);
            WaitingForKey = 0;
            CountingDown = 1;
        }

        if (CorrectKey == 2)
        {
            CountingDown = 2;
            PassBox.text = "FAIL!";
            Falses++;
            FinalFalses = Falses;
            yield return new WaitForSeconds(0.65f);
            CorrectKey = 0;
            PassBox.text = "";
            DisplayBox.text = "";
            yield return new WaitForSeconds(0.65f);
            WaitingForKey = 0;
            CountingDown = 1;
        }
    }

    IEnumerator CountDown()
    {
        yield return new WaitForSeconds(1f);
        if (CountingDown == 1)
        {
            QTEGenner = 4;
            CountingDown = 2;
            PassBox.text = "FAIL!";
            Falses++;
            FinalFalses = Falses;
            yield return new WaitForSeconds(0.65f);
            CorrectKey = 0;
            PassBox.text = "";
            DisplayBox.text = "";
            yield return new WaitForSeconds(0.65f);
            WaitingForKey = 0;
            CountingDown = 1;
        }
    }
}
}
