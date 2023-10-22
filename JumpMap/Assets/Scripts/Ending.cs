using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // �� ���� ��� ���

public class Ending : MonoBehaviour
{
    public string EndingScene; // ���� �� �̸�

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // �÷��̾�� �浹�� ���
        {
            // ���� ������ ��ȯ
            SceneManager.LoadScene(EndingScene);
        }
    }
}
