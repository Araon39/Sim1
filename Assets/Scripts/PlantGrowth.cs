using UnityEngine;

public class PlantGrowth : MonoBehaviour
{
    
    public float maxGrowthRate = 1f;      // Скорость роста
    public float growthRate;              // Итоговая Скорость роста

    public float maxScale = 1.5f;         // Максимальный размер растения

    private Renderer plantRenderer;

    private void Start()
    {
        plantRenderer = GetComponent<Renderer>();

        growthRate = Random.Range(0.05f, maxGrowthRate);  // Случайная скорость роста
        float initialScale = Random.Range(0.3f, 0.7f);  // Случайный начальный размер

        transform.localScale = new Vector3
        (
            transform.localScale.x, initialScale, transform.localScale.z
        );
    }

    void Update()
    {
        // Увеличиваем размер растения, пока не достигнем максимального
        if (transform.localScale.y < maxScale)
        {
            transform.localScale += new Vector3(0, growthRate * Time.deltaTime, 0);
        }

        // Цвет растения меняется в зависимости от текущего размера
        float growthProgress = transform.localScale.y / maxScale;
        plantRenderer.material.color = Color.Lerp(Color.green, Color.red, growthProgress);
    }

    
}
