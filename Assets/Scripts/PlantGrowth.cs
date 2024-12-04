using UnityEngine;

public class PlantGrowth : MonoBehaviour
{
    
    public float maxGrowthRate = 1f;      // �������� �����
    public float growthRate;              // �������� �������� �����

    public float maxScale = 1.5f;         // ������������ ������ ��������

    private Renderer plantRenderer;

    private void Start()
    {
        plantRenderer = GetComponent<Renderer>();

        growthRate = Random.Range(0.05f, maxGrowthRate);  // ��������� �������� �����
        float initialScale = Random.Range(0.3f, 0.7f);  // ��������� ��������� ������

        transform.localScale = new Vector3
        (
            transform.localScale.x, initialScale, transform.localScale.z
        );
    }

    void Update()
    {
        // ����������� ������ ��������, ���� �� ��������� �������������
        if (transform.localScale.y < maxScale)
        {
            transform.localScale += new Vector3(0, growthRate * Time.deltaTime, 0);
        }

        // ���� �������� �������� � ����������� �� �������� �������
        float growthProgress = transform.localScale.y / maxScale;
        plantRenderer.material.color = Color.Lerp(Color.green, Color.red, growthProgress);
    }

    
}
