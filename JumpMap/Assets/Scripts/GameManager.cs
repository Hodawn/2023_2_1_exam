using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // �ٽ� ������ ���� �̸� (�� �̸��� ������Ʈ�� ���� �ٸ� �� �ֽ��ϴ�)
    public string restartSceneName = "PlayScene";

    public void RestartGame()
    {
        // ���� ������Ʈ �ʱ�ȭ �� �ٽ� ������ ������ �̵�
        // ���⿡ �ʱ�ȭ �� ���� �ڵ� �߰�
        SceneManager.LoadScene(restartSceneName);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
