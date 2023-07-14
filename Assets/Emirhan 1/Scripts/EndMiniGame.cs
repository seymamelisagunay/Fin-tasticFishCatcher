using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndMiniGame : MonoBehaviour
{
    int fish;
    float kilo;
    bool once = true;

    public Image icon1;
    public Image icon2;
    public Image icon3;
    public Image icon4;
    public Image icon5;


    public GameObject table1;
    public GameObject table2;
    public GameObject table3;
    public GameObject table4;
    public GameObject table5;
    public GameObject failTable;

    [SerializeField] public TextMeshProUGUI table1Kilo;
    [SerializeField] public TextMeshProUGUI table2Kilo;
    [SerializeField] public TextMeshProUGUI table3Kilo;
    [SerializeField] public TextMeshProUGUI table4Kilo;
    [SerializeField] public TextMeshProUGUI table5Kilo;

    public Image cross1;
    public Image cross2;
    public Image cross3;



    // Update is called once per frame
    void Update()
    {
        if(BarScript.value==100)
        {
            if(once)
            {
                fish = Random.Range(1, 6);
                kilo = Random.Range(1, 8);
                once = false;
            }
            
            Debug.Log("Fish value: " + fish);

            if (fish==1)
            {
                table1.SetActive(true);
                table1Kilo.text = "Kilo: " + kilo.ToString();
                Color imageColor1 = icon1.color;
                imageColor1.a = 1f;
                icon1.color = imageColor1;
            }
            if(fish==2)
            {
                table2.SetActive(true);
                table2Kilo.text = "Kilo: " + kilo.ToString();
                Color imageColor2 = icon2.color;
                imageColor2.a = 1f;
                icon2.color = imageColor2;

            }
            if (fish == 3)
            {
                table3.SetActive(true);
                table3Kilo.text = "Kilo: " + kilo.ToString();
                Color imageColor3 = icon3.color;
                imageColor3.a = 1f;
                icon3.color = imageColor3;
            }
            if (fish == 4)
            {
                table4.SetActive(true);
                table4Kilo.text = "Kilo: " + kilo.ToString();
                Color imageColor4 = icon4.color;
                imageColor4.a = 1f;
                icon4.color = imageColor4;
            }
            if (fish == 5)
            {
                table5.SetActive(true);
                table5Kilo.text = "Kilo: " + kilo.ToString();
                Color imageColor5 = icon5.color;
                imageColor5.a = 1f;
                icon5.color = imageColor5;
            }
        }

        if (QTE2.FinalFalses == 3)
        {
            failTable.SetActive(true);
        }

    }
}
