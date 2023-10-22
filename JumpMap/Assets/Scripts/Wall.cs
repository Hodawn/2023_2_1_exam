using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random; // Random 클래스 사용

public class Wall : MonoBehaviour
{
    public List<GameObject> mapObjects; // 맵 오브젝트를 저장할 리스트

    public Color[] availableColors; // 사용 가능한 색상 목록

    void Start()
    {
        // 맵 오브젝트의 색상 무작위로 변경
        RandomizeColors();
    }

    void RandomizeColors()
    {
        foreach (GameObject mapObject in mapObjects)
        {
            // 사용 가능한 색상 중에서 무작위로 하나 선택
            Color randomColor = availableColors[Random.Range(0, availableColors.Length)];

            // 오브젝트의 렌더러 컴포넌트를 찾아 색상 변경
            Renderer objectRenderer = mapObject.GetComponent<Renderer>();
            if (objectRenderer != null)
            {
                objectRenderer.material.color = randomColor;
            }
        }
    }
}
