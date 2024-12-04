using System;
using Unity.VisualScripting;
using UnityEngine;

public class PlantDeath : MonoBehaviour
{
    public float lifespan = 10f;          // Продолжительность жизни растения
    private float age = 0f;               // Возраст растения

    void Update()
    {
        // Проверка на возраст растения
        age += Time.deltaTime;
        if (age >= lifespan)
        {
            Destroy(gameObject); // Удаляем растение по истечении жизни
        }
    }
}
