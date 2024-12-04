using UnityEngine;

public class PlantReproduce : MonoBehaviour
{
    public float reproductionSize = 1.0f; // ������ ��� �����������
    public GameObject plantPrefab;        // ������ ��� �����������

    private float maxScale;         // ������������ ������ �������� �� ������� �����

    void Update()
    {
        maxScale = GetComponent<PlantGrowth>().maxScale; //��������� ������ �� ������� �����

        // ����������� ��� ���������� ������������� �������
        if (transform.localScale.y >= reproductionSize)
        {
            Reproduce();
            reproductionSize = maxScale + 1; // ������������� ��������� �����������
        }
    }

    void Reproduce()
    {
        Vector3 spawnPosition = transform.position + new Vector3(
            Random.Range(-1.0f, 1.0f), 0, Random.Range(-1.0f, 1.0f));

        // ������� ����� �������� � ������ ��� ��������� ������
        GameObject newPlant = Instantiate(plantPrefab, spawnPosition, Quaternion.identity);
        newPlant.transform.localScale = new Vector3(0.2f, 0.5f, 0.2f); // ������������� ��������� ������

        newPlant.GetComponent<PlantGrowth>().growthRate = Random.Range(0.0f, 1.0f);
    }
}
