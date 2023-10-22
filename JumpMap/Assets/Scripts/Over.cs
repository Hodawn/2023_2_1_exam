using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // �� ���� ��� ���

public class Over : MonoBehaviour
{
    public string GameOverScene; // ���� �� �̸�

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // �÷��̾�� �浹�� ���
        {
            // ���� ������ ��ȯ
            SceneManager.LoadScene(GameOverScene);
        }
    }
}
