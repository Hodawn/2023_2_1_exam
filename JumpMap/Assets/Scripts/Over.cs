using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 씬 관리 기능 사용

public class Over : MonoBehaviour
{
    public string GameOverScene; // 엔딩 씬 이름

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // 플레이어와 충돌한 경우
        {
            // 엔딩 씬으로 전환
            SceneManager.LoadScene(GameOverScene);
        }
    }
}
