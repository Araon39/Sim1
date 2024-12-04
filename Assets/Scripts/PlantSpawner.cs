using UnityEngine;

public class PlantSpawner : MonoBehaviour
{
    public GameObject plantPrefab;

    public int numberOfPlants = 100;                        //���������� ��������
    public Vector3 spawnArea = new Vector3(100, 0, 100);    //������� ��� ������

    void Start()
    {
        //�� ������ ������� �� 0 �� ��������� �����
        for (int i = 0; i < numberOfPlants; i++)
        {
            SpawnPlant();
        }
    }

    void SpawnPlant()
    {
        //��������� ��������� ������� 
        Vector3 position = new Vector3(
            Random.Range(-spawnArea.x / 2, spawnArea.x / 2),
            0.5f,
            Random.Range(-spawnArea.z / 2, spawnArea.z / 2)
        );

        //����� ����, ���, � ��������
        Instantiate(plantPrefab, position, Quaternion.identity);
    }
}
