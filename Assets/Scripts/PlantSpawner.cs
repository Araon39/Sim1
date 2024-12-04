using UnityEngine;

public class PlantSpawner : MonoBehaviour
{
    public GameObject plantPrefab;

    public int numberOfPlants = 100;                        //количество растений
    public Vector3 spawnArea = new Vector3(100, 0, 100);    //квадрат для спавна

    void Start()
    {
        //на старте спавним от 0 до указаного числа
        for (int i = 0; i < numberOfPlants; i++)
        {
            SpawnPlant();
        }
    }

    void SpawnPlant()
    {
        //переменая рондомной позиции 
        Vector3 position = new Vector3(
            Random.Range(-spawnArea.x / 2, spawnArea.x / 2),
            0.5f,
            Random.Range(-spawnArea.z / 2, spawnArea.z / 2)
        );

        //спавн кого, где, с повортом
        Instantiate(plantPrefab, position, Quaternion.identity);
    }
}
