using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    
    public float rotationSpeed = 100f; // Gemiyi döndürme hızı
    public float movementSpeed = 5f; // Gemiyi hareket ettirme hızı

    void Update()
    {
        float rotation = Input.GetAxis("Horizontal"); // Yatay dönme girişi (A ve D veya sol ve sağ ok tuşları)
        float movement = Input.GetAxis("Vertical"); // Hareket girişi (W ve S veya yukarı ve aşağı ok tuşları)

        // Gemiyi döndürme
        transform.Rotate(0f, rotation * rotationSpeed * Time.deltaTime, 0f);

        // Gemiyi hareket ettirme
        Vector3 moveDirection = new Vector3(-movement, 0f, 0f);
        transform.Translate(moveDirection.normalized * movementSpeed * Time.deltaTime);
    }
}


