using System;
using Unity.VisualScripting;
using UnityEngine;

public class PlantDeath : MonoBehaviour
{
    public float lifespan = 10f;          // ����������������� ����� ��������
    private float age = 0f;               // ������� ��������

    void Update()
    {
        // �������� �� ������� ��������
        age += Time.deltaTime;
        if (age >= lifespan)
        {
            Destroy(gameObject); // ������� �������� �� ��������� �����
        }
    }
}
