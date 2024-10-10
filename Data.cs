using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        PlayerHealth();
        score();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void PlayerHealth()
    {
        int health = 100;
        int armor = 80;
        while (health > 0)
        {
            health -= 10;
            Debug.Log("Sisa Nyawa : " + health);

            if (health > 50)
            {
                Debug.Log("Pemain Sehat");
            }
            else if (health > 20)
            {
                Debug.Log("Pemain Perlu Berhati-hati");
            }
            else
            {
                Debug.Log("Pemain Dalam Bahaya");
            }
            if (armor > 30 && health> 50)
            {
                Debug.Log("Pemain Siap Bertarung");
            }
            else
            {
                Debug.Log("Pemain Perlu Bersiap");
            }
        }
        Debug.Log("Mokad");
    }
    void score()
    {
        int[] scores = { 100, 90, 85,70 ,60 };
        int totalScores = 0;

        foreach(int score in scores)
        {
            totalScores += score;
        }

        int nilaiRataRata = totalScores / scores.Length;
        Debug.Log("Total Score = " + nilaiRataRata);

        if (totalScores > 80)
        {
            Debug.Log("Pemain Berkualitas Tinggi");
        }
        else
        {
            Debug.Log("Pemain Butuh Latihan");
        }
    }

    void StatusHealth()
    {
        
    }
}
