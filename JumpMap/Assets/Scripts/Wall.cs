using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random; // Random Ŭ���� ���

public class Wall : MonoBehaviour
{
    public List<GameObject> mapObjects; // �� ������Ʈ�� ������ ����Ʈ

    public Color[] availableColors; // ��� ������ ���� ���

    void Start()
    {
        // �� ������Ʈ�� ���� �������� ����
        RandomizeColors();
    }

    void RandomizeColors()
    {
        foreach (GameObject mapObject in mapObjects)
        {
            // ��� ������ ���� �߿��� �������� �ϳ� ����
            Color randomColor = availableColors[Random.Range(0, availableColors.Length)];

            // ������Ʈ�� ������ ������Ʈ�� ã�� ���� ����
            Renderer objectRenderer = mapObject.GetComponent<Renderer>();
            if (objectRenderer != null)
            {
                objectRenderer.material.color = randomColor;
            }
        }
    }
}
