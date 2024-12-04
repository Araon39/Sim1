using UnityEngine;

public class PlantReproduce : MonoBehaviour
{
    public float reproductionSize = 1.0f; // Размер для размножения
    public GameObject plantPrefab;        // Префаб для размножения

    private float maxScale;         // Максимальный размер растения из скрипта роста

    void Update()
    {
        maxScale = GetComponent<PlantGrowth>().maxScale; //проверяем размер из скрипта роста

        // Размножение при достижении определенного размера
        if (transform.localScale.y >= reproductionSize)
        {
            Reproduce();
            reproductionSize = maxScale + 1; // Предотвращаем повторное размножение
        }
    }

    void Reproduce()
    {
        Vector3 spawnPosition = transform.position + new Vector3(
            Random.Range(-1.0f, 1.0f), 0, Random.Range(-1.0f, 1.0f));

        // Создаем новое растение и задаем его начальный размер
        GameObject newPlant = Instantiate(plantPrefab, spawnPosition, Quaternion.identity);
        newPlant.transform.localScale = new Vector3(0.2f, 0.5f, 0.2f); // Устанавливаем начальный размер

        newPlant.GetComponent<PlantGrowth>().growthRate = Random.Range(0.0f, 1.0f);
    }
}
